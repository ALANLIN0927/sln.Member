using prjMember.AllClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
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
                try
                {
                    System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
                    msg.To.Add("blinda12@ms4.hinet.net");//blinda12@ms4.hinet.net
                    //msg.To.Add("b@b.com");可以發送給多人
                    //msg.CC.Add("c@c.com");
                    //msg.CC.Add("c@c.com");可以抄送副本給多人 
                    //這裡可以隨便填，不是很重要
                    msg.From = new MailAddress("blinda12@ms4.hinet.net", "Nidin點餐平台", System.Text.Encoding.UTF8);
                    /* 上面3個參數分別是發件人地址（可以隨便寫），發件人姓名，編碼*/
                    msg.Subject = txtName.Text+"您好";//郵件標題
                    msg.SubjectEncoding = System.Text.Encoding.UTF8;//郵件標題編碼
                    msg.Body = "您的平台帳號密碼為"+Password; //郵件內容
                    msg.BodyEncoding = System.Text.Encoding.UTF8;//郵件內容編碼 
                    /*msg.Attachments.Add(new Attachment(@"D:\test2.docx")); */ //附件
                    msg.IsBodyHtml = true;//是否是HTML郵件 
                                          //msg.Priority = MailPriority.High;//郵件優先級 

                    SmtpClient client = new SmtpClient();
                    client.Credentials = new System.Net.NetworkCredential("a29816668@gmail.com", "ytfv xcva tmkp zuzo"); //這裡要填正確的帳號跟密碼
                    client.Host = "smtp.gmail.com"; //設定smtp Server
                    client.Port = 25; //設定Port
                    client.EnableSsl = true; //gmail預設開啟驗證
                    client.Send(msg); //寄出信件
                    client.Dispose();
                    msg.Dispose();
                    MessageBox.Show(this, "已經送信件到您信箱,請確認！");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message);
                }
            }
            else 
            { 
                MessageBox.Show("找無此會員請重新輸入對的資料");
                return;
            
            }
            


            reader.Close();
            con.Close();




        }

        private void gohome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
