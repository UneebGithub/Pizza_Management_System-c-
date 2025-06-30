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
    public partial class MemberAdd : Form
    {
        public MemberAdd()
        {
            InitializeComponent();
        }
        private void clear()
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";    
        }
        pmsDataContext db;
        private void button2_Click(object sender, EventArgs e)
        {
            db = new pmsDataContext();
            try
            {
                 
               var phone=Convert.ToInt64(textBox2.Text);
                var name=textBox3.Text;
                var adr=textBox4.Text;
                MembersInfo mi=new MembersInfo();
                mi.phone = phone;
                mi.adr = adr;
                mi.Username = name;

                db.MembersInfos.InsertOnSubmit(mi);
                db.SubmitChanges();
                MessageBox.Show("Data Add Successfully");
                clear();



            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               var search=Convert.ToInt64(textBox1.Text);

                var check=from ck in db.MembersInfos
                          where ck.phone == search
                          select ck;

                if (check.Any()) {
                    dataGridView1.DataSource = check.ToList();
                    clear();

                }
                else
                {
                    MessageBox.Show("User Not Found :( ");
                    clear() ;
                }
            }
            catch (Exception ex) { }
        }

        private void MemberAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
