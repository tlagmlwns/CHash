using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
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
        ModalessForm modaless = null;
        HRcard1 hrcard1 = null;
        HRcard2 hrcard2 = null;
        HRcard3 hrcard3 = null;
        HRcard4 hrcard4 = null;
        HRcard5 hrcard5 = null;
        static public int HRCardNum;
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
            tbPrP.Text = " "; cdPr.Checked = false; hScrollBar2.Value = 0;

        }

        private void cdSs_CheckedChanged(object sender, EventArgs e)
        {
            Card Ss = new Card(cdSs.Text, tbSsP.Text, SslbPrice.Text);
            if (cdSs.Checked == true)
            {
                int SsPrice = int.Parse(Ss.cValue) * int.Parse(Ss.cPrice);
                strOrder += Ss.cName + ", " + Ss.cValue + ", " + SsPrice + "원,"; tbOrder.Text = strOrder;
            }
            tbSsP.Text = " "; cdSs.Checked = false; hScrollBar3.Value = 0;

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
            {   MessageBox.Show("상품을 넣으세요."," 알림", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (cbPay.Text == "" || lbPayInfo.Text == "")
            { MessageBox.Show("결제방법을 선택하세요", " 경고", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            string str = cbPay.Text + "(으)로 " + lbPayInfo.Text + " 결제방법을 " + "\n선택하셨습니다. ";
            MessageBox.Show(str, " 알림");
        
            string[] splitData = tbOrder.Text.Split(',');

            ListViewItem item = new ListViewItem(splitData[0]); // 첫 번째 요소를 항목으로 추가

            // 나머지 요소들을 서브 항목으로 추가
            for (int i = 1; i < splitData.Length; i++) {item.SubItems.Add(splitData[i]);}
            
            // ListView에 항목 추가
            listView2.Items.Add(item);
            tbOrder.Text = " "; strOrder = " ";
            tbMhzP.Text = " "; cdMhz.Checked = false; hScrollBar1.Value = 0;
            tbPrP.Text = " "; cdPr.Checked = false; hScrollBar2.Value = 0;
            tbSsP.Text = " "; cdSs.Checked = false; hScrollBar3.Value = 0;
            cbPay.SelectedIndex = 0;
            lbPayInfo.Items.Clear();
            tbOrder.Clear();
        }

        private void btn_Cannel_Click(object sender, EventArgs e)
        {
            tbOrder.Text = " "; strOrder = " ";
            tbMhzP.Text = " "; cdMhz.Checked = false; hScrollBar1.Value = 0;
            tbPrP.Text = " "; cdPr.Checked = false; hScrollBar2.Value = 0; 
            tbSsP.Text = " "; cdSs.Checked = false; hScrollBar3.Value = 0;
            cbPay.SelectedIndex = 0;
            lbPayInfo.Items.Clear();

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
            tb_message.Clear();
            Random rand = new Random();
            int pack = 0, HR_time = 0, SR_time = 0, RRR_time = 0;
            if (listView2.Items != null)
            {
                if (MessageBox.Show("카드를 오픈하시겠습니까?", " 알림", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show("구매하신 카드를 까는 중 입니다.", " 카드 오픈하기", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    foreach (ListViewItem item in listView2.Items) { string secondColumnValue = item.SubItems[1].Text; pack = int.Parse(item.SubItems[1].Text); }
                    for (int i = 1; i < pack * 5+1; i++) //1팩당 5장
                    {
                        int x = rand.Next(1, 6); //(1, 10000);
                        if (x <= 5)
                        {   MessageBox.Show("축하합니다. HR - 하이퍼레어", " 카드 결과");
                            
                            if (x == 1) { if (hrcard1 == null) { hrcard1 = new HRcard1(); hrcard1.Show(); } } 
                            else if (x == 2) { if (hrcard2 == null) { hrcard2 = new HRcard2(); hrcard2.Show(); } }
                            else if (x == 3) { if (hrcard3 == null) { hrcard3 = new HRcard3(); hrcard3.Show(); } }
                            else if (x == 4) { if (hrcard4 == null) { hrcard4 = new HRcard4(); hrcard4.Show(); } }
                            else if (x == 5) { if (hrcard5 == null) { hrcard5 = new HRcard5(); hrcard5.Show(); } }
                            HR_time++; }
                        
                        else if (x <= 50) { MessageBox.Show("축하합니다. SR - 슈퍼레어", " 카드 결과"); SR_time++; }
                        else if (x <= 500) { MessageBox.Show("축하합니다. RRR - 트리플레어", " 카드 결과"); RRR_time++; }
                        else if (x <= 1000) { MessageBox.Show("축하합니다. RR - 더블레어", " 카드 결과"); }
                        else if (x <= 2000) { MessageBox.Show("R - 레어", "카드 결과"); }
                        else if (x <= 4000) { MessageBox.Show("U - 언커먼", "카드 결과"); }
                        else if (x <= 9999) { MessageBox.Show("C - 커먼", "카드 결과"); }
                        else { MessageBox.Show(" 카드가 없습니다."," 알림");  }
                    }
                    tb_message.Text = ($"- 결과 : 총 {pack*5}장 중\n HR : {HR_time}장, SR : {SR_time}장, RRR : {RRR_time}장 입니다.\n");
                    listView2.Items.Clear();

                }
                else MessageBox.Show("취소되었습니다."," 알림");
            }

        }
        
        private void btnLook_Click(object sender, EventArgs e)
        {
            if(modaless == null) {  modaless = new ModalessForm(); modaless.Show(); }
        }

        private void btnQA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("이메일 문의 : simh4jun@gmail.com", " 알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}