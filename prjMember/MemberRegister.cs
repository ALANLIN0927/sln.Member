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
       
        string file="";
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (pictureBox1.BackgroundImage != null)                           //目前先這樣
                {
                    pictureBox1.BackgroundImage.Dispose();
                    pictureBox1.BackgroundImage = null;
                }
                file = openFileDialog1.FileName;
                pictureBox1.BackgroundImage = new Bitmap(file);

                                // imgmemberPhoto存 c槽檔案
            }
        }

       

        private void txtPassword_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            bool correct = Regex.IsMatch(txtPassword.Text, @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,16}$");
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
            //if (!(txtPassword.Text == txtPassword2.Text))
            //{
            //    MessageBox.Show("請確認兩欄密碼相同");                                  //驗證密碼
            //    return;


            //}
            //if (string.IsNullOrEmpty(txtName.Text.Trim())){

            //    MessageBox.Show("請填寫名子");
            //    return;


            //}
            //if (string.IsNullOrEmpty(txtPhone.Text.Trim()))
            //{
            //    MessageBox.Show("請輸入電話");
            //    return;
            //}
            //if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            //{
            //    MessageBox.Show("請輸入密碼");
            //    return ;
            //}

            Random crandom = new Random(Guid.NewGuid().GetHashCode());   //產生亂數
            int Rannum = crandom.Next(1, 1000);
            Image img = Image.FromFile(file);                       //
            img.Save("../../img/NormalMember_Img/" + txtPhone.Text + Rannum + "_.bmp");

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
            sql += "RegisterTime,";
            sql += "MemberPhotoFile";

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
            sql += "@K_RegisterTime,";
            sql += "@K_MemberPhotoFile)";
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
            cmd.Parameters.Add(new SqlParameter("K_MemberPhotoFile", "../../img/NormalMember_Img/" + txtPhone.Text + Rannum + "_.bmp"));

            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("註冊成功");

            

        }
    }
}










