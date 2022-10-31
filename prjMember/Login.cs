using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjMember
{

    public partial class Login : Form
    {
        bool isClosed = true;
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MemberRegister reg = new MemberRegister();
            reg.ShowDialog();
        }



        //private void txtpassword_TextChanged(object sender, EventArgs e)
        //{
        //    bool correct = correctpassword(txtpassword.Text);
        //    passwordcorrect.Text = correct ? "格式正確" : "格式錯誤";

        //}

        /// <summary>
        /// correctpassword
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        private bool correctpassword(string password)
        {
            bool result = Regex.IsMatch(password, @"^(?=.*\d))(?=.*A-Z].{8,16}$");
            return result;
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=Member;Integrated Security=True";
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            string sql = "SELECT * FROM  MemberTable   WHERE Phone=@K_Phone AND Password=@K_PASSWORD";
            cmd.CommandText = sql;
            cmd.Parameters.Add(new SqlParameter("K_Phone", txtPhone.Text));
            cmd.Parameters.Add(new SqlParameter("K_PASSWORD", txtpassword.Text));
            bool isAuthenticated = false;
            SqlDataReader reader = cmd.ExecuteReader();
            isAuthenticated = reader.Read();
            reader.Close();
            con.Close();

            if (isAuthenticated)
            {
                isClosed = false;

                this.Close();
                return;

            }
            MessageBox.Show("帳號與密碼不符");
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = isClosed;
        }

        private void leavebtn_Click(object sender, EventArgs e)
        {
            isClosed = false;
            Application.Exit();

        }
        public string phoneget() {
            return txtPhone.Text;
        }
    }
}
