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
using OrderList;
using WindowsFormsControlLibrary1;
using FM_Cart;
using 訂餐平台;

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
                     flowLayoutPanel1.Controls.Clear();                                        //登出後panel畫面消失
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
            //labregister.Text = login.homeloginstate;

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

                flowLayoutPanel1.Controls.Clear();
                material.TopLevel = false;
                material.Parent = flowLayoutPanel1;
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
            laborder.ForeColor = Color.Black;
        }

        private void laborder_Click(object sender, EventArgs e)
        {
            if (UserData.Member == null)                      //判斷有沒有登入會員資料
            {
                MessageBox.Show("請先登入會員");
                return;
            }
            FrmPage page = new FrmPage(UserData.Member.fid);     //設會員參數傳值
            page.TopLevel = false;
            page.Parent = flowLayoutPanel1;
            page.Show();
            //iSpan_ProjectEntities db = new iSpan_ProjectEntities();
            //int Screenblockside = this.ClientSize.Width / 8;
            //flowLayoutPanel1.Width = 6 * Screenblockside;
            //flowLayoutPanel1.Location = new Point(Screenblockside, 50);

            //UserElement();




            //Label scroll = new Label();
            //scroll.Text = "";
            //scroll.BackColor = Color.Transparent;
            //scroll.Location = new Point(0, 30);
            //scroll.AutoSize = false;
            //scroll.Size = new Size(1, flowLayoutPanel1.Size.Height);
            //this.Controls.Add(scroll);

            //void UserElement()
            //{
            //    List<FUserList> ULS = new List<FUserList>();

            //    var q = from emp in db.Orders
            //            join g in db.BusinessMember
            //            on emp.B_fid equals g.fid
            //            where emp.N_fid == 1
            //            select new
            //            {
            //                emp.OrderState,
            //                emp.OrderTime,
            //                emp.TotalAmount,
            //                g.MemberName,

            //            };

            //    foreach (var item in q)
            //    {

            //        ULS.Add(new FUserList
            //        {
            //            FMemberName = item.MemberName,
            //            FOrderState = item.OrderState,
            //            FOrderTime = item.OrderTime.ToString(),
            //            FTotalAmount = item.TotalAmount.ToString(),

            //        });

            //    }

            //    Utility use = new Utility();
            //    use.ULS = ULS;

            //    int EmtCount = use.ULS.Count;

            //    Element[] Emt = new Element[EmtCount];

            //    for (int i = 0; i < Emt.Length; i++)
            //    {

            //        int num = i;

            //        Emt[i] = new Element
            //        {
            //            theTextlabName = use.ULS[i].FMemberName,
            //            theTextlabState = use.ULS[i].FOrderState,
            //            theTextlabProduct = use.ULS[i].FQty + $"項商品",
            //            theTextlabCount = $"共" + use.ULS[i].FTotalAmount + $"元",
            //            theTextlabTime = use.ULS[i].FOrderTime,

            //        };

            //        if (Emt[i].theTextlabState == "未接單")
            //        {
            //            Emt[i].theBackColor = Color.Red;

            //        }
            //        else if (Emt[i].theTextlabState == "商品準備中")
            //        {
            //            Emt[i].theBackColor = Color.Yellow;
            //        }
            //        else if (Emt[i].theTextlabState == "放在購物車")
            //        {
            //            Emt[i].theBackColor = Color.Orange;
            //        }
            //        else
            //        {
            //            Emt[i].theBackColor = Color.Lime;

            //        }

            //        Emt[i].theClick += (Element source) =>
            //        {
            //            Utility.User = num;

            //            (new FrmMain()).Show();
            //        };

            //        flowLayoutPanel1.Controls.Add(Emt[i]);
            //    };





















        
        



        }

        private void labshopcar_Click(object sender, EventArgs e)
        {
            if (UserData.Member == null)
            {
                MessageBox.Show("請先登入會員");
                return;
            }
            FM_CartPage shopcar = new FM_CartPage(UserData.Member.fid);
            flowLayoutPanel1.Controls.Clear();
            
            shopcar.TopLevel = false;
            shopcar.Parent = flowLayoutPanel1;

            shopcar.Show();
        }

        private void labshop_Click(object sender, EventArgs e)
        {
             FrmShopList shop = new FrmShopList(UserData.Member.fid);
            flowLayoutPanel1.Controls.Clear();
            shop.TopLevel = false;
            shop.Parent = flowLayoutPanel1;
            shop.Show();

        }

        private void FrmHomeScreen_Load(object sender, EventArgs e)
        {
            FrmShopList a = new FrmShopList(0);
            a.TopLevel = false;
            a.Parent = flowLayoutPanel1;
            a.Show();
        }
    }
}
















