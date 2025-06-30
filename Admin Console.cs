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
    public partial class Admin_Console : Form
    {
        public Admin_Console()
        {
            InitializeComponent();
            Mainfunctionbtn();
           
                
        }
        private void Mainfunctionbtn()
        {
            //button6.Enabled = false;
           // button7.Enabled = false;
           // button8.Enabled = false;
            //button9.Enabled = false;
           // button10.Enabled = false;
           // button11.Enabled = false;
            //button12.Enabled = false;
            //button13.Enabled = false;
            //button14.Enabled = false;
           // button15.Enabled = false;
           // button16.Enabled = false;
           // button17.Enabled = false;
           // button18.Enabled = false;
            //button19.Enabled = false;
            //button20.Enabled = false;
            //button21.Enabled = false;
            //button22.Enabled = false;
            //button23.Enabled = false;
            //button24.Enabled = false;
            button25.Enabled = false;
            button26.Enabled = false;
           // button27.Enabled = false;
            button28.Enabled = false;
        }
        private void show_emp_btn()
        {
         //   button6.Enabled = true;
           // button7.Enabled = true;
          //  button8.Enabled = true;
          //  button9.Enabled = true;
         //   hide_itemsadd();
            hide_memberbtn();
        }
        private void hide_emp_btn()
        {
          //  button6.Enabled = false;
           // button7.Enabled = false;
           // button8.Enabled = false;
            //button9.Enabled = false;
        }
        /*private void itemsadd()
        {
            hide_emp_btn();
            hide_memberbtn();
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            button19.Enabled = true;
            button20.Enabled = true;
            button21.Enabled = true;
            button22.Enabled = true;
            button23.Enabled = true;
            button24.Enabled = true;
        }*/
        /*private void hide_itemsadd()
        {
            button10.Enabled= false;
            button11.Enabled= false;
            button12.Enabled= false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;
            button21.Enabled = false;
            button23.Enabled = false;
            button24.Enabled = false;
        }*/
        private void memberbtn()
        {
            //hide_itemsadd();
            hide_emp_btn();
            button25.Enabled = true;
            button26.Enabled = true;
            //button27.Enabled = true;
            button28.Enabled = true;
        }
        private void hide_memberbtn()
        {
            //hide_itemsadd();
            //hide_emp_btn();
            button25.Enabled = false;
            button26.Enabled = false;
            //button27.Enabled = false;
            button28.Enabled = false;
        }
        private void Admin_Console_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // show_emp_btn();
            Screen sc = new Screen();
            sc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IteamsAdd ia=new IteamsAdd();
            ia.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            memberbtn();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button28_Click(object sender, EventArgs e)
        {
            MemberAdd memberAdd = new MemberAdd();
            memberAdd.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Reviews r=  new Reviews();  
            r.Show();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            DelAndUpdateMember ud=new DelAndUpdateMember();
            ud.Show();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Display_Data_Member d=new Display_Data_Member();
            d.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdminLogin al=new AdminLogin();
            al.Show();
            this.Dispose();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {

        }
    }
}
