using prjMember.AllClass;
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
            labregister.Text = "登出";
            Login login = new Login();
            login.ShowDialog();
            
        }

        private void labregister_MouseMove(object sender, MouseEventArgs e)
        {
            //labregister.ForeColor = Color.IndianRed;
        }

        private void labregister_MouseEnter(object sender, EventArgs e)
        {
            labregister.ForeColor = Color.IndianRed;


        }

        private void labregister_MouseLeave(object sender, EventArgs e)
        {
            labregister.ForeColor = Color.CornflowerBlue;
            /* labregister.Size = new Size(14,14); */              /*  看怎麼改*/
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
          
            if(comchoice.Text == "會員資料")                           //下拉選單
            {
                comchoice.Text = null;
                
                if (UserData.Member == null)                      //判斷有沒有登入會員資料
                {
                    MessageBox.Show("請先登入會員");
                    return;
                }
                Member material = new Member();
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
                MemberUpdate update = new MemberUpdate();
                update.Show();

            }

        }

        private void comchoice_DropDown(object sender, EventArgs e)
        {
            comchoice.Text = null;                                //下拉式選單觸發時字會不見
        }
    } }

