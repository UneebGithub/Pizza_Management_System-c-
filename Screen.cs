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
    public partial class Screen : Form
    {
        public Screen()
        {
            InitializeComponent();
        }

        private void Screen_Load(object sender, EventArgs e)
        {

        }
        pmsDataContext db;
        private void button1_Click(object sender, EventArgs e)
        {
            db=new pmsDataContext();
            var name = textBox1.Text;
            var fathername = textBox2.Text;  
            var cnic = Convert.ToInt64(textBox3.Text);        
            var phone = Convert.ToInt32(textBox4.Text);       
            var post = textBox5.Text;        
            var preExt = textBox6.Text;      
            var adr = textBox7.Text;         

            
            EmpInfo newEmpInfo = new EmpInfo
            {
                Username = name,
                fathername = fathername,
                cnic = cnic,
                phone = phone,
                post = post,
                pre_ext = preExt,
                adr = adr
            };


            db.EmpInfos.InsertOnSubmit(newEmpInfo);


            db.SubmitChanges();


            MessageBox.Show("New record added successfully.");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                db = new pmsDataContext();
                long search = Convert.ToInt64(textBox8.Text);

                var searchResults = from emp in db.EmpInfos
                                    where emp.cnic.ToString().Contains(search.ToString())
                                    select new
                                    {
                                        emp.Username,
                                        emp.fathername,
                                        emp.cnic,
                                        emp.phone,
                                        emp.post,
                                        emp.pre_ext,
                                        emp.adr
                                    };

                dataGridView1.DataSource = searchResults.ToList();
            }
            catch (Exception ex) { 
            }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                db = new pmsDataContext();
                long search = Convert.ToInt64(textBox8.Text);

                
                var empToUpdate = db.EmpInfos.FirstOrDefault(emp => emp.cnic == search);

                if (empToUpdate != null)
                {
                    
                    empToUpdate.Username = textBox1.Text;
                    empToUpdate.fathername = textBox2.Text;
                    empToUpdate.phone = Convert.ToInt32(textBox4.Text);
                    empToUpdate.post = textBox5.Text;
                    empToUpdate.pre_ext = textBox6.Text;
                    empToUpdate.adr = textBox7.Text;

                    
                    db.SubmitChanges();
                    MessageBox.Show("Record updated successfully.");
                }
                else
                {
                    MessageBox.Show("Record not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                db = new pmsDataContext();
                long search = Convert.ToInt64(textBox8.Text);

             
                var empToDelete = db.EmpInfos.FirstOrDefault(emp => emp.cnic == search);

                if (empToDelete != null)
                {
             
                    db.EmpInfos.DeleteOnSubmit(empToDelete);

             
                    db.SubmitChanges();
                    MessageBox.Show("Record deleted successfully.");
                }
                else
                {
                    MessageBox.Show("Record not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            No_tables no_Tables = new No_tables();
             no_Tables.ShowDialog();
        }
    }
}
