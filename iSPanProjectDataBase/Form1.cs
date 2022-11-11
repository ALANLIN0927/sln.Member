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

namespace iSPanProjectDataBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int fid;
        public int getUserFid
        {
            get { return fid; }
        }
        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=msit145nidin.database.windows.net;Initial Catalog=iSpan_Project;Persist Security Info=True;User ID=MSIT145nidin;Password=Nidinmsit145"
                );
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
            if (reader.Read())
            {
                fid = (int)reader["fid"];
                //UserData.Member = new NewFolder1.CMember();
                //UserData.Member.fid = (int)reader["fid"];
                //UserData.Member.MemberName = reader["MemberName"].ToString();
                //UserData.Member.Phone = reader["Phone"].ToString();
                //UserData.Member.Password = reader["Password"].ToString();
                //UserData.Member.Gender = reader["Gender"].ToString();
                //UserData.Member.Address_City = reader["Address_City"].ToString();
                //UserData.Member.Address_Area = reader["Address_Area"].ToString();
                //UserData.Member.Birthday = DateTime.Parse(reader["Birthday"].ToString());
                //UserData.Member.Email = reader["Email"].ToString();
                //UserData.Member.Point = (int)reader["Point"];
                //UserData.Member.RegisterTime = DateTime.Parse(reader["RegisterTime"].ToString());
                //UserData.Member.MemberPhotoFile = reader["MemberPhotoFile"].ToString();

                //membername = reader["MemberName"].ToString();
                reader.Close();
                con.Close();


                this.Close();
                return;
            }



            MessageBox.Show("帳號與密碼不符");
        }
    }
}
