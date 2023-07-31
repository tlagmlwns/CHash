using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moble
{
    public enum ProgressBarDisplayMode
    {
        NoText,
        Percentage,
        CurrProgress,
        CustomText,
        TextAndPercentage,
        TextAndCurrProgress
    }

    public class LabelProgressBar : ProgressBar
    {
        #region Variables

        [Description("Font of the text on ProgressBar"), Category("Additional Options")]
        public Font TextFont { get; set; } = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);

        private SolidBrush _textColourBrush = (SolidBrush)Brushes.Black;
        [Category("Additional Options")]
        public Color TextColor
        {
            get
            {
                return _textColourBrush.Color;
            }
            set
            {
                _textColourBrush.Dispose();
                _textColourBrush = new SolidBrush(value);
            }
        }

        private SolidBrush _progressColourBrush = (SolidBrush)Brushes.LightGreen;
        [Category("Additional Options"), Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public Color ProgressColor
        {
            get
            {
                return _progressColourBrush.Color;
            }
            set
            {
                _progressColourBrush.Dispose();
                _progressColourBrush = new SolidBrush(value);
            }
        }

        private ProgressBarDisplayMode _visualMode = ProgressBarDisplayMode.CurrProgress;
        [Category("Additional Options"), Browsable(true)]
        public ProgressBarDisplayMode VisualMode
        {
            get
            {
                return _visualMode;
            }
            set
            {
                _visualMode = value;
                Invalidate(); //redraw component after change value from VS Properties section
            }
        }

        private string _text = string.Empty;

        [Description("If it's empty, % will be shown"), Category("Additional Options"), Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public string CustomText
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
                Invalidate(); //redraw component after change value from VS Properties section
            }
        }

        private string TextToDraw
        {
            get
            {
                string text = CustomText;

                switch (VisualMode)
                {
                    case (ProgressBarDisplayMode.Percentage):
                        text = PercentageStr;
                        break;
                    case (ProgressBarDisplayMode.CurrProgress):
                        text = CurrProgressStr;
                        break;
                    case (ProgressBarDisplayMode.TextAndCurrProgress):
                        text = $"{CustomText}: {CurrProgressStr}";
                        break;
                    case (ProgressBarDisplayMode.TextAndPercentage):
                        text = $"{CustomText}: {PercentageStr}";
                        break;
                }

                return text;
            }
        }

        private string PercentageStr => $"{(int)((float)Value - Minimum) / ((float)Maximum - Minimum) * 100} %";

        private string CurrProgressStr => $"{Value}/{Maximum}";

        #endregion Variables

        #region Create & Load & Shown

        public LabelProgressBar()
        {
            this.Value = Minimum;

            FixComponentBlinking();
        }

        #endregion Create & Load & Shown

        #region Methods

        private void FixComponentBlinking()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void DrawProgressBar(Graphics g)
        {
            if (Value > 0)
            {
                Rectangle rectBorder = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
                Rectangle rectProgress = new Rectangle(1, 1, (int)(this.Width * ((double)Value / Maximum)) - 2, this.Height - 2);

                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

                using (Pen borderPen = new Pen(Color.Transparent, 2))
                {
                    g.DrawRectangle(borderPen, rectBorder);
                }

                // Draw the progress bar
                using (Brush progressBrush = new SolidBrush(Color.White))
                {
                    g.FillRectangle(progressBrush, rectProgress);
                }
            }
        }

        private void DrawStringIfNeeded(Graphics g)
        {
            if (VisualMode != ProgressBarDisplayMode.NoText)
            {
                string text = TextToDraw;
                SizeF len = g.MeasureString(text, TextFont);
                Point location = new Point(((Width / 2) - (int)len.Width / 2), ((Height / 2) - (int)len.Height / 2));

                g.DrawString(text, TextFont, (Brush)_textColourBrush, location);
            }
        }

        public new void Dispose()
        {
            _textColourBrush.Dispose();
            _progressColourBrush.Dispose();
            base.Dispose();
        }

        #endregion Methods

        #region Events

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            DrawProgressBar(g);

            DrawStringIfNeeded(g);
        }

        #endregion Events
    }
}