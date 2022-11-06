using prjMember.AllClass;
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
                    return;                                     //為了一個登入登出變換想好久
                }
                else { return; };

            }
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

            if (comchoice.Text == "會員資料")                           //下拉選單
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


    }
}
















