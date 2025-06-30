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
    public partial class No_tables : Form
    {
        pmsDataContext db;

        public No_tables()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {

            db = new pmsDataContext();
            dataGridView1.DataSource = db.EmpInfos.Select(emp => new
            {
                emp.cnic,
                emp.Username,
                emp.fathername,

            }).ToList();

            dataGridView2.DataSource = db.EmpInfos.Select(emp => new
            {
                emp.cnic,
                emp.phone
            }).ToList();

            dataGridView3.DataSource = db.EmpInfos.Select(emp => new
            {
                emp.cnic,
                emp.post
            }).ToList();

            dataGridView4.DataSource = db.EmpInfos.Select(emp => new
            {
                emp.cnic,
                emp.adr,
                emp.pre_ext
            }).ToList();
        }


        private void No_tables_Load(object sender, EventArgs e)
        {

        }
    }
}
