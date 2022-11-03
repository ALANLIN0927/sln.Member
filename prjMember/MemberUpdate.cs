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
        
        DateTime r; //子路教的
       
        
        
        public MemberUpdate()
        {
            InitializeComponent();
        }

        private void MemberUpdate_Load(object sender, EventArgs e)
        {   
            txtName.Text=UserData.Member.MemberName;               //載入點 秀畫面在資料表上
            lableName.Text=UserData.Member.MemberName;
            txtPhone.Text = UserData.Member.Phone;
            txtGender.Text = UserData.Member.Gender;

            txtCity.Text = UserData.Member.Address_City;
            txtArea.Text = UserData.Member.Address_Area;
            birthpicker.Value = UserData.Member.Birthday;              //轉
            txtEmail.Text = UserData.Member.Email;
            r = UserData.Member.RegisterTime;

            Image memberPhoto = Image.FromFile(UserData.Member.MemberPhotoFile);
            pictureBox1.BackgroundImage = memberPhoto;               //讀取會員照片
        }









        Random crandom = new Random(Guid.NewGuid().GetHashCode());   //產生亂數

        private void button2_Click(object sender, EventArgs e)
        {
           
            int Rannum = crandom.Next(1, 1000);
            string picture=""; /*"../../img/NormalMember_Img/" + txtPhone.Text + Rannum + "_.bmp"*/ //現在改的;
            if (file == null) { picture = UserData.Member.MemberPhotoFile; }   //string file不給數就是空值?

            else
            {
                Image img = Image.FromFile(file);
                picture = "../../img/NormalMember_Img/" + txtPhone.Text + Rannum + "_.bmp";
                img.Save(picture);

            }

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
            sql += "Email=@K_Email,";
            sql += "MemberPhotoFile=@K_MemberPhotoFile";
            sql += " WHERE fid = @fid";


            cmd.Parameters.Add(new SqlParameter("K_NAME", txtName.Text));
            cmd.Parameters.Add(new SqlParameter("K_PHONE", txtPhone.Text));
            cmd.Parameters.Add(new SqlParameter("K_PASSWORD", txtPassword.Text));
            cmd.Parameters.Add(new SqlParameter("K_GENDER", txtGender.Text));
            cmd.Parameters.Add(new SqlParameter("K_CITY", txtCity.Text));
            cmd.Parameters.Add(new SqlParameter("K_AREA", txtArea.Text));
            cmd.Parameters.Add(new SqlParameter("K_Birthday", birthpicker.Value));   //轉型
            cmd.Parameters.Add(new SqlParameter("K_Email", txtEmail.Text));
            cmd.Parameters.Add(new SqlParameter("fid", UserData.Member.fid));
            cmd.Parameters.Add(new SqlParameter("K_MemberPhotoFile",picture ));  //現在加的;
            /*cmd.Parameters.Add(new SqlParameter("K_MemberPhotoFile", "../../img/NormalMember_Img/" + txtPhone.Text + Rannum + "_.bmp"))*/;//加圖片;


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
                Birthday = birthpicker.Value,              //轉型
                Email = txtEmail.Text,

                RegisterTime = r,
                /* MemberPhotoFile = "../../img/NormalMember_Img/" + txtPhone.Text + Rannum + "_.bmp"*/     //改圖片加回去會員
                MemberPhotoFile = picture
            };


            







        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            //Member personalmatrial=new Member();
            //personalmatrial.ShowDialog();              //為啥用show會消失
        }
        string file;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            /*int Rannum = crandom.Next(1, 1000);   */      //現在加的
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (pictureBox1.BackgroundImage != null)                           //目前先這樣
                {
                    pictureBox1.BackgroundImage.Dispose();
                    pictureBox1.BackgroundImage = null;
                }
                file = openFileDialog1.FileName;
                pictureBox1.BackgroundImage = new Bitmap(file);
                //pictureBox1.BackgroundImage = Image.FromFile(file);
                //pictureBox1.Image.Dispose();

                //Image img = Image.FromFile(file);            //現在改的
                //img.Save("../../img/NormalMember_Img/" + txtPhone.Text + Rannum + "_.bmp");
            }
        }
    }
}
