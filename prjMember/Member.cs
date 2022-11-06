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

            titleName.Text = UserData.Member.MemberName;
            txtName.Text = UserData.Member.MemberName;
            txtPhone.Text = UserData.Member.Phone;
            txtGender.Text = UserData.Member.Gender;
            txtCity.Text = UserData.Member.Address_City;
            txtArea.Text = UserData.Member.Address_Area;
            txtBirth.Text = UserData.Member.Birthday.ToString();
            txtEmail.Text = UserData.Member.Email;
            txtPoint.Text = UserData.Member.Point.ToString();
            txtrgtime.Text = UserData.Member.RegisterTime.ToString();
            Image memberPhoto = Image.FromFile(UserData.Member.MemberPhotoFile);
            picheadphoto.BackgroundImage = memberPhoto;
        }
        private void update_Click(object sender, EventArgs e)
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









    

