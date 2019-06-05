using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ListBox
{
    public partial class Form1 : Form
    {
        string OrgStr = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.OrgStr = this.lblResult.Text;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddList();
        }

        private void AddList()
        {
            if (TextCheck())
            {
                this.lbView.Items.Add(this.txtList.Text);
                this.txtList.Focus();
                this.txtList.Text = "";
            }
        }

        private bool TextCheck()
        {
           if(this.txtList.Text == "")
            {
                MessageBox.Show("항목을 입력해주세요",
                    "알림",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                this.txtList.Focus();
                return false;
            }
            return true;
        }

        private void LbView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lblResult.Text = 
                this.OrgStr + this.lbView.Text;
        }

        private void TxtList_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                AddList();
            }
        }
    }
}
