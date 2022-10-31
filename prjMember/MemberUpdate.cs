using prjMember.AllClass;
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

namespace prjMember
{
    public partial class MemberUpdate : Form
    {
        public MemberUpdate()
        {
            InitializeComponent();
        }

        private void MemberUpdate_Load(object sender, EventArgs e)
        {   
            txtName.Text=UserData.Member.MemberName;               //載入點 秀畫面在資料表上
            txtPhone.Text = UserData.Member.Phone;
            txtGender.Text = UserData.Member.Gender;

            txtCity.Text = UserData.Member.Address_City;
            txtArea.Text = UserData.Member.Address_Area;
            txtBirth.Text = UserData.Member.Birthday.ToString();
            txtEmail.Text = UserData.Member.Email;

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
            sql += "Gender=@K_GENDER,";
            sql += "Address_City=@K_CITY,";
            sql += "Address_Area=@K_AREA,";
            sql += "Birthday=@K_Birthday,";
            sql += "Email=@K_Email";
            sql += " WHERE fid = @fid";               
           
            cmd.Parameters.Add(new SqlParameter("K_NAME", txtName.Text));
            cmd.Parameters.Add(new SqlParameter("K_PHONE", txtPhone.Text));
            cmd.Parameters.Add(new SqlParameter("K_PASSWORD", txtPassword.Text));
            cmd.Parameters.Add(new SqlParameter("K_GENDER", txtGender.Text));
            cmd.Parameters.Add(new SqlParameter("K_CITY", txtCity.Text));
            cmd.Parameters.Add(new SqlParameter("K_AREA", txtArea.Text));
            cmd.Parameters.Add(new SqlParameter("K_Birthday", txtBirth.Text));
            cmd.Parameters.Add(new SqlParameter("K_Email", txtEmail.Text));
            cmd.Parameters.Add(new SqlParameter("fid", UserData.Member.fid));


            cmd.Connection = con;
            cmd.CommandText = sql;

            cmd.ExecuteNonQuery();
            con.Close();
            UserData.Member = new NewFolder1.CMember                           //改資料傳回去
            {
                MemberName = txtName.Text,
                Phone = txtPhone.Text,
                Password = txtPassword.Text,
                Gender = txtGender.Text,
                Address_City = txtCity.Text,
                Address_Area = txtArea.Text,
                Birthday = DateTime.Parse(txtBirth.Text),
                Email = txtEmail.Text,




            };



            
        }
    }
}
