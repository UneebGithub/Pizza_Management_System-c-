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
    public partial class Reviews : Form
    {
        public Reviews()
        {
            InitializeComponent();
        }
        pmsDataContext db;
        private void Reviews_Load(object sender, EventArgs e)
        {
            db=new pmsDataContext();

            var c = from t in db.User_Reviews select t;
            if (c.Any()) { 
            
            dataGridView1.DataSource = c.ToList();
            }
        }
    }
}
