﻿using prjMember.AllClass;
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

        /// <summary>
        /// 一般註冊按鈕事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            MemberRegister reg = new MemberRegister();
            reg.ShowDialog();
        }



       
       

        private void LoginBtn_Click(object sender, EventArgs e)
        {            
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=iSpan_Project;Integrated Security=True";
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            string sql = "SELECT * FROM  NormalMember   WHERE Phone=@K_Phone AND Password=@K_PASSWORD";
            cmd.CommandText = sql;
            cmd.Parameters.Add(new SqlParameter("K_Phone", txtPhone.Text));
            cmd.Parameters.Add(new SqlParameter("K_PASSWORD", txtpassword.Text));
            //bool isAuthenticated = false;
            SqlDataReader reader = cmd.ExecuteReader();
            //isAuthenticated = reader.Read();
           

            //if (isAuthenticated)
            if(reader.Read())
            {

                UserData.Member = new NewFolder1.CMember();
                UserData.Member.fid = (int)reader["fid"];
                UserData.Member.MemberName = reader["MemberName"].ToString();
                UserData.Member.Phone = reader["Phone"].ToString();
                UserData.Member.Password = reader["Password"].ToString();
                UserData.Member.Gender = reader["Gender"].ToString();
                UserData.Member.Address_City = reader["Address_City"].ToString();
                UserData.Member.Address_Area = reader["Address_Area"].ToString();
                UserData.Member.Birthday = DateTime.Parse(reader["Birthday"].ToString());
                UserData.Member.Email = reader["Email"].ToString();
                UserData.Member.Point = (int)reader["Point"];
                UserData.Member.RegisterTime = DateTime.Parse(reader["RegisterTime"].ToString());
                UserData.Member.MemberPhotoFile = reader["MemberPhotoFile"].ToString();

                reader.Close();
                con.Close();

                isClosed = false;
                this.Close();
                //return;








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

        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool correct = Regex.IsMatch(txtpassword.Text, @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{4,16}$");
            if(correct)
            {
                labpassword.Text = "密碼格式正確";
                labpassword.BackColor = Color.CornflowerBlue;
           
            }
            else
            {
                labpassword.Text = "密碼格式錯誤";
                labpassword.BackColor = Color.DarkRed;
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool correct = Regex.IsMatch(txtPhone.Text, @"^09[0-9]{7}$");
            if (correct)
            {
                labphone.Text = "電話格式正確";
                labphone.BackColor = Color.CornflowerBlue;
            }
            else
            {
                labphone.Text = "電話格式錯誤";
                labphone.BackColor = Color.DarkRed;
            }
        }
    }
}
