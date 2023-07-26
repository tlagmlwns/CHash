using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kiosk
{
    public partial class Form1 : Form
    {

        class Card
        {
            public string cName;
            public string cValue;
            public string cPrice;
            public Card(string cName, string cValue, string cPrice)
            {
                this.cName = cName;
                this.cValue = cValue;
                this.cPrice = cPrice;
            }
        }
        public Form1()
        {
            InitializeComponent();
            listView2.View = View.Details;
        }
        string strOrder = "";
        

        //int MhzPrice = 0, PrPrice = 0, SsPrice = 0;

        public void cdMhz_CheckedChanged(object sender, EventArgs e)
        {
            Card Mhz = new Card(cdMhz.Text, tbMhzP.Text,mhzlbPrice.Text);
            if (cdMhz.Checked == true) 
            {
                int MhzPrice = int.Parse(Mhz.cValue) * int.Parse(Mhz.cPrice);
                strOrder += Mhz.cName + ", " + Mhz.cValue + ", "+MhzPrice+"원,"; tbOrder.Text = strOrder; 
                //listView2.Items.Add(new ListViewItem(new string[] { Mhz.cName, Mhz.cValue, }));
            }
            tbMhzP.Text = " "; cdMhz.Checked = false; hScrollBar1.Value = 0;

        }

        private void cdPr_CheckedChanged(object sender, EventArgs e)
        {
            Card Pr = new Card(cdPr.Text, tbPrP.Text, PrlbPrice.Text);
            if (cdPr.Checked == true)
            {
                int PrPrice = int.Parse(Pr.cValue) * int.Parse(Pr.cPrice);
                strOrder += Pr.cName + ", " + Pr.cValue + ", " + PrPrice + "원,"; tbOrder.Text = strOrder;
            }
            tbPrP.Text = " "; cdPr.Checked = false; hScrollBar1.Value = 0;

        }

        private void cdSs_CheckedChanged(object sender, EventArgs e)
        {
            Card Ss = new Card(cdSs.Text, tbSsP.Text, SslbPrice.Text);
            if (cdSs.Checked == true)
            {
                int SsPrice = int.Parse(Ss.cValue) * int.Parse(Ss.cPrice);
                strOrder += Ss.cName + ", " + Ss.cValue + ", " + SsPrice + "원,"; tbOrder.Text = strOrder;
            }
            tbSsP.Text = " "; cdSs.Checked = false; hScrollBar1.Value = 0;

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e) 
        {
            tbMhzP.Text = hScrollBar1.Value.ToString();
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            tbPrP.Text = hScrollBar2.Value.ToString();
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            tbSsP.Text = hScrollBar3.Value.ToString();
        }

        private void btn_Buy_Click(object sender, EventArgs e)
        {
            if (tbOrder.Text == "") 
            { MessageBox.Show("상품을 넣으세요.");
                if (cbPay.Text == "" || lbPayInfo.Text == "")
                    { MessageBox.Show("결제방법을 선택하세요"); return; } return; }
            string str = cbPay.Text + "(으)로 " + lbPayInfo.Text + " 결제방법을 " + "\n선택하셨습니다. ";
            MessageBox.Show(str);
            // Split으로 문자열을 나누어 배열로 변환
            string[] splitData = tbOrder.Text.Split(',');

            // ListView에 항목과 서브 항목 추가
            ListViewItem item = new ListViewItem(splitData[0]); // 첫 번째 요소를 항목으로 추가

            // 나머지 요소들을 서브 항목으로 추가
            for (int i = 1; i < splitData.Length; i++) {item.SubItems.Add(splitData[i]);}
            
            // ListView에 항목 추가
            listView2.Items.Add(item);
          
            // 입력란 비우기
            tbOrder.Clear();
        }

        private void btn_Cannel_Click(object sender, EventArgs e)
        {
            tbOrder.Text = " "; strOrder = " ";
            tbMhzP.Text = " "; cdMhz.Checked = false; hScrollBar1.Value = 0;
            tbPrP.Text = " "; cdPr.Checked = false; hScrollBar2.Value = 0;
            tbSsP.Text = " "; cdSs.Checked = false; hScrollBar3.Value = 0;

        }

        private void cbPay_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbPayInfo.Items.Clear();
            if(cbPay.SelectedIndex == 0)
            { lbPayInfo.Items.Add("일시불"); lbPayInfo.Items.Add("3개월 할부"); lbPayInfo.Items.Add("6개월 할부"); }
            if (cbPay.SelectedIndex == 1)
            { lbPayInfo.Items.Add("K은행"); lbPayInfo.Items.Add("N은행"); lbPayInfo.Items.Add("S은행"); }
            if (cbPay.SelectedIndex == 2)
            { lbPayInfo.Items.Add("N포인트"); lbPayInfo.Items.Add("해피포인트"); lbPayInfo.Items.Add("주유포인트"); }
        }

        private void btnOpenCard_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int time = 0;
            if (listView2.Items != null) 
            {
                foreach (ListViewItem item in listView2.Items){string secondColumnValue = item.SubItems[1].Text; time = int.Parse(item.SubItems[1].Text); }
                for (int i = 0; i < time; i++)
                {
                    int x = rand.Next(1, 10000);
                    if (x < 50) { MessageBox.Show("축하합니다. S"); tb_message.Text += "축하합니다 S를 뽑으셨습니다."; }
                    else if (x < 500) { MessageBox.Show("축하합니다. A"); tb_message.Text += "축하합니다 A를 뽑으셨습니다."; }
                    else if (x < 1000) { MessageBox.Show("축하합니다. B"); }
                    else if (x < 2000) { MessageBox.Show("C"); }
                    else if (x < 4000) { MessageBox.Show("D"); }
                    else if (x < 9999) { MessageBox.Show("F"); }
                    else
                    {
                        MessageBox.Show("카드가 없습니다.");
                        listView2.Clear();
                    }
                }
                listView2.Clear();
                tb_message.Clear();
            }
        }
    }
}