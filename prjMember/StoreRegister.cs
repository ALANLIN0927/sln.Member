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
using System.Xml.Linq;

namespace prjMember
{
    public partial class StoreRegister : Form
    {
        public StoreRegister()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=iSpan_Project;Integrated Security=True";
            con.Open();
            int busnissid = 1;                              //member先亂設的
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            string sql = "INSERT INTO BusinessMember (";
            sql += "MemberName,";
            sql += "Phone,";
            sql += "Password,";
            sql += "OpenTime,";
            sql += "CloseTime,";
            sql += "Address,";
            sql += "ShopType,";
            sql += "Email,";
            sql += "DeliveryAmount,";
            sql += "RegisterTime,";
            sql += "ContactPerson,";
            sql += "MemberID";
            sql += ") VALUES (";
            sql += "@K_MemberName,";
            sql += "@K_Phone,";
            sql += "@K_Password,";
            sql += "@K_OpneTime,";
            sql += "@K_CloseTime,";
            sql += "@K_Address,";
            sql += "@K_ShopType,";
            sql += "@K_Email,";
            sql += "@K_DeliveryAmount,";
            sql += "@K_RegisterTime,";
            sql += "@K_ContactPerson,";
            sql += "@K_MemberID)";
            cmd.CommandText = sql;
            cmd.Parameters.Add(new SqlParameter("K_MemberName", txtName.Text));
            cmd.Parameters.Add(new SqlParameter("K_Phone", txtPhone.Text));
            cmd.Parameters.Add(new SqlParameter("K_Password", txtPassword.Text));
            cmd.Parameters.Add(new SqlParameter("K_OpneTime", txtOpen.Text));
            cmd.Parameters.Add(new SqlParameter("K_CloseTime", txtClose.Text));
            cmd.Parameters.Add(new SqlParameter("K_Address", txtAddress.Text));
            cmd.Parameters.Add(new SqlParameter("K_ShopType", txtType.Text));
            cmd.Parameters.Add(new SqlParameter("K_Email", txtemail.Text));
            cmd.Parameters.Add(new SqlParameter("K_DeliveryAmount", decimal.Parse(txtdeliveryamount.Text)));
            cmd.Parameters.Add(new SqlParameter("K_RegisterTime", txtRegistertime.Text));
            cmd.Parameters.Add(new SqlParameter("K_ContactPerson", txtContactPerson.Text));
            cmd.Parameters.Add(new SqlParameter("K_MemberID",busnissid ));


            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("註冊成功");












        }
    }
}
