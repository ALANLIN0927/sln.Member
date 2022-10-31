using prjMember.NewFolder1;
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
using System.Xml.Linq;

namespace prjMember
{
    public partial class MemberRegister : Form
    {
        ////List<CMember>members=null;        集合失敗
        //static int memberID = 1;
        public MemberRegister()
        {
            InitializeComponent();
        }

        private void Registerbtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=iSpan_Project;Integrated Security=True";
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            int memberID = 1;                                                  //先亂設的
            string sql = "INSERT INTO NormalMember (";
            sql += "MemberID,";
            sql += "MemberName,";
            sql += "Phone,";
            sql += "Password,";
            sql += "Gender,";
            sql += "Address_City,";
            sql += "Address_Area,";
            sql += "Birthday,";
            sql += "Email";

            sql += ") VALUES (";
            sql += "@K_MemberID,";
            sql += "@K_MemberName,";
            sql += "@K_Phone,";
            sql += "@K_Password,";
            sql += "@K_Gender,";
            sql += "@K_Address_City,";
            sql += "@K_Address_Area,";
            sql += "@K_Birthday,";
            sql += "@K_Email)";
            cmd.CommandText = sql;
            cmd.Parameters.Add(new SqlParameter("K_MemberID", memberID));
            cmd.Parameters.Add(new SqlParameter("K_MemberName", txtName.Text));
            cmd.Parameters.Add(new SqlParameter("K_Phone", txtPhone.Text));
            cmd.Parameters.Add(new SqlParameter("K_Password", txtPassword.Text));
            cmd.Parameters.Add(new SqlParameter("K_Gender", comboboxsexy.Text));
            cmd.Parameters.Add(new SqlParameter("K_Address_City", txtCity.Text));
            cmd.Parameters.Add(new SqlParameter("K_Address_Area", txtArea.Text));
            cmd.Parameters.Add(new SqlParameter("K_Birthday", txtBirthday.Value));
            cmd.Parameters.Add(new SqlParameter("K_Email", txtEmail.Text));
            //CMember member = new CMember();                             //創集合創到一半 不知道錯在哪
            //member.MemberID = memberID;
            //member.MemberName = txtName.Text;
            //member.Phone = txtPhone.Text;
            //member.Password = txtPassword.Text;
            //member.Gender = comboboxsexy.Text;
            //member.Address_City = txtCity.Text;
            //member.Address_Area = txtArea.Text;
            //member.Birtyday = txtBirthday.Value;
            //member.Email = txtEmail.Text;
            //members = new List<CMember>();
            //members.Add(member);

            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("註冊成功");
            //memberID++;
            //MessageBox.Show(members[0].Email);



        }
    }
}









