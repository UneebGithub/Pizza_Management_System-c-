using System;
using System.Linq;
using System.Windows.Forms;

namespace Pizza_Management_System
{
    public partial class DelAndUpdateMember : Form
    {
        public DelAndUpdateMember()
        {
            InitializeComponent();
        }

        pmsDataContext db;

        private void button3_Click(object sender, EventArgs e)
        {
            db = new pmsDataContext();
            try
            {
                var search = Convert.ToInt64(textBox1.Text);
                var check = from ck in db.MembersInfos
                            where ck.phone == search
                            select ck;

                if (check.Any())
                {
                    dataGridView1.DataSource = check.ToList();
                }
                else
                {
                    MessageBox.Show("User Not Found :(");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                db = new pmsDataContext();
                var phone = Convert.ToInt64(textBox2.Text);
                var member = db.MembersInfos.FirstOrDefault(m => m.phone == phone);

                if (member != null)
                {
                    member.Username = textBox3.Text;
                    member.adr = textBox4.Text;

                    db.SubmitChanges();
                    MessageBox.Show("Data Updated Successfully");

                    var updatedData = from ck in db.MembersInfos
                                      where ck.phone == phone
                                      select ck;
                    dataGridView1.DataSource = updatedData.ToList();
                }
                else
                {
                    MessageBox.Show("Member not found for updating.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                db = new pmsDataContext();
                var phone = Convert.ToInt64(textBox1.Text);

                var member = db.MembersInfos.FirstOrDefault(m => m.phone == phone);

                if (member != null)
                {
                    db.MembersInfos.DeleteOnSubmit(member);
                    db.SubmitChanges();

                    MessageBox.Show("Data Deleted Successfully");

                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();

                    var allMembers = from ck in db.MembersInfos
                                     select ck;
                    dataGridView1.DataSource = allMembers.ToList();
                }
                else
                {
                    MessageBox.Show("Member not found for deletion.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void DelAndUpdateMember_Load(object sender, EventArgs e)
        {

        }
    }
}
