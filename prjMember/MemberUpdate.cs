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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjMember
{
    public partial class MemberUpdate : Form
    {

        DateTime registertime; 



        public MemberUpdate()
        {
            InitializeComponent();
        }

        private void MemberUpdate_Load(object sender, EventArgs e)
        {
            txtName.Text = UserData.Member.MemberName;               //載入點 顯示會員資料在資料表上
            lableName.Text = UserData.Member.MemberName;
            txtPassword.Text = UserData.Member.Password;
            txtPassword2.Text = UserData.Member.Password;
            txtGender.Text = UserData.Member.Gender;
            txtCity.Text = UserData.Member.Address_City;
            txtArea.Text = UserData.Member.Address_Area;
            birthpicker.Value = UserData.Member.Birthday;              
            txtEmail.Text = UserData.Member.Email;
            registertime = UserData.Member.RegisterTime;

            Image memberPhoto = Image.FromFile(UserData.Member.MemberPhotoFile);
            picheadphoto.BackgroundImage = memberPhoto;


        }









          
        string file;
        private void Update_Click(object sender, EventArgs e)
        {
            Random crandom = new Random(Guid.NewGuid().GetHashCode()); 
            int Rannum = crandom.Next(1, 1000);
            string picture = "";                            //判斷有無換照片
            if (file == null) { picture = UserData.Member.MemberPhotoFile; }   

            else
            {
                Image img = Image.FromFile(file);
                picture = "../../img/NormalMember_Img/" + UserData.Member.Phone + Rannum + "_.bmp";
                img.Save(picture);

            }
            if (txtPassword.Text != txtPassword2.Text)
            {
                MessageBox.Show("請確認兩欄密碼");
                return;


            }
            if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {

                MessageBox.Show("請填寫名子");
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
            



            SqlConnection con = new SqlConnection(UserData.linkstream);
            con.Open();
            SqlCommand cmd = new SqlCommand();


            string sql = "UPDATE NormalMember SET ";
            sql += "MemberName=@K_NAME,";
            sql += "Password=@K_PASSWORD,";
            sql += "Gender=@K_GENDER,";
            sql += "Address_City=@K_CITY,";
            sql += "Address_Area=@K_AREA,";
            sql += "Birthday=@K_Birthday,";
            sql += "Email=@K_Email,";
            sql += "MemberPhotoFile=@K_MemberPhotoFile";
            sql += " WHERE fid = @fid";


            cmd.Parameters.Add(new SqlParameter("K_NAME", txtName.Text));
            cmd.Parameters.Add(new SqlParameter("K_PASSWORD", txtPassword.Text));
            cmd.Parameters.Add(new SqlParameter("K_GENDER", txtGender.Text));
            cmd.Parameters.Add(new SqlParameter("K_CITY", txtCity.Text));
            cmd.Parameters.Add(new SqlParameter("K_AREA", txtArea.Text));
            cmd.Parameters.Add(new SqlParameter("K_Birthday", birthpicker.Value));   //轉型
            cmd.Parameters.Add(new SqlParameter("K_Email", txtEmail.Text));
            cmd.Parameters.Add(new SqlParameter("fid", UserData.Member.fid));
            cmd.Parameters.Add(new SqlParameter("K_MemberPhotoFile", picture));  //現在加的;
            /*cmd.Parameters.Add(new SqlParameter("K_MemberPhotoFile", "../../img/NormalMember_Img/" + txtPhone.Text + Rannum + "_.bmp"))*/
            ;//加圖片;


            cmd.Connection = con;
            cmd.CommandText = sql;

            cmd.ExecuteNonQuery();
            con.Close();

            UserData.Member = new NewFolder1.CMember                           //改資料傳回去
            {
                MemberName = txtName.Text,
                Phone = UserData.Member.Phone,
                Password = txtPassword.Text,
                Gender = txtGender.Text,
                Address_City = txtCity.Text,
                Address_Area = txtArea.Text,
                Birthday = birthpicker.Value,              //轉型
                Email = txtEmail.Text,

                RegisterTime = registertime,
                /* MemberPhotoFile = "../../img/NormalMember_Img/" + txtPhone.Text + Rannum + "_.bmp"*/     //改圖片加回去會員
                MemberPhotoFile = picture
            };


            MessageBox.Show("修改完成");



            this.Close(); con.Close();



        }

        private void gohome_Click(object sender, EventArgs e)
        {
            this.Close();
            
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
                

                //Image img = Image.FromFile(file);            //現在改的
                //img.Save("../../img/NormalMember_Img/" + txtPhone.Text + Rannum + "_.bmp");
            }
        }

        

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}