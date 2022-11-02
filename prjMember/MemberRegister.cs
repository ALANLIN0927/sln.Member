using prjMember.NewFolder1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;           //為了picture加的
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;

namespace prjMember
{
    public partial class MemberRegister : Form
    {
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
            int memberID = 0; int point = 0;
            //先亂設的
            string sql = "INSERT INTO NormalMember (";
            sql += "MemberID,";
            sql += "MemberName,";
            sql += "Phone,";
            sql += "Password,";
            sql += "Gender,";
            sql += "Address_City,";
            sql += "Address_Area,";
            sql += "Birthday,";
            sql += "Email,";
            sql += "Point,";
            sql += "RegisterTime";

            sql += ") VALUES (";
            sql += "@K_MemberID,";
            sql += "@K_MemberName,";
            sql += "@K_Phone,";
            sql += "@K_Password,";
            sql += "@K_Gender,";
            sql += "@K_Address_City,";
            sql += "@K_Address_Area,";
            sql += "@K_Birthday,";
            sql += "@K_Email,";
            sql += "@K_Point,";
            sql += "@K_RegisterTime)";
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
            cmd.Parameters.Add(new SqlParameter("K_Point", point.ToString()));
            cmd.Parameters.Add(new SqlParameter("K_RegisterTime", DateTime.Now));   //修改過不用tostring


            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("註冊成功");
            //memberID++;




        }



        private void pictureBox1_Click_1(object sender, EventArgs e)
        {



            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (pictureBox1.BackgroundImage != null)                           //目前先這樣
                {
                    pictureBox1.BackgroundImage.Dispose();
                    pictureBox1.BackgroundImage = null;
                }
                string file = openFileDialog1.FileName;

                pictureBox1.BackgroundImage = Image.FromFile(file);
                //pictureBox1.Image.Dispose();







            }
        }
    }
}










