using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace Kiosk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Card
        {
            public string cardName;
            public int onePrice = 0;  // 1카드당 가격
            public int cardValue = 0; // 카드 장수
            public int cardPrice = 0; // 카드 총 가격
            public Card (string cN, int oP, int cV, int cP)
            {
                this.cardName = cN;
                this.cardPrice = cP;
                this.onePrice = oP; 
                this.cardValue = cV;
            }
            public Card() { }
        }
        
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            string strOrder = "";
            Card cardMhz = new Card(cbMhz.Text, int.Parse(mhzlbPrice.Text),int.Parse(textBox2.Text),( int.Parse(mhzlbPrice.Text)*int.Parse(textBox2.Text)));
            textBox1.Text = "";
            if (cbMhz.Checked == true)
            {
                strOrder += cbMhz.Text + "\n";
                textBox2.Text = hScrollBar1.Value.ToString();
            }
            textBox1.Text = cardMhz.cardName + "\n : " +cardMhz.cardValue+ "장 : "+cardMhz.cardPrice + "원\n";
        }
        
        private void btn_Buy_Click(object sender, EventArgs e)
        {
            if(textBox1 != null)
            {
                textBox3.Text = textBox1.Text + "어치\n";
                textBox1.Text = "";
            }
            else textBox3 = null;
                
        }

        private void btn_Cannel_Click(object sender, EventArgs e)
        {
            cbMhz.Checked = false;
            hScrollBar1.Value = 0;
            textBox1.Text = null;
            textBox2.Text = null;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int count = 20;
            if (textBox3.Text != null)
            {
                do
                {
                    int luk = random.Next(0, 10000);
                    if (luk > 0 && luk < 10)
                        MessageBox.Show("오 굿");
                    else if (luk > 11 && luk < 100)
                        MessageBox.Show("오");
                    else if (luk > 101 && luk < 500)
                        MessageBox.Show("평균");
                    else if (luk > 501 && luk < 5000)
                        MessageBox.Show("접어라 그냥");
                    else
                        MessageBox.Show("도박은 나빠요");
                    count--;

                }while(count > 0);
            }
        }
    }
}
