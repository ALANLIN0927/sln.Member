using prjMember.AllClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace prjMember
{
    public partial class StoreUpdate : Form
    {
        public StoreUpdate()
        {
            InitializeComponent();
        }

        private void StoreUpdate_Load(object sender, EventArgs e)
        {
            txtName.Text = UserData.MemberBusiness.MemberName;
            txtPhone.Text = UserData.MemberBusiness.Phone;
            txtPassword.Text = UserData.MemberBusiness.Password;
            txtAddress.Text = UserData.MemberBusiness.Address;
            txtType.Text = UserData.MemberBusiness.ShopType;
            txtOpentime.Text = UserData.MemberBusiness.OpenTime.ToString();
            txtClosetime.Text = UserData.MemberBusiness.CloseTime.ToString();
            txtEmail.Text = UserData.MemberBusiness.Email;
            txtpay.Text = UserData.MemberBusiness.DeliveryAmount.ToString();
            txtContactPerson.Text = UserData.MemberBusiness.ContactPerson;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=iSpan_Project;Integrated Security=True";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            string sql = "UPDATE NormalMember SET ";
            sql += "MemberName=@K_NAME,";
            sql += "Phone=@K_PHONE,";
            sql += "Password=@K_PASSWORD,";
            sql += "ShopType=@K_ShopType,";
            sql += "Address=@K_Address,";
            sql += "OpenTime=@K_OpenTime,";
            sql += "CloseTime=@K_CloseTime,";
            sql += "Email=@K_Email,";
            sql += "ContactPerson=@K_ContactPerson";
            sql += " WHERE fid = @fid";                                                         //再看一下ID名子

            cmd.CommandText = sql;
            cmd.Parameters.Add(new SqlParameter("K_NAME", txtName.Text));
            cmd.Parameters.Add(new SqlParameter("K_PHONE", txtPhone.Text));
            cmd.Parameters.Add(new SqlParameter("K_PASSWORD", txtPassword.Text));
            cmd.Parameters.Add(new SqlParameter("K_ShopType", txtType.Text));
            cmd.Parameters.Add(new SqlParameter("K_Address", txtAddress.Text));
            cmd.Parameters.Add(new SqlParameter("K_OpenTime", txtOpentime.Text));
            cmd.Parameters.Add(new SqlParameter("K_CloseTime", txtClosetime.Text));
            cmd.Parameters.Add(new SqlParameter("K_Email", txtEmail.Text));
            cmd.Parameters.Add(new SqlParameter("K_ContactPerson", txtContactPerson.Text));
            cmd.Parameters.Add(new SqlParameter("fid", UserData.MemberBusiness.fid));           //在看FID的名子


            cmd.Connection = con;
            cmd.CommandText = sql;

            cmd.ExecuteNonQuery();
            con.Close();

            UserData.MemberBusiness = new AllClass.CBusinessMember                     //不用加()
            {

                MemberName = txtName.Text,
                Phone = txtPhone.Text,
                Password = txtPassword.Text,
                ShopType = txtType.Text,
                Address = txtAddress.Text,
                OpenTime = DateTime.Parse(txtOpentime.Text),                     //注意格式
                CloseTime = DateTime.Parse(txtClosetime.Text),
                Email = txtEmail.Text,
                ContactPerson = txtContactPerson.Text,



            };
























        }
    }
}
