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

namespace prjMember
{
    public partial class Forgetpassword : Form
    {
        public Forgetpassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Password;
            SqlConnection con = new SqlConnection(UserData.linkstream);
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            string sql = "SELECT * FROM  NormalMember   WHERE Phone=@K_Phone AND MemberName=@K_MemberName AND Email=@K_Email";
            cmd.CommandText = sql;
            cmd.Parameters.Add(new SqlParameter("K_Phone", txtPhone.Text));
            cmd.Parameters.Add(new SqlParameter("K_MemberName", txtName.Text));
            cmd.Parameters.Add(new SqlParameter("K_Email", txtEmail.Text));
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                Password = reader["password"].ToString();
                MessageBox.Show("你的密碼為" + Password);
            }
            else 
            { 
                MessageBox.Show("找無此會員請重新輸入對的資料");
                return;
            
            }
            


            reader.Close();
            con.Close();




        }
    }
}
