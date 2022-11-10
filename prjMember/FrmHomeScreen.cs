﻿using prjMember.AllClass;
using prjMember.NewFolder1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace prjMember
{
    public partial class FrmHomeScreen : Form
    {
        public FrmHomeScreen()
        {
            InitializeComponent();

        }

        private void register_Click(object sender, EventArgs e)
        {

            if (labregister.Text == "登出")
            {
                var result = MessageBox.Show("確定登出?", "感謝您的光臨",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Exclamation);

                if (result == DialogResult.Yes)
                {
                    UserData.Member = null;
                    labregister.Text = "登入";
                    panel2.Controls.Clear();                                        //登出後panel畫面消失
                    membername.Text = null;
                    return;
                }
                else { return; };

            }
            labregister.Text = "登出";
            Login login = new Login();
            //panel2.Controls.Clear();
            //login.TopLevel = false;
            //login.Parent = panel2;
            login.ShowDialog();
            membername.Text = login.membername;   //顯示會員名子
            labregister.Text = login.homeloginstate;

        }


        private void labregister_MouseEnter(object sender, EventArgs e)
        {
            labregister.ForeColor = Color.IndianRed;


        }

        private void labregister_MouseLeave(object sender, EventArgs e)
        {
            labregister.ForeColor = Color.CornflowerBlue;

        }

        private void Notice_MouseEnter(object sender, EventArgs e)
        {
            labNotice.ForeColor = Color.IndianRed;

        }

        private void labNotice_MouseLeave(object sender, EventArgs e)
        {
            labNotice.ForeColor = Color.CornflowerBlue;
        }



        private void comchoice_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comchoice.Text == "會員資料")                           //下拉選單
            {
                comchoice.Text = null;

                if (UserData.Member == null)                      //判斷有沒有登入會員資料
                {
                    MessageBox.Show("請先登入會員");
                    return;
                }
                Member material = new Member();

                //panel2.Controls.Clear();
                //material.TopLevel = false;
                //material.Parent = panel2;
                material.Show();
                comchoice.Text = "會員中心";
            }
            if (comchoice.Text == "修改會員資料")                   //判斷有沒有登入會員資料     
            {
                if (UserData.Member == null)                      //判斷有沒有登入會員資料
                {
                    MessageBox.Show("請先登入會員");
                    return;
                }

                comchoice.Text = null;
                //panel2.Controls.Clear();
                MemberUpdate update = new MemberUpdate();
                //update.TopLevel = false;
                //update.Parent = panel2;

                update.Show();

            }

        }

        private void comchoice_DropDown(object sender, EventArgs e)
        {
            comchoice.Text = null;                                //下拉式選單觸發時字會不見
        }

        private void labshop_MouseEnter(object sender, EventArgs e)
        {
            labshop.ForeColor = Color.IndianRed;
        }

        private void labshop_MouseLeave(object sender, EventArgs e)
        {
            labshop.ForeColor = Color.Black;
        }

        private void labshopcar_MouseEnter(object sender, EventArgs e)
        {
            labshopcar.ForeColor = Color.IndianRed;

        }

        private void labshopcar_MouseLeave(object sender, EventArgs e)
        {
            labshopcar.ForeColor = Color.Black;
        }

        private void laborder_MouseEnter(object sender, EventArgs e)
        {
            laborder.ForeColor = Color.IndianRed;
        }

        private void laborder_MouseLeave(object sender, EventArgs e)
        {
            laborder.ForeColor=Color.Black;
        }
    }

}














