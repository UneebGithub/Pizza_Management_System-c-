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
    public partial class Display_Data_Member : Form
    {
        public Display_Data_Member()
        {
            InitializeComponent();
        }
        pmsDataContext db;
        private void Display_Data_Member_Load(object sender, EventArgs e)
        {
            db = new pmsDataContext();
            var members = from m in db.MembersInfos
                          select m;

            dataGridView1.DataSource = members.ToList();
        }
    }
}
