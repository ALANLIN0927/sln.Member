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
    public partial class Homescreen : Form
    {
        public Homescreen()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login a = new Login();
            a.ShowDialog();
        }

        private void memberinformation_Click(object sender, EventArgs e)
        {
            Member person = new Member();
            person.MdiParent = this;
            person.WindowState = FormWindowState.Maximized;
            person.Show();
        }

        private void Homescreen_Load(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Login a = new Login();
            a.ShowDialog();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Member person = new Member();
            person.MdiParent = this;
            person.WindowState = FormWindowState.Maximized;
            person.Show();
        }
    }
}
