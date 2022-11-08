using prjMember.AllClass;
using prjMember.NewFolder1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;           //為了picture加的
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
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

        string file ;
        




        private void txtPassword_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            bool correct = Regex.IsMatch(txtPassword.Text, @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{2,16}$");
            if (correct)
            {
                labpassword.Text = "密碼格式正確";
                labpassword.BackColor = Color.CornflowerBlue;

            }
            else
            {
                labpassword.Text = "密碼格式錯誤";
                labpassword.BackColor = Color.Red;


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
                labphone.BackColor = Color.Red;
            }
        }

        private void Registerbtn_Click(object sender, EventArgs e)
        {
            if (!(txtPassword.Text == txtPassword2.Text))
            {
                MessageBox.Show("請確認兩欄密碼相同");                                  //驗證密碼
                return;


            }
            if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {

                MessageBox.Show("請填寫名子");
                return;


            }
            if (string.IsNullOrEmpty(txtPhone.Text.Trim()))
            {
                MessageBox.Show("請輸入電話");
                return;
            }
            if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                MessageBox.Show("請輸入密碼");
                return;
            }
            if (labpassword.Text == "密碼格式錯誤")
            {
                MessageBox.Show("請輸入正確密碼格式");
                return;
            }
            if (labphone.Text == "電話格式錯誤")
            {
                MessageBox.Show("請輸入正確電話格式");
                return;
            }
            string phone = "";
            string phonenumber = txtPhone.Text;
            SqlConnection con = new SqlConnection(UserData.linkstream);
            con.Open();
            string sql = "SELECT COUNT(*)AS phonecount FROM NormalMember Where Phone='" + phonenumber+"'";
            //判斷資料庫電話號碼有無重複
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = sql;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                 phone = dr["phonecount"].ToString();
            }
            con.Close();

            if (phone == "1")
            {

                MessageBox.Show("電話已註冊過,請輸入別的電話號碼");
                return;
            }
            else
            {
                Random crandom = new Random(Guid.NewGuid().GetHashCode());   //產生亂數
                int Rannum = crandom.Next(1, 1000);
                string picture = "";
                if (file == null) { picture = "../../img/NormalMember_Img/default_member.jpg"; }  //判斷有沒有換照片
                else
                {
                    Image img = Image.FromFile(file);
                    picture = "../../img/NormalMember_Img/" + txtPhone.Text + Rannum + "_.bmp";

                    img.Save(picture);
                }

                SqlConnection conn1 = new SqlConnection(UserData.linkstream);
                conn1.Open();

                SqlCommand cmd1 = new SqlCommand();
                cmd1.Connection = conn1;
                int memberID = 0; int point = 0;
                //號碼點數先亂設的
                string sql1 = "INSERT INTO NormalMember (";
                sql1 += "MemberID,";
                sql1 += "MemberName,";
                sql1 += "Phone,";
                sql1 += "Password,";
                sql1 += "Gender,";
                sql1 += "Address_City,";
                sql1 += "Address_Area,";
                sql1 += "Birthday,";
                sql1 += "Email,";
                sql1 += "Point,";
                sql1 += "RegisterTime,";
                sql1 += "MemberPhotoFile";

                sql1 += ") VALUES (";
                sql1 += "@K_MemberID,";
                sql1 += "@K_MemberName,";
                sql1 += "@K_Phone,";
                sql1 += "@K_Password,";
                sql1 += "@K_Gender,";
                sql1 += "@K_Address_City,";
                sql1 += "@K_Address_Area,";
                sql1 += "@K_Birthday,";
                sql1 += "@K_Email,";
                sql1 += "@K_Point,";
                sql1 += "@K_RegisterTime,";
                sql1 += "@K_MemberPhotoFile)";
                cmd1.CommandText = sql1;
                cmd1.Parameters.Add(new SqlParameter("K_MemberID", memberID));
                cmd1.Parameters.Add(new SqlParameter("K_MemberName", txtName.Text));
                cmd1.Parameters.Add(new SqlParameter("K_Phone", txtPhone.Text));
                cmd1.Parameters.Add(new SqlParameter("K_Password", txtPassword.Text));

                cmd1.Parameters.Add(new SqlParameter("K_Gender", comboboxsexy.Text));
                cmd1.Parameters.Add(new SqlParameter("K_Address_City", txtCity.Text));
                cmd1.Parameters.Add(new SqlParameter("K_Address_Area", txtArea.Text));
                cmd1.Parameters.Add(new SqlParameter("K_Birthday", txtBirthday.Value.ToShortDateString()));
                cmd1.Parameters.Add(new SqlParameter("K_Email", txtEmail.Text));
                cmd1.Parameters.Add(new SqlParameter("K_Point", point.ToString()));
                cmd1.Parameters.Add(new SqlParameter("K_RegisterTime", DateTime.Now.ToShortDateString()));   
                cmd1.Parameters.Add(new SqlParameter("K_MemberPhotoFile", picture));


                cmd1.ExecuteNonQuery();

                conn1.Close();

                MessageBox.Show("註冊成功");
                this.Close();
                Login login = new Login();
                login.ShowDialog();
            }
        }

        private void picheadphoto_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (picheadphoto.BackgroundImage != null)
                {
                    picheadphoto.BackgroundImage.Dispose();
                    picheadphoto.BackgroundImage = null;
                }
                file = openFileDialog1.FileName;
                picheadphoto.BackgroundImage = new Bitmap(file);


            }
        }
    }
}










