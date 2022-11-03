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
using System.Xml.Linq;

namespace prjMember
{
    public partial class Member : Form
    {
        public Member()
        {
            InitializeComponent();
        }

        private void Member_Load(object sender, EventArgs e)
        {
            if (UserData.Member == null)
            {
                //錯誤處理
            }
            else
            {
                //登入成功處理
                titleName.Text = UserData.Member.MemberName;
                txtName.Text = UserData.Member.MemberName;
                txtPhone.Text = UserData.Member.Phone;
                txtGender.Text = UserData.Member.Gender;
                txtCity.Text = UserData.Member.Address_City;
                txtArea.Text = UserData.Member.Address_Area;
                txtBirth.Text = UserData.Member.Birthday.ToString();
                txtEmail.Text = UserData.Member.Email;
                txtPoint.Text = UserData.Member.Point.ToString();
                txtrgtime.Text=UserData.Member.RegisterTime.ToString();
                Image memberPhoto = Image.FromFile(UserData.Member.MemberPhotoFile);            //實作個照片檔 讓他可以讀
                //Bitmap imgoutput = new Bitmap(memberPhoto, 60, 60);
                pictureBox1.BackgroundImage = memberPhoto;                                      //


            }




            ////SqlConnection con = new SqlConnection();
            ////con.ConnectionString = @"Data Source=.;Initial Catalog=iSpan_Project;Integrated Security=True";
            ////con.Open();

            ////SqlCommand cmd = new SqlCommand();
            ////cmd.Connection = con;
            ////Login login = new Login();     //new login表單 取剛輸入的電話

            ////string sql = "SELECT * FROM  NormalMember  WHERE Phone=" ;   //得到Login視窗的電話
            ////cmd.CommandText = sql;
            ////SqlDataReader reader = cmd.ExecuteReader();
            ////if (reader.Read())
            ////{

            ////    txtName.Text = reader["MemberName"].ToString();
            ////    lableName.Text= reader["MemberName"].ToString();   //標題名子
            ////    txtPhone.Text = reader["Phone"].ToString() ;
            ////    txtGender.Text = reader["Gender"].ToString();
            ////    txtCity.Text = reader["Address_City"].ToString();
            ////    txtArea.Text = reader["Address_Area"].ToString();
            ////    txtBirth.Text = reader["Birthday"].ToString();
            ////    txtEmail.Text = reader["Email"].ToString();

            ////}
            //reader.Close();
            //con.Close();




        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            MemberUpdate update = new MemberUpdate();
            update.ShowDialog();
           
        }

        private void gomainform_Click(object sender, EventArgs e)
        {
            this.Close();                  
        }
    }
}
