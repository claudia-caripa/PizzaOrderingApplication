namespace PizzaOrderingApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*Declaration of global variables*/

        double price;
        double sizePrice = 0;
        double finalPrice = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        /*Method for unchecked checkboxes and radio buttons*/
        private void ResetCheckboxAndRadiobuttons()
        {
            foreach (Control item in gbExtraToppings.Controls)
            {
                var checkBox = item as CheckBox;
                checkBox.Checked = false;
            }

            foreach (Control item in gbSize.Controls)
            {
                RadioButton? radioButton = item as RadioButton;
                radioButton.Checked = false;
            }

        }


        /*Method to Reset all selections*/
        private void Reset()
        {
            lstPizzaName.Enabled = true;
            lstPizzaName.SelectedItem = null;
            
            ResetCheckboxAndRadiobuttons();

            price = 0;
            lblPrice.Text = price.ToString("C");

            gbExtraToppings.Enabled = false;
            gbSize.Enabled = false;
            txtSpecialRequirements.Enabled = false;
            txtSpecialRequirements.Text = "";
            btnOrder.Enabled = false;
        }


        /*Method to calculate base price depending on the type of pizza selected*/
        private void CalculateBasePrice(ListBox listBox)
        {
            if (lstPizzaName.SelectedItem != null)
            {
                switch (listBox.SelectedItem.ToString())
                {
                    case "Indian Apache":
                    case "All Day Breakfast":
                        price = 13.5;
                        break;
                    case "Mexican Pepper Volcano":
                    case "Bacon Apache":
                        price = 14.5;
                        break;
                    case "Buffalo":
                    case "Chicken Apache":
                        price = 12.5;
                        break;
                    case "Cajun Apache":
                    case "Hot Apache":
                        price = 11.5;
                        break;
                    case "Geronimo":
                    case "Tomahawk":
                        price = 15.5;
                        break;
                    case "Sitting Bull":
                    case "Texas Beef Fiesta":
                    case "Wigwammer":
                        price = 16.5;
                        break;
                    case "Vegetarian":
                        price = 10.5;
                        break;

                }
            }
            
            // Print price in the label lblPrice
            lblPrice.Text = price.ToString("C");
        }


        /*Method when a pizza type is selected in the list*/
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateBasePrice(lstPizzaName);

            /*GroupBox Extra Toppings will be enable*/
            gbExtraToppings.Enabled = true;

            /*If user clicks the list again, this controls will be disable*/
            txtSpecialRequirements.Enabled = false;
            gbSize.Enabled = false;

            /*All checkboxes for toppings will reset*/
            ResetCheckboxAndRadiobuttons();
        }

        /*This method is called when a checbox for a topping is clicked*/
        private void ToppingHasBeenClicked(CheckBox checkboxName)
        {
            if (checkboxName.Checked) //If topping is checked add 0.20
            {
                price = Math.Round(price + 0.20, 2);
            }
            else //If topping is unchecked substract 0.20
            {
                price = Math.Round(price - 0.20, 2);
            }

            lblPrice.Text = price.ToString("C");
        }

        /*When a topping in the gbExtraToppings is clicked, gbSize will be eneble*/
        private void ToppingClicked(object sender, EventArgs e)
        {
            gbSize.Enabled = true;
            lstPizzaName.Enabled = false;
        }

        
        /*If No extra topping checkbox is checked, the gbExtraToppings will be disable to prevent adding extra toppings*/
        private void cbNoTopping_CheckedChanged(object sender, EventArgs e)
        {
            gbExtraToppings.Enabled = false;

            foreach (Control item in gbExtraToppings.Controls)
            {
                CheckBox checkBox = item as CheckBox;
                checkBox.Checked = false;

            }
        }

        /*Methods for each topping checkboxes, all of them call the method ToppingHasBeenClicked*/
        private void cbTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            ToppingHasBeenClicked(cbTomatoes);
        }

        private void cbOnion_CheckedChanged(object sender, EventArgs e)
        {
            ToppingHasBeenClicked(cbOnion);
        }

        private void cbPepperoni_CheckedChanged(object sender, EventArgs e)
        {
            ToppingHasBeenClicked(cbPepperoni);
        }

        private void cbHam_CheckedChanged(object sender, EventArgs e)
        {
            ToppingHasBeenClicked(cbHam);
        }

        private void cbSausage_CheckedChanged(object sender, EventArgs e)
        {
            ToppingHasBeenClicked(cbSausage);
        }

        private void cbBacon_CheckedChanged(object sender, EventArgs e)
        {
            ToppingHasBeenClicked(cbBacon);
        }

        private void cbChicken_CheckedChanged(object sender, EventArgs e)
        {
            ToppingHasBeenClicked(cbChicken);
        }

        private void cbPineapple_CheckedChanged(object sender, EventArgs e)
        {
            ToppingHasBeenClicked(cbPineapple);
        }

        private void cbMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            ToppingHasBeenClicked(cbMushrooms);
        }

        private void cbJalapenos_CheckedChanged(object sender, EventArgs e)
        {
            ToppingHasBeenClicked(cbJalapenos);
        }

        private void cbSweetcorn_CheckedChanged(object sender, EventArgs e)
        {
            ToppingHasBeenClicked(cbSweetcorn);
        }

        private void cbGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            ToppingHasBeenClicked(cbGreenPeppers);
        }

        private void cbExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            ToppingHasBeenClicked(cbExtraCheese);
        }

        private void cbSalami_CheckedChanged(object sender, EventArgs e)
        {
            ToppingHasBeenClicked(cbSalami);
        }


        /*Function of the Reset button*/
        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void gbSize_Enter(object sender, EventArgs e)
        {

        }


        /*Method the evaluates which radio button for pizza size has been clicked, it updates the sizePrice and print a finalPrice*/
        private void SizeClicked(object sender, EventArgs e)
        {
            btnOrder.Enabled = true;
            txtSpecialRequirements.Enabled = true;
            gbExtraToppings.Enabled = false;

            if (rbSmall.Checked)
            {
                sizePrice = 2;
            }
            else if (rbMedium.Checked)
            {
                sizePrice = 3;
            }
            else if (rbLarge.Checked)
            {
                sizePrice = 4;
            } else if (rbPersonal.Checked)
            {
                sizePrice = 0;
            }

            finalPrice = sizePrice + price;
            lblPrice.Text = finalPrice.ToString("C");
        }

        /*Method for the Order button, it will show a MessageBox with the summary of the order*/ 
        private void btnOrder_Click(object sender, EventArgs e)
        {
            string size = "";
            string toppings = " with ";
            string specialRequirements = "";

            Console.WriteLine(lstPizzaName.SelectedItem.ToString());
            Console.WriteLine(finalPrice.ToString("C"));

            /*Verifies with size has been selected*/
            foreach (Control item in gbSize.Controls)
            {
                RadioButton radioButton = item as RadioButton;
                if (radioButton.Checked)
                {
                    size = radioButton.Text;
                }
            }

            /*Verifies wich toppings has been selected*/
            if (cbNoTopping.Checked)
            {
                toppings = " with no topping,";
            }
            else
            {
                foreach (Control item in gbExtraToppings.Controls)
                {
                    CheckBox checkBox = item as CheckBox;
                    if (checkBox.Checked)
                    {
                        toppings += $"{checkBox.Text}, ";
                    }

                }
            }

            Console.WriteLine(size);
            Console.WriteLine(toppings);

            /*Verifies if a special requirement has been type*/
            if (txtSpecialRequirements.Text != string.Empty)
            {
                specialRequirements = $"special requirements: {txtSpecialRequirements.Text}";
            }

            MessageBox.Show($"Your order is: {size} {lstPizzaName.Text}, {toppings} \n\n{specialRequirements}\n\n" +
                $"Please pay {finalPrice.ToString("C")} at the cashier.", "Your Order");

            /*Reset the form after MessageBox*/
            Reset();
        }


    }
}