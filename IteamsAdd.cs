using System;
using System.Linq;
using System.Windows.Forms;

namespace Pizza_Management_System
{
    public partial class IteamsAdd : Form
    {
        public IteamsAdd()
        {
            InitializeComponent();
            comboBox1.Items.Add("Small");
            comboBox1.Items.Add("Medium");
            comboBox1.Items.Add("Large");
        }

        private void IteamsAdd_Load(object sender, EventArgs e)
        {
            // Code for loading if needed.
        }

        pmsDataContext db;

        private void button13_Click(object sender, EventArgs e)
        {
            db = new pmsDataContext();
            try
            {
                var id = Convert.ToInt32(textBox1.Text);
                var name = textBox2.Text;
                var basePrice = Convert.ToInt32(textBox3.Text); 

                string size = comboBox1.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(size))
                {
                    MessageBox.Show("Please select a valid size.");
                    return;
                }

                
                int smallPrice = 0, mediumPrice = 0, largePrice = 0;

                switch (size)
                {
                    case "Small":
                        smallPrice = basePrice;
                        mediumPrice = basePrice + 230;
                        largePrice = basePrice + 410;
                        break;

                    case "Medium":
                        smallPrice = basePrice - 235; 
                        mediumPrice = basePrice;
                        largePrice = basePrice + 230; 
                        break;

                    case "Large":
                        smallPrice = basePrice - 310; 
                        mediumPrice = basePrice - 305; 
                        largePrice = basePrice;
                        break;

                    default:
                        MessageBox.Show("Invalid size selected.");
                        return;
                }

                
                pizzamenu pu = new pizzamenu
                {
                    id = id,
                    pizza_name = name,
                    small_size = smallPrice,
                    medium_size = mediumPrice,
                    large_size = largePrice
                };

                
                db.pizzamenus.InsertOnSubmit(pu);
                db.SubmitChanges();

                MessageBox.Show("Pizza added successfully!");
                ClearForm();  
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void ClearForm()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.SelectedIndex = -1;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            db=new pmsDataContext();
            shakes_and_smoothy sk = new shakes_and_smoothy();

            try
            {
                sk.id = int.Parse(textBox1.Text);
                sk.shakes_name = textBox2.Text;
                sk.price = Convert.ToInt32(textBox3.Text);

                db.shakes_and_smoothies.InsertOnSubmit(sk);
                db.SubmitChanges();

                MessageBox.Show("Shake or Smoothie added successfully!");
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            burger Br=new burger();
            try
            {
                Br.id = int.Parse(textBox1.Text);
                Br.burger_name = textBox2.Text;
                Br.price = Convert.ToInt32(textBox3.Text);

                using (pmsDataContext db = new pmsDataContext())
                {
                    db.burgers.InsertOnSubmit(Br);
                    db.SubmitChanges();
                }

                MessageBox.Show("Burger added successfully!");
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            specialpizzamenu sp=new specialpizzamenu();
            try
            {
                sp.id = int.Parse(textBox1.Text);
                sp.pizza_name = textBox2.Text;
                sp.large_size = Convert.ToInt32(textBox3.Text);

                using (pmsDataContext db = new pmsDataContext())
                {
                    db.specialpizzamenus.InsertOnSubmit(sp);
                    db.SubmitChanges();
                }

                MessageBox.Show("Special pizza menu item added successfully!");
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Tea_menu tea_Menu = new Tea_menu();
            try
            {
                tea_Menu.id = int.Parse(textBox1.Text);
                tea_Menu.tea_name = textBox2.Text;
                tea_Menu.price = Convert.ToInt32(textBox3.Text);

                using (pmsDataContext db = new pmsDataContext())
                {
                    db.Tea_menus.InsertOnSubmit(tea_Menu);
                    db.SubmitChanges();
                }

                MessageBox.Show("Tea added successfully!");
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            fry FRY = new fry();
            try
            {
                FRY.id = int.Parse(textBox1.Text);
                FRY.fries_name = textBox2.Text;
                FRY.price = Convert.ToInt32(textBox3.Text);

                using (pmsDataContext db = new pmsDataContext())
                {
                    db.fries.InsertOnSubmit(FRY);
                    db.SubmitChanges();
                }

                MessageBox.Show("Fry added successfully!");
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            starter starter = new starter();

            try
            {
                starter.id = int.Parse(textBox1.Text);
                starter.starters_name = textBox2.Text;
                starter.price = Convert.ToInt32(textBox3.Text);

                using (pmsDataContext db = new pmsDataContext())
                {
                    db.starters.InsertOnSubmit(starter);
                    db.SubmitChanges();
                }

                MessageBox.Show("Starter added successfully!");
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            desert Des = new desert();

            try
            {
                Des.id = int.Parse(textBox1.Text);
                Des.desert_name = textBox2.Text;
                Des.price = Convert.ToInt32(textBox3.Text);

                using (pmsDataContext db = new pmsDataContext())
                {
                    db.deserts.InsertOnSubmit(Des);
                    db.SubmitChanges();
                }

                MessageBox.Show("Dessert added successfully!");
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            chicken_steak chicken_Steak = new chicken_steak();

            try
            {
                chicken_Steak.id = int.Parse(textBox1.Text);
                chicken_Steak.chicken_steak_name = textBox2.Text;
                chicken_Steak.price = Convert.ToInt32(textBox3.Text);

                using (pmsDataContext db = new pmsDataContext())
                {
                    db.chicken_steaks.InsertOnSubmit(chicken_Steak);
                    db.SubmitChanges();
                }

                MessageBox.Show("Chicken Steak added successfully!");
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            barmenu_coffee coffee = new barmenu_coffee();
            try
            {
                coffee.id = int.Parse(textBox1.Text);
                coffee.coffee_name = textBox2.Text;
                coffee.price = Convert.ToInt32(textBox3.Text);

                using (pmsDataContext db = new pmsDataContext())
                {
                    db.barmenu_coffees.InsertOnSubmit(coffee);
                    db.SubmitChanges();
                }

                MessageBox.Show("Coffee added successfully!");
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Beef_steak beef_Steak = new Beef_steak();

            try
            {
                beef_Steak.id = int.Parse(textBox1.Text);
                beef_Steak.beef_steak_name = textBox2.Text;
                beef_Steak.price = Convert.ToInt32(textBox3.Text);

                using (pmsDataContext db = new pmsDataContext())
                {
                    db.Beef_steaks.InsertOnSubmit(beef_Steak);
                    db.SubmitChanges();
                }

                MessageBox.Show("Beef steak added successfully!");
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            drinks_slush drinks_Slush = new drinks_slush();

            try
            {
                drinks_Slush.id = int.Parse(textBox1.Text);
                drinks_Slush.drink_name = textBox2.Text;
                drinks_Slush.price = Convert.ToInt32(textBox3.Text);

                using (pmsDataContext db = new pmsDataContext())
                {
                    db.drinks_slushes.InsertOnSubmit(drinks_Slush);
                    db.SubmitChanges();
                }

                MessageBox.Show("Drinks Slush added successfully!");
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            fried_chicken fried_Chicken = new fried_chicken();
            try
            {
                fried_Chicken.id = int.Parse(textBox1.Text);
                fried_Chicken.fried_ck_name= textBox2.Text;
                fried_Chicken.price = Convert.ToInt32(textBox3.Text);

                using (pmsDataContext db = new pmsDataContext())
                {
                    db.fried_chickens.InsertOnSubmit(fried_Chicken);
                    db.SubmitChanges();
                }

                MessageBox.Show("Fried Chicken added successfully!");
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            pasta ps=new pasta();
            try
            {
                ps.id = int.Parse(textBox1.Text);
                ps.pasta_name = textBox2.Text;
                ps.price = Convert.ToInt32(textBox3.Text);

                using (pmsDataContext db = new pmsDataContext())
                {
                    db.pastas.InsertOnSubmit(ps);
                    db.SubmitChanges();
                }

                MessageBox.Show("Pasta added successfully!");
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void button23_Click(object sender, EventArgs e)
        {
            sandwich sd=new sandwich();
            try
            {
                sd.id = int.Parse(textBox1.Text);
                sd.sandwich_name = textBox2.Text;
                sd.price = Convert.ToInt32(textBox3.Text);

                using (pmsDataContext db = new pmsDataContext())
                {
                    db.sandwiches.InsertOnSubmit(sd);
                    db.SubmitChanges();
                }

                MessageBox.Show("Sandwich added successfully!");
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Upadate_Iteams ut=new Upadate_Iteams();
            ut.ShowDialog();
        }
    }
}
