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
        ModalessForm modaless = null; //확률공개표 모달리스대화상자
        How2play how2Play = null; //사용설명서 모달리스대화상자
        HRcard1 hrcard1 = null; //HRcard의 1번카드 모달리스대화상자
        HRcard2 hrcard2 = null; //HRcard의 2번카드 모달리스대화상자
        HRcard3 hrcard3 = null; //HRcard의 3번카드 모달리스대화상자
        HRcard4 hrcard4 = null; //HRcard의 4번카드 모달리스대화상자
        HRcard5 hrcard5 = null; //HRcard의 5번카드 모달리스대화상자
        static public int HRCardNum;
        class Card //카드
        {
            public string cName; //카드이름
            public string cValue; //카드팩수
            public string cPrice; //카드값
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

        public void cdMhz_CheckedChanged(object sender, EventArgs e) //카드1 선택시
        {
            Card Mhz = new Card(cdMhz.Text, tbMhzP.Text,mhzlbPrice.Text);
            if (cdMhz.Checked == true) 
            {
                int MhzPrice = int.Parse(Mhz.cValue) * int.Parse(Mhz.cPrice);
                strOrder += Mhz.cName + ", " + Mhz.cValue + ", "+MhzPrice+"원,"; tbOrder.Text = strOrder; 
            }
            tbMhzP.Text = " "; cdMhz.Checked = false; hScrollBar1.Value = 0; Mhz.cValue = null; Mhz.cPrice = null;

        }

        private void cdPr_CheckedChanged(object sender, EventArgs e) //카드2 선택시
        {
            Card Pr = new Card(cdPr.Text, tbPrP.Text, PrlbPrice.Text);
            if (cdPr.Checked == true)
            {
                int PrPrice = int.Parse(Pr.cValue) * int.Parse(Pr.cPrice);
                strOrder +=  Pr.cName + ", " + Pr.cValue + ", " + PrPrice + "원,"; tbOrder.Text = strOrder;
            }
            tbPrP.Text = " "; cdPr.Checked = false; hScrollBar2.Value = 0; Pr.cValue = null; Pr.cPrice = null;

        }

        private void cdSs_CheckedChanged(object sender, EventArgs e) //카드3 선택시
        {
            Card Ss = new Card(cdSs.Text, tbSsP.Text, SslbPrice.Text);
            if (cdSs.Checked == true)
            {
                int SsPrice = int.Parse(Ss.cValue) * int.Parse(Ss.cPrice);
                strOrder +=  Ss.cName + ", " + Ss.cValue + ", " + SsPrice + "원,"; tbOrder.Text = strOrder;
            }
            tbSsP.Text = " "; cdSs.Checked = false; hScrollBar3.Value = 0; Ss.cValue = null; Ss.cPrice = null;

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e) //카드1 스크롤로 카드팩 수 변동
        {
            tbMhzP.Text = hScrollBar1.Value.ToString();
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e) //카드2 스크롤로 카드팩 수 변동
        {
            tbPrP.Text = hScrollBar2.Value.ToString();
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e) //카드3 스크롤로 카드팩 수 변동
        {
            tbSsP.Text = hScrollBar3.Value.ToString();
        }

        private void btn_Buy_Click(object sender, EventArgs e) //구매버튼
        {
            if (tbOrder.Text == "") 
            { MessageBox.Show("상품을 넣으세요."," 알림", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (cbPay.Text == "" || lbPayInfo.Text == "")
            { MessageBox.Show("결제방법을 선택하세요", " 경고", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            string str = cbPay.Text + "(으)로 " + lbPayInfo.Text + " 결제방법을 " + "\n선택하셨습니다.";
            MessageBox.Show(str, " 알림");

            int i, j, k;
            string[] splitData = tbOrder.Text.Split(',');
            for (i = 0; i < splitData.Length - 1; i += 3)  //카드제목 넣기
            {
                //if (splitData[a] == " ") break;
                ListViewItem item = new ListViewItem(splitData[i]); //첫 번째 요소0를 항목으로 추가
                item.SubItems.Add(splitData[i+1]); //팩 수를 서브1 항목으로 추가
                item.SubItems.Add(splitData[i+2]); //가격들을 서브2 항목으로 추가
                listView2.Items.Add(item); // ListView에 항목 추가
            }
            
            tbOrder.Text = " "; strOrder = " "; //항목추가되면 그 전꺼 초기화
            tbMhzP.Text = " "; cdMhz.Checked = false; hScrollBar1.Value = 0;
            tbPrP.Text = " "; cdPr.Checked = false; hScrollBar2.Value = 0;
            tbSsP.Text = " "; cdSs.Checked = false; hScrollBar3.Value = 0;
            cbPay.SelectedIndex = 0;
            lbPayInfo.Items.Clear();
            tbOrder.Clear();
        }

        private void btn_Cannel_Click(object sender, EventArgs e) //취소버튼(초기화)
        {
            tbOrder.Text = " "; strOrder = " "; //장바구니 초기화
            tbMhzP.Text = " "; cdMhz.Checked = false; hScrollBar1.Value = 0; //카드1초기화
            tbPrP.Text = " "; cdPr.Checked = false; hScrollBar2.Value = 0;  //카드2초기화
            tbSsP.Text = " "; cdSs.Checked = false; hScrollBar3.Value = 0; //카드3초기화
            cbPay.SelectedIndex = 0; //결제방법 초기화
            lbPayInfo.Items.Clear(); //결제정보 초기화

        }

        private void cbPay_SelectedIndexChanged(object sender, EventArgs e) //결제방법
        {
            lbPayInfo.Items.Clear();
            if(cbPay.SelectedIndex == 0)
            { lbPayInfo.Items.Add("일시불"); lbPayInfo.Items.Add("3개월 할부"); lbPayInfo.Items.Add("6개월 할부"); }
            if (cbPay.SelectedIndex == 1)
            { lbPayInfo.Items.Add("K은행"); lbPayInfo.Items.Add("N은행"); lbPayInfo.Items.Add("S은행"); }
            if (cbPay.SelectedIndex == 2)
            { lbPayInfo.Items.Add("N포인트"); lbPayInfo.Items.Add("해피포인트"); lbPayInfo.Items.Add("주유포인트"); }
        }

        private void btnOpenCard_Click(object sender, EventArgs e) //카드뽑기
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
                        int x = rand.Next(1, 25); //(1, 10000);
                        if (x <= 5)
                        {   MessageBox.Show("축하합니다. HR - 하이퍼레어", " 카드 결과"); //HR 카드만 이미지카드 올려줌
                            
                            if (x == 1)      { if (hrcard1 == null) { hrcard1 = new HRcard1(); hrcard1.Show(); } } 
                            else if (x == 2) { if (hrcard2 == null) { hrcard2 = new HRcard2(); hrcard2.Show(); } }
                            else if (x == 3) { if (hrcard3 == null) { hrcard3 = new HRcard3(); hrcard3.Show(); } }
                            else if (x == 4) { if (hrcard4 == null) { hrcard4 = new HRcard4(); hrcard4.Show(); } }
                            else if (x == 5) { if (hrcard5 == null) { hrcard5 = new HRcard5(); hrcard5.Show(); } }
                            HR_time++; }
                        
                        else if (x <= 50)   { MessageBox.Show("축하합니다. SR - 슈퍼레어", " 카드 결과"); SR_time++; } //50
                        else if (x <= 500)  { MessageBox.Show("축하합니다. RRR - 트리플레어", " 카드 결과"); RRR_time++; }//500
                        else if (x <= 1000) { MessageBox.Show("축하합니다. RR - 더블레어", " 카드 결과"); }//1000
                        else if (x <= 2000) { MessageBox.Show("R - 레어", "카드 결과"); }//2000
                        else if (x <= 4000) { MessageBox.Show("U - 언커먼", "카드 결과"); }//4000
                        else if (x <= 9999) { MessageBox.Show("C - 커먼", "카드 결과"); }//9999
                        else { MessageBox.Show(" 카드가 없습니다."," 알림");  }
                    }
                    tb_message.Text = ($"- 결과 : 총 {pack*5}장 중\n" +
                        $" HR : {HR_time}장, SR : {SR_time}장, RRR : {RRR_time}장 입니다.\n"); //결과출력 나머지등급은 안셈
                    listView2.Items.Clear();

                }
                else MessageBox.Show("취소되었습니다."," 알림");
            }

        }
        
        private void btnLook_Click(object sender, EventArgs e) //확률공개
        {if(modaless == null) {  modaless = new ModalessForm(); modaless.Show(); }}

        private void btnQA_Click(object sender, EventArgs e) //오류신고
        {MessageBox.Show("이메일 문의 : simh4jun@gmail.com", " 알림", MessageBoxButtons.OK, MessageBoxIcon.Information);}

        private void btnHow2play_Click(object sender, EventArgs e) //사용설명서
        {if (how2Play == null) { how2Play = new How2play(); how2Play.Show(); }}
    }
}