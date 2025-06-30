using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Management_System
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        pmsDataContext db;
        private void button1_Click(object sender, EventArgs e)
        {
            db = new pmsDataContext();
            try
            {
                var user = textBox1.Text;
                var pass = textBox2.Text;

                var check_client = from ck in db.Admin_Logins
                                   where ck.userid == user && ck.pass == pass
                                   select ck;
                if (check_client != null)
                {

                    Admin_Console admin = new Admin_Console();
                    admin.Show();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Your Username or Password is Wrong");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
