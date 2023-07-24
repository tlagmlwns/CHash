using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Week2
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            string strOrder = "";
            lblOrder.Text = "";
            if (ckbSoon.Checked == true) { strOrder += ckbSoon.Text + "\n"; }
            if(ckbPasta.Checked == true) { strOrder += ckbPasta.Text + "\n"; }
            if (ckbSteak.Checked == true) { strOrder += ckbSteak.Text + "\n"; }
            if (ckbTang.Checked == true) { strOrder += ckbTang.Text + "\n"; }
            if (ckbNudle.Checked == true) { strOrder += ckbNudle.Text + "\n"; }
            if (ckbRice.Checked == true) { strOrder += ckbRice.Text + "\n"; }
            lblOrder.Text = strOrder +"메뉴를 요청하였습니다.";

            int intPrice = 0;
            
            textBox2.Text = "";
            if (ckbSoon.Checked == true)
            {
                if (ckbSoon.Checked == false) { intPrice = 0; }
                { intPrice += int.Parse(SoonPrice.Text); }
            }
            if (ckbPasta.Checked == true)
            {
                if (ckbPasta.Checked == false) { intPrice = 0; }
                { intPrice += int.Parse(PastaPrice.Text); }
            }
            if (ckbSteak.Checked == true)
            {
                if (ckbSteak.Checked == false) { intPrice = 0; }
                { intPrice += int.Parse(StakePrice.Text); }
            }
            if (ckbTang.Checked == true)
            {
                if ((ckbTang.Checked == false)) { intPrice = 0; }
                { intPrice += int.Parse(TangPrice.Text); }
            }
            if (ckbNudle.Checked == true)
            {
                if (ckbNudle.Checked == false) { intPrice = 0; }
                { intPrice += int.Parse(NudlePrice.Text); }
            }
            if (ckbRice.Checked == true)
            {
                if (ckbRice.Checked == false) { intPrice = 0; }
                { intPrice += int.Parse(RicePrice.Text); }
            }
            textBox2.Text = intPrice+"원 입니다.";
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (ckbSoon.Checked == true) { ckbSoon.Checked = false; }
            if (ckbPasta.Checked == true) { ckbPasta.Checked = false; }
            if (ckbSteak.Checked == true) { ckbSteak.Checked = false; }
            if (ckbTang.Checked == true) { ckbTang.Checked = false; }
            if(ckbNudle.Checked == true) { ckbNudle.Checked = false; }
            if(ckbRice.Checked == true) { ckbRice.Checked = false; }
            lblOrder.Text = null;
            textBox2.Text = null;
        }

        private void bthEnter_Click(object sender, EventArgs e)
        {
            if (radioAgree.Checked == true) MessageBox.Show("개인정보에 동의하셨습니다.");
            else MessageBox.Show("개인정보에 동의하지 않으셨습니다.");
        }
        private void bthEnter2_Click(object sender, EventArgs e)
        {
            if (radioAgree.Checked == true) MessageBox.Show("회원가입에 동의하셨습니다.");
            else MessageBox.Show("회원가입에 동의하지 않으셨습니다.");
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            string strText = textBox1.Text + "\n라고 요구사항이 접수됨";
            MessageBox.Show(strText);
        }

        private void lbPayInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbPayInfo.Items.Clear();
            if(lbPayInfo.SelectedIndex == 0)
            {
                lbPayInfo.Items.Add("일시불");
                lbPayInfo.Items.Add("3개월 할부");
                lbPayInfo.Items.Add("6개월 할부");
                lbPayInfo.Items.Add("20년 할부");
            }
            else if (lbPayInfo.SelectedIndex == 1)
            {
                lbPayInfo.Items.Add("K 은행");
                lbPayInfo.Items.Add("N 은행");
                lbPayInfo.Items.Add("S 은행");
                lbPayInfo.Items.Add("산와머니");
            }
            else if(lbPayInfo.SelectedIndex == 2)
            {
                lbPayInfo.Items.Add("N 포인트");
                lbPayInfo.Items.Add("파워포인트");
                lbPayInfo.Items.Add("해피포인트");
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if(cbPay.Text == "" || lbPayInfo.Text == "")
            {
                MessageBox.Show("결제 방법 및 정보 다시 확인ㄱㄱ");
                return;
            }
            string str = cbPay.Text + "(으)로 " + lbPayInfo.Text + "결제방법을"
                + "\n선택하였습니다.";
            MessageBox.Show(str);
        }
    }
}
