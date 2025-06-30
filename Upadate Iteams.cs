using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Management_System
{
    public partial class Upadate_Iteams : Form
    {
        public Upadate_Iteams()
        {
            InitializeComponent();
            comboBox2.Items.Add("Pizza");
            comboBox2.Items.Add("Special Pizza");
            comboBox2.Items.Add("Chicken Steak");
            comboBox2.Items.Add("SandWish");
            comboBox2.Items.Add("Fries");
            comboBox2.Items.Add("Desert");
            comboBox2.Items.Add("Coffee");
            comboBox2.Items.Add("Drinks");
            comboBox2.Items.Add("Burger");
            comboBox2.Items.Add("Fried Chicken");
            comboBox2.Items.Add("Pasta");
            comboBox2.Items.Add("Shakes");
            comboBox2.Items.Add("Tea");
            comboBox2.Items.Add("Starter");
            comboBox2.Items.Add("Beef");
            // check_table(comboBox2.SelectedIndex);

        }
        private void check_table(int selected_index)
        {




        }

        private void Upadate_Iteams_Load(object sender, EventArgs e)
        {

        }
        pmsDataContext db;
        private void button13_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // var selectedMenu = comboBox2.SelectedItem?.ToString();
                if (comboBox2.SelectedIndex == 0)
                {
                    var pizzaMenu = db.pizzamenus.FirstOrDefault(p => p.id == int.Parse(textBox1.Text));
                    if (pizzaMenu != null)
                    {
                        pizzaMenu.pizza_name = textBox2.Text;
                        if (comboBox1.SelectedIndex == 0)
                        {
                            pizzaMenu.small_size = Convert.ToInt32(textBox3.Text);
                        }
                        else if (comboBox1.SelectedIndex == 1)
                        {
                            pizzaMenu.medium_size = Convert.ToInt32(textBox3.Text);
                        }
                        else if (comboBox1.SelectedIndex == 2)
                        {
                            pizzaMenu.large_size = Convert.ToInt32(textBox3.Text);
                        }

                        db.SubmitChanges();
                        MessageBox.Show("Item updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Item not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                    if (comboBox1.SelectedIndex == 1)
                    {
                        var pizzaMenu1 = db.specialpizzamenus.FirstOrDefault(p => p.id == int.Parse(textBox1.Text));
                        if (pizzaMenu1 != null)
                        {
                            pizzaMenu1.pizza_name = textBox2.Text;
                            if (comboBox1.SelectedIndex == 0)
                            {
                                pizzaMenu1.medium_size = Convert.ToInt32(textBox3.Text);
                            }
                            else if (comboBox1.SelectedIndex == 1)
                            {
                                pizzaMenu1.large_size = Convert.ToInt32(textBox3.Text);
                            }


                            db.SubmitChanges();
                            MessageBox.Show("Item updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                    else if (comboBox2.SelectedIndex == 2) // Chicken Steak
                    {
                        var chickenSteak = db.chicken_steaks.FirstOrDefault(p => p.id == int.Parse(textBox1.Text));
                        if (chickenSteak != null)
                        {
                            chickenSteak.chicken_steak_name = textBox2.Text;
                            chickenSteak.price = Convert.ToInt32(textBox3.Text);

                            db.SubmitChanges();
                            MessageBox.Show("Chicken Steak item updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Chicken Steak item not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (comboBox2.SelectedIndex == 3) // Sandwich
                    {
                        var sandwich = db.sandwiches.FirstOrDefault(p => p.id == int.Parse(textBox1.Text));
                        if (sandwich != null)
                        {
                            sandwich.sandwich_name = textBox2.Text;
                            sandwich.price = Convert.ToInt32(textBox3.Text);

                            db.SubmitChanges();
                            MessageBox.Show("Sandwich item updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Sandwich item not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    else if (comboBox2.SelectedIndex == 4) // Fries
                    {
                        var fries = db.fries.FirstOrDefault(p => p.id == int.Parse(textBox1.Text));
                        if (fries != null)
                        {
                            fries.fries_name = textBox2.Text;
                            fries.price = Convert.ToInt32(textBox3.Text);

                            db.SubmitChanges();
                            MessageBox.Show("Fries item updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Fries item not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    else if (comboBox2.SelectedIndex == 5) // Deserts
                    {
                        var desert = db.deserts.FirstOrDefault(p => p.id == int.Parse(textBox1.Text));
                        if (desert != null)
                        {
                            desert.desert_name = textBox2.Text;
                            desert.price = Convert.ToInt32(textBox3.Text);

                            db.SubmitChanges();
                            MessageBox.Show("Desert item updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Desert item not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (comboBox2.SelectedIndex == 6) // Coffee
                    {
                        var coffee = db.barmenu_coffees.FirstOrDefault(p => p.id == int.Parse(textBox1.Text));
                        if (coffee != null)
                        {
                            coffee.coffee_name = textBox2.Text;
                            coffee.price = Convert.ToInt32(textBox3.Text);

                            db.SubmitChanges();
                            MessageBox.Show("Coffee item updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Coffee item not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (comboBox2.SelectedIndex == 7) // Drinks
                    {
                        var drink = db.drinks_slushes.FirstOrDefault(p => p.id == int.Parse(textBox1.Text));
                        if (drink != null)
                        {
                            drink.drink_name = textBox2.Text;
                            drink.price = Convert.ToInt32(textBox3.Text);

                            db.SubmitChanges();
                            MessageBox.Show("Drink item updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Drink item not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (comboBox2.SelectedIndex == 8) // Burgers
                    {
                        var burger = db.burgers.FirstOrDefault(p => p.id == int.Parse(textBox1.Text));
                        if (burger != null)
                        {
                            burger.burger_name = textBox2.Text;
                            burger.price = Convert.ToInt32(textBox3.Text);

                            db.SubmitChanges();
                            MessageBox.Show("Burger item updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Burger item not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (comboBox2.SelectedIndex == 10) // Pasta
                    {
                        var pasta = db.pastas.FirstOrDefault(p => p.id == int.Parse(textBox1.Text));
                        if (pasta != null)
                        {
                            pasta.pasta_name = textBox2.Text;
                            pasta.price = Convert.ToInt32(textBox3.Text);

                            db.SubmitChanges();
                            MessageBox.Show("Pasta item updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Pasta item not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (comboBox2.SelectedIndex == 9)
                    {
                        var salad = db.fried_chickens.FirstOrDefault(p => p.id == int.Parse(textBox1.Text));
                        if (salad != null)
                        {
                            salad.fried_ck_name = textBox2.Text;
                            salad.price = Convert.ToInt32(textBox3.Text);

                            db.SubmitChanges();
                            MessageBox.Show("Salad item updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Salad item not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (comboBox2.SelectedIndex == 11) // Shakes
                    {
                        var soup = db.shakes_and_smoothies.FirstOrDefault(p => p.id == int.Parse(textBox1.Text));
                        if (soup != null)
                        {
                            soup.shakes_name = textBox2.Text;
                            soup.price = Convert.ToInt32(textBox3.Text);

                            db.SubmitChanges();
                            MessageBox.Show(" item updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(" item not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (comboBox2.SelectedIndex == 12) // tea
                    {
                        var tea = db.Tea_menus.FirstOrDefault(p => p.id == int.Parse(textBox1.Text));
                        if (tea != null)
                        {
                            tea.tea_name = textBox2.Text;
                            tea.price = Convert.ToInt32(textBox3.Text);

                            db.SubmitChanges();
                            MessageBox.Show("Ice Cream item updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Ice Cream item not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (comboBox2.SelectedIndex == 13) // starter
                    {
                        var str = db.starters.FirstOrDefault(p => p.id == int.Parse(textBox1.Text));
                        if (str != null)
                        {
                            str.starters_name = textBox2.Text;
                            str.price = Convert.ToInt32(textBox3.Text);

                            db.SubmitChanges();
                            MessageBox.Show("item updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(" item not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (comboBox2.SelectedIndex == 14) // beef
                    {
                        var beef = db.Beef_steaks.FirstOrDefault(p => p.id == int.Parse(textBox1.Text));
                        if (beef != null)
                        {
                            beef.beef_steak_name = textBox2.Text;
                            beef.price = Convert.ToInt32(textBox3.Text);

                            db.SubmitChanges();
                            MessageBox.Show(" item updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    
                }
            }
            catch (Exception ex)
            {

            }
        }
            

        private void button3_Click(object sender, EventArgs e)
        {
            db = new pmsDataContext();
            if (comboBox2.SelectedIndex == 0)
            {
                var pizzaMenus = db.pizzamenus.ToList();
                if (pizzaMenus.Any())
                {
                    dataGridView1.DataSource = pizzaMenus;
                }
                var pizzaMenu = db.pizzamenus.FirstOrDefault();
                if (pizzaMenu != null)
                {
                    textBox1.Text = pizzaMenu.id.ToString();
                    textBox2.Text = pizzaMenu.pizza_name;
                    comboBox1.Items.Add(" Small " + pizzaMenu.small_size);
                    comboBox1.Items.Add("Medium " + pizzaMenu.medium_size);
                    comboBox1.Items.Add("Large" + pizzaMenu.large_size);

                    if (comboBox1.SelectedIndex == 0)
                    {
                        textBox3.Text = pizzaMenu.small_size.ToString();
                    }
                    else if (comboBox1.SelectedIndex == 1)
                    {
                        textBox3.Text = pizzaMenu.medium_size.ToString();
                    }
                    else if (comboBox1.SelectedIndex == 2)
                    {
                        textBox3.Text = pizzaMenu.large_size.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("No pizza data found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //for special pizza menu
            if (comboBox2.SelectedIndex == 1)
            {
                var pizzaMenus1 = db.specialpizzamenus.ToList();
                if (pizzaMenus1.Any())
                {
                    dataGridView1.DataSource = pizzaMenus1;
                }
                var pizzaMenuu = db.specialpizzamenus.FirstOrDefault();
                if (pizzaMenuu != null)
                {
                    textBox1.Text = pizzaMenuu.id.ToString();
                    textBox2.Text = pizzaMenuu.pizza_name;
                    //   comboBox1.Items.Add(" Small " + pizzaMenu.small_size);
                    comboBox1.Items.Add("Medium " + pizzaMenuu.medium_size);
                    comboBox1.Items.Add("Large" + pizzaMenuu.large_size);

                    if (comboBox1.SelectedIndex == 0)
                    {
                        //textBox3.Text = pizzaMenu.small_size.ToString();
                    }
                    else if (comboBox1.SelectedIndex == 1)
                    {
                        textBox3.Text = pizzaMenuu.medium_size.ToString();
                    }
                    else if (comboBox1.SelectedIndex == 2)
                    {
                        textBox3.Text = pizzaMenuu.large_size.ToString();
                    }
                }
            }
            if (comboBox2.SelectedIndex == 2)
            {
                chicken_steak f = new chicken_steak();
                var fd = db.chicken_steaks.ToList();
                if (fd.Any())
                {
                    dataGridView1.DataSource = fd;

                }
                var ck = db.chicken_steaks.FirstOrDefault();
                if (ck != null)
                {
                    textBox1.Text = ck.id.ToString();
                    textBox2.Text = ck.chicken_steak_name;
                    textBox3.Text = ck.price.ToString();

                }
            }


            if (comboBox2.SelectedIndex == 3)
            {
                sandwich f = new sandwich();
                var fd = db.sandwiches.ToList();
                if (fd.Any())
                {
                    dataGridView1.DataSource = fd;

                }
                var ck = db.sandwiches.FirstOrDefault();
                if (ck != null)
                {
                    textBox1.Text = ck.id.ToString();
                    textBox2.Text = ck.sandwich_name;
                    textBox3.Text = ck.price.ToString();

                }
            }


            if (comboBox2.SelectedIndex == 4)
            {
                fry f = new fry();
                var fd = db.fries.ToList();
                if (fd.Any())
                {
                    dataGridView1.DataSource = fd;

                }
                var ck = db.fries.FirstOrDefault();
                if (ck != null)
                {
                    textBox1.Text = ck.id.ToString();
                    textBox2.Text = ck.fries_name;
                    textBox3.Text = ck.price.ToString();

                }
            }


            if (comboBox2.SelectedIndex == 5)
            {
                desert f = new desert();
                var fd = db.deserts.ToList();
                if (fd.Any())
                {
                    dataGridView1.DataSource = fd;

                }
                var ck = db.deserts.FirstOrDefault();
                if (ck != null)
                {
                    textBox1.Text = ck.id.ToString();
                    textBox2.Text = ck.desert_name;
                    textBox3.Text = ck.price.ToString();

                }
            }



            if (comboBox2.SelectedIndex == 6)
            {
                barmenu_coffee f = new barmenu_coffee();
                var fd = db.barmenu_coffees.ToList();
                if (fd.Any())
                {
                    dataGridView1.DataSource = fd;

                }
                var ck = db.barmenu_coffees.FirstOrDefault();
                if (ck != null)
                {
                    textBox1.Text = ck.id.ToString();
                    textBox2.Text = ck.coffee_name;
                    textBox3.Text = ck.price.ToString();

                }
            }

            if (comboBox2.SelectedIndex == 7)
            {
                drinks_slush f = new drinks_slush();
                var fd = db.drinks_slushes.ToList();
                if (fd.Any())
                {
                    dataGridView1.DataSource = fd;

                }
                var ck = db.drinks_slushes.FirstOrDefault();
                if (ck != null)
                {
                    textBox1.Text = ck.id.ToString();
                    textBox2.Text = ck.drink_name;
                    textBox3.Text = ck.price.ToString();

                }

            }

            if (comboBox2.SelectedIndex == 8)
            {
                burger f = new burger();
                var fd = db.burgers.ToList();
                if (fd.Any())
                {
                    dataGridView1.DataSource = fd;

                }
                var ck = db.burgers.FirstOrDefault();
                if (ck != null)
                {
                    textBox1.Text = ck.id.ToString();
                    textBox2.Text = ck.burger_name;
                    textBox3.Text = ck.price.ToString();

                }
            }

            if (comboBox2.SelectedIndex == 9)
            {
                fried_chicken f = new fried_chicken();
                var fd = db.fried_chickens.ToList();
                if (fd.Any())
                {
                    dataGridView1.DataSource = fd;

                }
                var ck = db.fried_chickens.FirstOrDefault();
                if (ck != null)
                {
                    textBox1.Text = ck.id.ToString();
                    textBox2.Text = ck.fried_ck_name;
                    textBox3.Text = ck.price.ToString();

                }
            }

            if (comboBox2.SelectedIndex == 10)
            {
                pasta f = new pasta();
                var fd = db.pastas.ToList();
                if (fd.Any())
                {
                    dataGridView1.DataSource = fd;

                }
                var ck = db.pastas.FirstOrDefault();
                if (ck != null)
                {
                    textBox1.Text = ck.id.ToString();
                    textBox2.Text = ck.pasta_name;
                    textBox3.Text = ck.price.ToString();

                }
            }



            if (comboBox2.SelectedIndex == 11)
            {
                shakes_and_smoothy f = new shakes_and_smoothy();
                var fd = db.shakes_and_smoothies.ToList();
                if (fd.Any())
                {
                    dataGridView1.DataSource = fd;

                }
                var ck = db.shakes_and_smoothies.FirstOrDefault();
                if (ck != null)
                {
                    textBox1.Text = ck.id.ToString();
                    textBox2.Text = ck.shakes_name;
                    textBox3.Text = ck.price.ToString();

                }
            }

            if (comboBox2.SelectedIndex == 12)
            {
                Tea_menu f = new Tea_menu();
                var fd = db.Tea_menus.ToList();
                if (fd.Any())
                {
                    dataGridView1.DataSource = fd;

                }
                var ck = db.Tea_menus.FirstOrDefault();
                if (ck != null)
                {
                    textBox1.Text = ck.id.ToString();
                    textBox2.Text = ck.tea_name;
                    textBox3.Text = ck.price.ToString();

                }
            }


            if (comboBox2.SelectedIndex == 13)
            {
                starter f = new starter();
                var fd = db.starters.ToList();
                if (fd.Any())
                {
                    dataGridView1.DataSource = fd;

                }
                var ck = db.starters.FirstOrDefault();
                if (ck != null)
                {
                    textBox1.Text = ck.id.ToString();
                    textBox2.Text = ck.starters_name;
                    textBox3.Text = ck.price.ToString();

                }
            }



            if (comboBox2.SelectedIndex == 14)
            {
                Beef_steak f = new Beef_steak();
                var fd = db.Beef_steaks.ToList();
                if (fd.Any())
                {
                    dataGridView1.DataSource = fd;

                }
                var ck = db.Beef_steaks.FirstOrDefault();
                if (ck != null)
                {
                    textBox1.Text = ck.id.ToString();
                    textBox2.Text = ck.beef_steak_name;
                    textBox3.Text = ck.price.ToString();

                }
            }

            
         
            


        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (comboBox2.SelectedIndex == 0) // Pizza Menu
                {
                    var pizzaMenu = db.pizzamenus.FirstOrDefault(p => p.id == int.Parse(textBox1.Text));
                    if (pizzaMenu != null)
                    {
                        db.pizzamenus.DeleteOnSubmit(pizzaMenu);
                        db.SubmitChanges();
                        MessageBox.Show("Pizza item deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Pizza item not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (comboBox2.SelectedIndex == 1) // Special Pizza Menu
                {
                    var specialPizza = db.specialpizzamenus.FirstOrDefault(p => p.id == int.Parse(textBox1.Text));
                    if (specialPizza != null)
                    {
                        db.specialpizzamenus.DeleteOnSubmit(specialPizza);
                        db.SubmitChanges();
                        MessageBox.Show("Special Pizza item deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Special Pizza item not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (comboBox2.SelectedIndex == 2) // Chicken Steak
                {
                    var chickenSteak = db.chicken_steaks.FirstOrDefault(p => p.id == int.Parse(textBox1.Text));
                    if (chickenSteak != null)
                    {
                        db.chicken_steaks.DeleteOnSubmit(chickenSteak);
                        db.SubmitChanges();
                        MessageBox.Show("Chicken Steak item deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Chicken Steak item not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (comboBox2.SelectedIndex == 3) // Sandwich
                {
                    var sandwich = db.sandwiches.FirstOrDefault(p => p.id == int.Parse(textBox1.Text));
                    if (sandwich != null)
                    {
                        db.sandwiches.DeleteOnSubmit(sandwich);
                        db.SubmitChanges();
                        MessageBox.Show("Sandwich item deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Sandwich item not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (comboBox2.SelectedIndex == 4) // Fries
                {
                    var fries = db.fries.FirstOrDefault(p => p.id == int.Parse(textBox1.Text));
                    if (fries != null)
                    {
                        db.fries.DeleteOnSubmit(fries);
                        db.SubmitChanges();
                        MessageBox.Show("Fries item deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Fries item not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (comboBox2.SelectedIndex == 5) // Deserts
                {
                    var desert = db.deserts.FirstOrDefault(p => p.id == int.Parse(textBox1.Text));
                    if (desert != null)
                    {
                        db.deserts.DeleteOnSubmit(desert);
                        db.SubmitChanges();
                        MessageBox.Show("Desert item deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Desert item not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (comboBox2.SelectedIndex == 6) // Coffee
                {
                    var coffee = db.barmenu_coffees.FirstOrDefault(p => p.id == int.Parse(textBox1.Text));
                    if (coffee != null)
                    {
                        db.barmenu_coffees.DeleteOnSubmit(coffee);
                        db.SubmitChanges();
                        MessageBox.Show("Coffee item deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Coffee item not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (comboBox2.SelectedIndex == 7) // Drinks
                {
                    var drink = db.drinks_slushes.FirstOrDefault(p => p.id == int.Parse(textBox1.Text));
                    if (drink != null)
                    {
                        db.drinks_slushes.DeleteOnSubmit(drink);
                        db.SubmitChanges();
                        MessageBox.Show("Drink item deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Drink item not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (comboBox2.SelectedIndex == 8) // Burgers
                {
                    var burger = db.burgers.FirstOrDefault(p => p.id == int.Parse(textBox1.Text));
                    if (burger != null)
                    {
                        db.burgers.DeleteOnSubmit(burger);
                        db.SubmitChanges();
                        MessageBox.Show("Burger item deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Burger item not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (comboBox2.SelectedIndex == 9) // Fried Chicken
                {
                    var friedChicken = db.fried_chickens.FirstOrDefault(p => p.id == int.Parse(textBox1.Text));
                    if (friedChicken != null)
                    {
                        db.fried_chickens.DeleteOnSubmit(friedChicken);
                        db.SubmitChanges();
                        MessageBox.Show("Fried Chicken item deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Fried Chicken item not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (comboBox2.SelectedIndex == 10) // Pasta
                {
                    var pasta = db.pastas.FirstOrDefault(p => p.id == int.Parse(textBox1.Text));
                    if (pasta != null)
                    {
                        db.pastas.DeleteOnSubmit(pasta);
                        db.SubmitChanges();
                        MessageBox.Show("Pasta item deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Pasta item not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (comboBox2.SelectedIndex == 11) // Shakes
                {
                    var shake = db.shakes_and_smoothies.FirstOrDefault(p => p.id == int.Parse(textBox1.Text));
                    if (shake != null)
                    {
                        db.shakes_and_smoothies.DeleteOnSubmit(shake);
                        db.SubmitChanges();
                        MessageBox.Show("Shake item deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Shake item not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (comboBox2.SelectedIndex == 12) // Tea
                {
                    var tea = db.Tea_menus.FirstOrDefault(p => p.id == int.Parse(textBox1.Text));
                    if (tea != null)
                    {
                        db.Tea_menus.DeleteOnSubmit(tea);
                        db.SubmitChanges();
                        MessageBox.Show("Tea item deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Tea item not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (comboBox2.SelectedIndex == 13) // Starter
                {
                    var starter = db.starters.FirstOrDefault(p => p.id == int.Parse(textBox1.Text));
                    if (starter != null)
                    {
                        db.starters.DeleteOnSubmit(starter);
                        db.SubmitChanges();
                        MessageBox.Show("Starter item deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Starter item not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (comboBox2.SelectedIndex == 14) // Beef
                {
                    var beef = db.Beef_steaks.FirstOrDefault(p => p.id == int.Parse(textBox1.Text));
                    if (beef != null)
                    {
                        db.Beef_steaks.DeleteOnSubmit(beef);
                        db.SubmitChanges();
                        MessageBox.Show("Beef item deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Beef item not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
