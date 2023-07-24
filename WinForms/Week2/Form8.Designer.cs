namespace Week2
{
    partial class Form8
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ckbSoon = new System.Windows.Forms.CheckBox();
            this.ckbSteak = new System.Windows.Forms.CheckBox();
            this.ckbPasta = new System.Windows.Forms.CheckBox();
            this.ckbTang = new System.Windows.Forms.CheckBox();
            this.lblOrder = new System.Windows.Forms.Label();
            this.btnEvent = new System.Windows.Forms.Button();
            this.SoonPrice = new System.Windows.Forms.Label();
            this.StakePrice = new System.Windows.Forms.Label();
            this.PastaPrice = new System.Windows.Forms.Label();
            this.TangPrice = new System.Windows.Forms.Label();
            this.ckbNudle = new System.Windows.Forms.CheckBox();
            this.ckbRice = new System.Windows.Forms.CheckBox();
            this.NudlePrice = new System.Windows.Forms.Label();
            this.RicePrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radoiDisagree = new System.Windows.Forms.RadioButton();
            this.radioAgree = new System.Windows.Forms.RadioButton();
            this.bthEnter = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.bthEnter2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReceipt = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.cbPay = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lbPayInfo = new System.Windows.Forms.ListBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(37, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "주문하세요";
            // 
            // ckbSoon
            // 
            this.ckbSoon.AutoSize = true;
            this.ckbSoon.Location = new System.Drawing.Point(42, 106);
            this.ckbSoon.Name = "ckbSoon";
            this.ckbSoon.Size = new System.Drawing.Size(60, 16);
            this.ckbSoon.TabIndex = 1;
            this.ckbSoon.Text = "순대국";
            this.ckbSoon.UseVisualStyleBackColor = true;
            // 
            // ckbSteak
            // 
            this.ckbSteak.AutoSize = true;
            this.ckbSteak.Location = new System.Drawing.Point(42, 160);
            this.ckbSteak.Name = "ckbSteak";
            this.ckbSteak.Size = new System.Drawing.Size(72, 16);
            this.ckbSteak.TabIndex = 2;
            this.ckbSteak.Text = "스테이크";
            this.ckbSteak.UseVisualStyleBackColor = true;
            // 
            // ckbPasta
            // 
            this.ckbPasta.AutoSize = true;
            this.ckbPasta.Location = new System.Drawing.Point(245, 106);
            this.ckbPasta.Name = "ckbPasta";
            this.ckbPasta.Size = new System.Drawing.Size(60, 16);
            this.ckbPasta.TabIndex = 3;
            this.ckbPasta.Text = "파스타";
            this.ckbPasta.UseVisualStyleBackColor = true;
            // 
            // ckbTang
            // 
            this.ckbTang.AutoSize = true;
            this.ckbTang.Location = new System.Drawing.Point(245, 160);
            this.ckbTang.Name = "ckbTang";
            this.ckbTang.Size = new System.Drawing.Size(60, 16);
            this.ckbTang.TabIndex = 4;
            this.ckbTang.Text = "탕수육";
            this.ckbTang.UseVisualStyleBackColor = true;
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Location = new System.Drawing.Point(15, 24);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(0, 12);
            this.lblOrder.TabIndex = 5;
            this.lblOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnEvent
            // 
            this.btnEvent.Location = new System.Drawing.Point(36, 272);
            this.btnEvent.Name = "btnEvent";
            this.btnEvent.Size = new System.Drawing.Size(111, 23);
            this.btnEvent.TabIndex = 7;
            this.btnEvent.Text = "주문";
            this.btnEvent.UseVisualStyleBackColor = true;
            this.btnEvent.Click += new System.EventHandler(this.btnEvent_Click);
            // 
            // SoonPrice
            // 
            this.SoonPrice.AutoSize = true;
            this.SoonPrice.Location = new System.Drawing.Point(108, 107);
            this.SoonPrice.Name = "SoonPrice";
            this.SoonPrice.Size = new System.Drawing.Size(29, 12);
            this.SoonPrice.TabIndex = 8;
            this.SoonPrice.Text = "7000";
            // 
            // StakePrice
            // 
            this.StakePrice.AutoSize = true;
            this.StakePrice.Location = new System.Drawing.Point(114, 161);
            this.StakePrice.Name = "StakePrice";
            this.StakePrice.Size = new System.Drawing.Size(29, 12);
            this.StakePrice.TabIndex = 9;
            this.StakePrice.Text = "9500";
            // 
            // PastaPrice
            // 
            this.PastaPrice.AutoSize = true;
            this.PastaPrice.Location = new System.Drawing.Point(311, 107);
            this.PastaPrice.Name = "PastaPrice";
            this.PastaPrice.Size = new System.Drawing.Size(29, 12);
            this.PastaPrice.TabIndex = 10;
            this.PastaPrice.Text = "7500";
            // 
            // TangPrice
            // 
            this.TangPrice.AutoSize = true;
            this.TangPrice.Location = new System.Drawing.Point(311, 161);
            this.TangPrice.Name = "TangPrice";
            this.TangPrice.Size = new System.Drawing.Size(35, 12);
            this.TangPrice.TabIndex = 11;
            this.TangPrice.Text = "10000";
            // 
            // ckbNudle
            // 
            this.ckbNudle.AutoSize = true;
            this.ckbNudle.Location = new System.Drawing.Point(42, 216);
            this.ckbNudle.Name = "ckbNudle";
            this.ckbNudle.Size = new System.Drawing.Size(48, 16);
            this.ckbNudle.TabIndex = 2;
            this.ckbNudle.Text = "누들";
            this.ckbNudle.UseVisualStyleBackColor = true;
            // 
            // ckbRice
            // 
            this.ckbRice.AutoSize = true;
            this.ckbRice.Location = new System.Drawing.Point(245, 216);
            this.ckbRice.Name = "ckbRice";
            this.ckbRice.Size = new System.Drawing.Size(60, 16);
            this.ckbRice.TabIndex = 4;
            this.ckbRice.Text = "볶음밥";
            this.ckbRice.UseVisualStyleBackColor = true;
            // 
            // NudlePrice
            // 
            this.NudlePrice.AutoSize = true;
            this.NudlePrice.Location = new System.Drawing.Point(96, 217);
            this.NudlePrice.Name = "NudlePrice";
            this.NudlePrice.Size = new System.Drawing.Size(29, 12);
            this.NudlePrice.TabIndex = 9;
            this.NudlePrice.Text = "6500";
            // 
            // RicePrice
            // 
            this.RicePrice.AutoSize = true;
            this.RicePrice.Location = new System.Drawing.Point(311, 217);
            this.RicePrice.Name = "RicePrice";
            this.RicePrice.Size = new System.Drawing.Size(29, 12);
            this.RicePrice.TabIndex = 11;
            this.RicePrice.Text = "1000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "\\";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "\\";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "\\";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(346, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "\\";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(346, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 12);
            this.label7.TabIndex = 16;
            this.label7.Text = "\\";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(346, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 12);
            this.label8.TabIndex = 17;
            this.label8.Text = "\\";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(257, 272);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 23);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 474);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 12);
            this.label9.TabIndex = 19;
            this.label9.Text = "주문 합계 액 : ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(116, 471);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(252, 21);
            this.textBox2.TabIndex = 21;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(394, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(352, 21);
            this.label10.TabIndex = 23;
            this.label10.Text = "이벤트에 응모할려면 개인정보를 동의해주세요.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radoiDisagree);
            this.groupBox1.Controls.Add(this.radioAgree);
            this.groupBox1.Location = new System.Drawing.Point(397, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 58);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "개인정보 동의";
            // 
            // radoiDisagree
            // 
            this.radoiDisagree.AutoSize = true;
            this.radoiDisagree.Location = new System.Drawing.Point(191, 24);
            this.radoiDisagree.Name = "radoiDisagree";
            this.radoiDisagree.Size = new System.Drawing.Size(59, 16);
            this.radoiDisagree.TabIndex = 1;
            this.radoiDisagree.TabStop = true;
            this.radoiDisagree.Text = "비동의";
            this.radoiDisagree.UseVisualStyleBackColor = true;
            // 
            // radioAgree
            // 
            this.radioAgree.AutoSize = true;
            this.radioAgree.Location = new System.Drawing.Point(33, 24);
            this.radioAgree.Name = "radioAgree";
            this.radioAgree.Size = new System.Drawing.Size(47, 16);
            this.radioAgree.TabIndex = 0;
            this.radioAgree.TabStop = true;
            this.radioAgree.Text = "동의";
            this.radioAgree.UseVisualStyleBackColor = true;
            // 
            // bthEnter
            // 
            this.bthEnter.Location = new System.Drawing.Point(696, 153);
            this.bthEnter.Name = "bthEnter";
            this.bthEnter.Size = new System.Drawing.Size(75, 23);
            this.bthEnter.TabIndex = 26;
            this.bthEnter.Text = "응모";
            this.bthEnter.UseVisualStyleBackColor = true;
            this.bthEnter.Click += new System.EventHandler(this.bthEnter_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(394, 208);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(196, 21);
            this.label11.TabIndex = 23;
            this.label11.Text = "회원가입에 동의해주세요.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Location = new System.Drawing.Point(394, 239);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 58);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "회원가입 동의";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(194, 25);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(59, 16);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "비동의";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(36, 22);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 16);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "동의";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // bthEnter2
            // 
            this.bthEnter2.Location = new System.Drawing.Point(699, 261);
            this.bthEnter2.Name = "bthEnter2";
            this.bthEnter2.Size = new System.Drawing.Size(75, 23);
            this.bthEnter2.TabIndex = 26;
            this.bthEnter2.Text = "응모";
            this.bthEnter2.UseVisualStyleBackColor = true;
            this.bthEnter2.Click += new System.EventHandler(this.bthEnter_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblOrder);
            this.groupBox3.Location = new System.Drawing.Point(36, 311);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(332, 147);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "주문결과";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(391, 349);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(299, 143);
            this.textBox1.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(391, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 21);
            this.label3.TabIndex = 29;
            this.label3.Text = "주문시 요구 사항";
            // 
            // btnReceipt
            // 
            this.btnReceipt.Location = new System.Drawing.Point(696, 349);
            this.btnReceipt.Name = "btnReceipt";
            this.btnReceipt.Size = new System.Drawing.Size(75, 143);
            this.btnReceipt.TabIndex = 30;
            this.btnReceipt.Text = "접수";
            this.btnReceipt.UseVisualStyleBackColor = true;
            this.btnReceipt.Click += new System.EventHandler(this.btnReceipt_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(34, 517);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 32;
            this.label12.Text = "결제방법";
            // 
            // cbPay
            // 
            this.cbPay.FormattingEnabled = true;
            this.cbPay.Items.AddRange(new object[] {
            "신용카드",
            "무통장입금",
            "포인트",
            "현금"});
            this.cbPay.Location = new System.Drawing.Point(36, 541);
            this.cbPay.Name = "cbPay";
            this.cbPay.Size = new System.Drawing.Size(111, 20);
            this.cbPay.TabIndex = 33;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(161, 517);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 34;
            this.label13.Text = "결제정보";
            // 
            // lbPayInfo
            // 
            this.lbPayInfo.FormattingEnabled = true;
            this.lbPayInfo.ItemHeight = 12;
            this.lbPayInfo.Items.AddRange(new object[] {
            "일시불",
            "3개월 할부",
            "6개월 할부",
            "10년 할부"});
            this.lbPayInfo.Location = new System.Drawing.Point(163, 541);
            this.lbPayInfo.Name = "lbPayInfo";
            this.lbPayInfo.Size = new System.Drawing.Size(120, 88);
            this.lbPayInfo.TabIndex = 35;
            this.lbPayInfo.SelectedIndexChanged += new System.EventHandler(this.lbPayInfo_SelectedIndexChanged);
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(293, 538);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(75, 23);
            this.btnPay.TabIndex = 36;
            this.btnPay.Text = "결제";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 657);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.lbPayInfo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cbPay);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnReceipt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.bthEnter2);
            this.Controls.Add(this.bthEnter);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RicePrice);
            this.Controls.Add(this.TangPrice);
            this.Controls.Add(this.PastaPrice);
            this.Controls.Add(this.NudlePrice);
            this.Controls.Add(this.StakePrice);
            this.Controls.Add(this.SoonPrice);
            this.Controls.Add(this.btnEvent);
            this.Controls.Add(this.ckbRice);
            this.Controls.Add(this.ckbTang);
            this.Controls.Add(this.ckbNudle);
            this.Controls.Add(this.ckbPasta);
            this.Controls.Add(this.ckbSteak);
            this.Controls.Add(this.ckbSoon);
            this.Controls.Add(this.label1);
            this.Name = "Form8";
            this.Text = "Form8";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckbSoon;
        private System.Windows.Forms.CheckBox ckbSteak;
        private System.Windows.Forms.CheckBox ckbPasta;
        private System.Windows.Forms.CheckBox ckbTang;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Button btnEvent;
        private System.Windows.Forms.Label SoonPrice;
        private System.Windows.Forms.Label StakePrice;
        private System.Windows.Forms.Label PastaPrice;
        private System.Windows.Forms.Label TangPrice;
        private System.Windows.Forms.CheckBox ckbNudle;
        private System.Windows.Forms.CheckBox ckbRice;
        private System.Windows.Forms.Label NudlePrice;
        private System.Windows.Forms.Label RicePrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radoiDisagree;
        private System.Windows.Forms.RadioButton radioAgree;
        private System.Windows.Forms.Button bthEnter;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button bthEnter2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReceipt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbPay;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox lbPayInfo;
        private System.Windows.Forms.Button btnPay;
    }
}