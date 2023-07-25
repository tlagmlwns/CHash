using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Week2
{
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || tbPhone.Text == "" || tbOrg.Text == "") 
                MessageBox.Show("작성안한부분 현존 다쓰시오.");
            else
            {
                listView1.Items.Add
                    (new ListViewItem(new string[] { tbName.Text, tbPhone.Text, tbOrg.Text }));
                tbName.Clear();
                tbPhone.Clear();
                tbOrg.Clear();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int index = listView1.FocusedItem.Index;
                listView1.Items.RemoveAt(index);
            }catch(Exception exp) { MessageBox.Show("리스트 항목 다시 보시오"); }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || tbPhone.Text == "" || tbOrg.Text == "") 
            {MessageBox.Show("작성안한부분 현존 다쓰시오."); return; }
            try {
                listView1.SelectedItems[0].SubItems[0].Text = tbName.Text;
                listView1.SelectedItems[0].SubItems[1].Text = tbPhone.Text;
                listView1.SelectedItems[0].SubItems[2].Text = tbOrg.Text;
            }catch (Exception exp) { MessageBox.Show("리스트 항목 다시 보시오"); }
            finally { tbName.Clear(); tbPhone.Clear(); tbOrg.Clear(); }

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || tbPhone.Text == "" || tbOrg.Text == "")
            { MessageBox.Show("작성안한부분 현존 다쓰시오."); return; }
            try {
                int index = listView1.FocusedItem.Index;
                listView1.Items.Insert
                    (index, new ListViewItem(new string[] { tbName.Text, tbPhone.Text, tbOrg.Text }));
            } catch (Exception exp) { MessageBox.Show("리스트 항목 다시 보시오"); }
            finally { tbName.Clear(); tbPhone.Clear(); tbOrg.Clear(); }
        }
    }
}
