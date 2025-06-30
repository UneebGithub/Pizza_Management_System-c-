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
    public partial class UserScreen : Form
    {
        public UserScreen()
        {
            InitializeComponent();
        }
        pmsDataContext db;
        private void button1_Click(object sender, EventArgs e)
        {
            db=new pmsDataContext();
            try
            {
                var id = Convert.ToInt32(textBox1.Text);
                var name=textBox2.Text;
                var phone=Convert.ToInt64(textBox3.Text);   
                var feedback=textBox4.Text;
                User_Review unb=new User_Review();
                unb.id = id;
                unb.name = name;    
                unb.phone = phone;
                unb.review_panel=feedback;

                db.User_Reviews.InsertOnSubmit(unb);
                db.SubmitChanges();
                MessageBox.Show("Thank you for sharing your wonderful reviews! 😊 \nYour feedback means a lot to us and helps us improve our application.\n We truly appreciate your support!");
                textBox2.Text = " ";
                textBox3.Text = " ";
                textBox4.Text = " ";
                
                textBox1.Text=" " ;

            }
            catch (Exception ex) {

                MessageBox.Show(ex.ToString());
            }

        }
    }
}
