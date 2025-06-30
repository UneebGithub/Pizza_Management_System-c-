using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Pizza_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.AliceBlue;  
        }

        
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Transparent;  
        }

        pmsDataContext db;

        
        private void button1_Click(object sender, EventArgs e)
        {
            db = new pmsDataContext();
            try
            {
                var user = textBox1.Text;
                var pass = textBox2.Text;

                
                var check_client = from ck in db.Emp_Logins
                                   where ck.Cuserid == user && ck.Cpass == pass
                                   select ck;

                
                if (check_client.Any())  
                {
                    
                    Emp_Frame emp_Frame = new Emp_Frame();
                    emp_Frame.Show();
                  //  this.Hide();  
                }
                else
                {
                    MessageBox.Show("Your Username or Password is Wrong");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            AdminLogin lg = new AdminLogin();
            lg.Show();  
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserScreen us=new UserScreen();
            us.Show();
        }
    }
}
