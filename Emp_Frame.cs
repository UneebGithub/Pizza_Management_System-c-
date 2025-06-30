using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pizza_Management_System
{
    public partial class Emp_Frame : Form
    {
        pmsDataContext db;
        int totalAmount = 0;

        public Emp_Frame()
        {
            InitializeComponent();
        }

        private void Emp_Frame_Load(object sender, EventArgs e)
        {
            LoadPizzaData();
            LoadSpecialPizzaData();
            Chicken_sk();
            sandwishdata();
            friesdata();
            desertData();
            coffeedata();
            drinksData();
            burgerdata();
            friedck();
            pastadata();
            shakesdata();
            teadata();
            starterdata();
            beefdata();
            InitializeDataGridView();

        }
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["DeleteButton"].Index)
            {
                var price = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Price"].Value);
                dataGridView1.Rows.RemoveAt(e.RowIndex);
                totalAmount -= price;
                textBox16.Text = " " + totalAmount;
            }
        }

        private void InitializeDataGridView()
        {
            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Add("Iteam", "Iteam Name");
                dataGridView1.Columns.Add("Price", "Price");

                DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
                deleteColumn.Name = "DeleteButton";
                deleteColumn.HeaderText = "Action";
                deleteColumn.Text = "Delete";
                deleteColumn.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(deleteColumn);
            }

            dataGridView1.CellContentClick += DataGridView1_CellContentClick;
        }

        private void friesdata()
        {
            db = new pmsDataContext();
            var fries = db.fries.Select(f => f.fries_name).ToList();
            comboBox3.DataSource = fries;
        }

        private void desertData()
        {
            db = new pmsDataContext();
            var desserts = db.deserts.Select(d => d.desert_name).ToList();
            comboBox4.DataSource = desserts;
        }

        private void coffeedata()
        {
            db = new pmsDataContext();
            var coffee = db.barmenu_coffees.Select(c => c.coffee_name).ToList();
            comboBox5.DataSource = coffee;
        }

        private void drinksData()
        {
            db = new pmsDataContext();
            var drinks = db.drinks_slushes.Select(d => d.drink_name).ToList();
            comboBox6.DataSource = drinks;
        }

        private void burgerdata()
        {
            db = new pmsDataContext();
            var burgers = db.burgers.Select(b => b.burger_name).ToList();
            comboBox13.DataSource = burgers;
        }

        private void friedck()
        {
            db = new pmsDataContext();
            var friedChicken = db.fried_chickens.Select(fc => fc.fried_ck_name).ToList();
            comboBox15.DataSource = friedChicken;
        }

        private void pastadata()
        {
            db = new pmsDataContext();
            var pasta = db.pastas.Select(p => p.pasta_name).ToList();
            comboBox7.DataSource = pasta;
        }

        private void shakesdata()
        {
            db = new pmsDataContext();
            var shakes = db.shakes_and_smoothies.Select(s => s.shakes_name).ToList();
            comboBox8.DataSource = shakes;
        }

        private void teadata()
        {
            db = new pmsDataContext();
            var tea = db.Tea_menus.Select(t => t.tea_name).ToList();
            comboBox9.DataSource = tea;
        }

        private void starterdata()
        {
            db = new pmsDataContext();
            var starters = db.starters.Select(s => s.starters_name).ToList();
            comboBox10.DataSource = starters;
        }

        private void beefdata()
        {
            db = new pmsDataContext();
            var beef = db.Beef_steaks.Select(b => b.beef_steak_name).ToList();
            comboBox12.DataSource = beef;
        }

        private void sandwishdata()
        {
            db = new pmsDataContext();
            var sand=db.sandwiches.Select(cs=>cs.sandwich_name).ToList();
            comboBox14.DataSource = sand;
        }
        private void Chicken_sk()
        {
            db = new pmsDataContext();
            var chickenSteaks = db.chicken_steaks.Select(cs => cs.chicken_steak_name).ToList();
            comboBox11.DataSource = chickenSteaks;
            
        }
        private void LoadSpecialPizzaData()
        {
            db=new pmsDataContext();
            var specialpiiza=db.specialpizzamenus.Select(p=>p.pizza_name).ToList(); 
            comboBox2.DataSource = specialpiiza;
            var samplePizza = db.specialpizzamenus.FirstOrDefault();
            if (samplePizza != null)
            {
                radioButton4.Text = samplePizza.medium_size.ToString();
                radioButton5.Text=samplePizza.large_size.ToString();
            }

        }
        private void LoadPizzaData()
        {
            db = new pmsDataContext();

            var pizzaNames = db.pizzamenus.Select(p => p.pizza_name).ToList();

            comboBox1.DataSource = pizzaNames;

            var samplePizza = db.pizzamenus.FirstOrDefault();

            if (samplePizza != null)
            {
                radioButton1.Text = samplePizza.small_size.ToString();
                radioButton2.Text = samplePizza.medium_size.ToString();
                radioButton3.Text = samplePizza.large_size.ToString()   ;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null && (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked))
            {
                string selectedPizza = comboBox1.SelectedItem.ToString();
                string selectedSize = "";

                int price = 0;  
                var pizza = db.pizzamenus.FirstOrDefault(p => p.pizza_name == selectedPizza);

                if (pizza != null)
                {
                    if (radioButton1.Checked)
                    {
                        selectedSize = radioButton1.Text;
                        price = pizza.small_size;  
                    }
                    else if (radioButton2.Checked)
                    {
                        selectedSize = radioButton2.Text;
                        price = pizza.medium_size; 
                    }
                    else if (radioButton3.Checked)
                    {
                        selectedSize = radioButton3.Text;
                        price = pizza.large_size;  
                    }

                    dataGridView1.Rows.Add(selectedPizza, price);
                    totalAmount += price;

                    textBox16.Text = " "+totalAmount;
                }
            }
            else
            {
                MessageBox.Show("Please select a pizza and size.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null && (radioButton4.Checked || radioButton5.Checked ))
            {
                string selectedPizza = comboBox2.SelectedItem.ToString();
                string selectedSize = "";

                int price = 0;
                var pizza = db.specialpizzamenus.FirstOrDefault(p => p.pizza_name == selectedPizza);

                if (pizza != null)
                {
                    if (radioButton4.Checked)
                    {
                        selectedSize = radioButton4.Text;
                        price = pizza.medium_size;
                    }
                    else if (radioButton5.Checked)
                    {
                        selectedSize = radioButton5.Text;
                        price = pizza.large_size;
                    }
                   

                    dataGridView1.Rows.Add(selectedPizza, price);
                    totalAmount += price;

                    textBox16.Text = " " + totalAmount;
                }
            }
            else
            {
                MessageBox.Show("Please select a pizza and size.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            db = new pmsDataContext();

            
            var selectedChickenSteak = db.chicken_steaks.FirstOrDefault(cs => cs.chicken_steak_name == comboBox11.Text);

            if (selectedChickenSteak != null)
            {

                dataGridView1.Rows.Add(selectedChickenSteak.chicken_steak_name, selectedChickenSteak.price);

                totalAmount += selectedChickenSteak.price;

                textBox16.Text = " "+totalAmount;
            }
            else
            {
                MessageBox.Show("Please select a valid chicken steak.");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            db = new pmsDataContext();


            var Sand = db.sandwiches.FirstOrDefault(cs => cs.sandwich_name == comboBox14.Text);

            if (Sand != null)
            {

                dataGridView1.Rows.Add(Sand.sandwich_name, Sand.price);

                totalAmount += Sand.price;

                textBox16.Text = " " + totalAmount;
            }
            else
            {
                MessageBox.Show("Please select a valid SandWish.");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            db = new pmsDataContext();


            var check = db.fries.FirstOrDefault(cs => cs.fries_name == comboBox3.Text);

            if (check != null)
            {

                dataGridView1.Rows.Add(check.fries_name, check.price);

                totalAmount += check.price;

                textBox16.Text = " " + totalAmount;
            }
            else
            {
                MessageBox.Show("Please select a valid Fries.");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            db = new pmsDataContext();


            var check = db.deserts.FirstOrDefault(cs => cs.desert_name == comboBox4.Text);

            if (check != null)
            {

                dataGridView1.Rows.Add(check.desert_name, check.price);

                totalAmount += check.price;

                textBox16.Text = " " + totalAmount;
            }
            else
            {
                MessageBox.Show("Please select a valid Desert.");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            db = new pmsDataContext();


            var check = db.barmenu_coffees.FirstOrDefault(cs => cs.coffee_name == comboBox5.Text);

            if (check != null)
            {

                dataGridView1.Rows.Add(check.coffee_name, check.price);

                totalAmount += check.price;

                textBox16.Text = " " + totalAmount;
            }
            else
            {
                MessageBox.Show("Please select a valid Item.");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            db = new pmsDataContext();


            var check = db.drinks_slushes.FirstOrDefault(cs => cs.drink_name == comboBox6.Text);

            if (check != null)
            {

                dataGridView1.Rows.Add(check.drink_name, check.price);

                totalAmount += check.price;

                textBox16.Text = " " + totalAmount;
            }
            else
            {
                MessageBox.Show("Please select a valid Item.");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            db = new pmsDataContext();


            var check = db.burgers.FirstOrDefault(cs => cs.burger_name == comboBox13.Text);

            if (check != null)
            {

                dataGridView1.Rows.Add(check.burger_name, check.price);

                totalAmount += check.price;

                textBox16.Text = " " + totalAmount;
            }
            else
            {
                MessageBox.Show("Please select a valid Item.");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            db = new pmsDataContext();


            var check = db.fried_chickens.FirstOrDefault(cs => cs.fried_ck_name == comboBox15.Text);

            if (check != null)
            {

                dataGridView1.Rows.Add(check.fried_ck_name, check.price);

                totalAmount += check.price;

                textBox16.Text = " " + totalAmount;
            }
            else
            {
                MessageBox.Show("Please select a valid Item.");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            db = new pmsDataContext();


            var check = db.pastas.FirstOrDefault(cs => cs.pasta_name == comboBox7.Text);

            if (check != null)
            {

                dataGridView1.Rows.Add(check.pasta_name, check.price);

                totalAmount += check.price;

                textBox16.Text = " " + totalAmount;
            }
            else
            {
                MessageBox.Show("Please select a valid Item.");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            db = new pmsDataContext();


            var check = db.shakes_and_smoothies.FirstOrDefault(cs => cs.shakes_name == comboBox9.Text);

            if (check != null)
            {

                dataGridView1.Rows.Add(check.shakes_name, check.price);

                totalAmount += check.price;

                textBox16.Text = " " + totalAmount;
            }
            else
            {
                MessageBox.Show("Please select a valid Item.");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            db = new pmsDataContext();


            var check = db.Tea_menus.FirstOrDefault(cs => cs.tea_name== comboBox9.Text);

            if (check != null)
            {

                dataGridView1.Rows.Add(check.tea_name, check.price);

                totalAmount += check.price;

                textBox16.Text = " " + totalAmount;
            }
            else
            {
                MessageBox.Show("Please select a valid Item.");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            db = new pmsDataContext();


            var check = db.starters.FirstOrDefault(cs => cs.starters_name== comboBox10.Text);

            if (check != null)
            {

                dataGridView1.Rows.Add(check.starters_name, check.price);

                totalAmount += check.price;

                textBox16.Text = " " + totalAmount;
            }
            else
            {
                MessageBox.Show("Please select a valid Item.");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            db = new pmsDataContext();


            var check = db.Beef_steaks.FirstOrDefault(cs => cs.beef_steak_name == comboBox12.Text);

            if (check != null)
            {

                dataGridView1.Rows.Add(check.beef_steak_name, check.price);

                totalAmount += check.price;

                textBox16.Text = " " + totalAmount;
            }
            else
            {
                MessageBox.Show("Please select a valid Item.");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            MemberAdd m=new MemberAdd();
            m.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int price = Convert.ToInt32(textBox1.Text);
            var show_return_amount = price-totalAmount ;
            MessageBox.Show(" " + show_return_amount);
            //textBox2.Text= show_return_amount.ToString();
            
        
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
    }

