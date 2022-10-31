using prjMember.AllClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjMember
{
    public partial class StoreNews : Form
    {
        public StoreNews()
        {
            InitializeComponent();
     
        
        
        }

        private void StoreNews_Load(object sender, EventArgs e)
        {
            if (UserData.MemberBusiness == null)
            { return; }
            else
            {
                txtName.Text = UserData.MemberBusiness.MemberName;
                txtPhone.Text = UserData.MemberBusiness.Phone;
                txtAddress.Text = UserData.MemberBusiness.Address;
                txtType.Text = UserData.MemberBusiness.ShopType;
                txtOpentime.Text = UserData.MemberBusiness.OpenTime.ToString();
                txtClosetime.Text = UserData.MemberBusiness.ToString();
                txtEmail.Text = UserData.MemberBusiness.Email;
                txtPay.Text = UserData.MemberBusiness.DeliveryAmount.ToString();
                txtcpname.Text = UserData.MemberBusiness.ContactPerson;
                
            }
        }
    }









}
