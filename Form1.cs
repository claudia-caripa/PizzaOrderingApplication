namespace PizzaOrderingApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double price;
        double sizePrice = 0;
        double finalPrice = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

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
        private void Reset()
        {

            lstPizzaName.SelectedItem = null;
            
            ResetCheckboxAndRadiobuttons();

            price = 0;
            lblPrice.Text = price.ToString("C");

            gbExtraToppings.Enabled = false;
            gbSize.Enabled = false;
            txtSpecialRequirements.Enabled = false;
            btnOrder.Enabled = false;
        }

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

        /*Update the price depending on the pizza name selected in the listBox*/
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetCheckboxAndRadiobuttons();

            CalculateBasePrice(lstPizzaName);

            gbExtraToppings.Enabled = true;
            gbSize.Enabled=true;
        }

        private void ToppingHasBeenClicked(CheckBox checkboxName)
        {
            if (checkboxName.Checked)
            {
                price = Math.Round(price + 0.20, 2);
            }
            else
            {
                price = Math.Round(price - 0.20, 2);
            }

            lblPrice.Text = price.ToString("C");
        }

        private void ToppingClicked(object sender, EventArgs e)
        {
        

        }

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

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void gbSize_Enter(object sender, EventArgs e)
        {

        }

        private void SizeClicked(object sender, EventArgs e)
        {
            btnOrder.Enabled = true;
            txtSpecialRequirements.Enabled = true;

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
            }


            finalPrice = sizePrice + price;
            lblPrice.Text = finalPrice.ToString("C");
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            string size = "";
            string toppings = "";
            string specialRequirements = "";
            Console.WriteLine(lstPizzaName.SelectedItem.ToString());
            Console.WriteLine(finalPrice.ToString("C"));

            foreach (Control item in gbSize.Controls)
            {
                RadioButton radioButton = item as RadioButton;
                if (radioButton.Checked)
                {
                    size = radioButton.Text;
                }
            }

            foreach (Control item in gbExtraToppings.Controls)
            {
                CheckBox checkBox = item as CheckBox;
                if (checkBox.Checked)
                {
                    toppings += $"{checkBox.Text}, ";
                }

            }


            Console.WriteLine(size);
            Console.WriteLine(toppings);

            if (txtSpecialRequirements.Text != string.Empty)
            {
                specialRequirements = $"Special Requirements: {txtSpecialRequirements.Text}.";
            }

            MessageBox.Show($"Your order is: {size} {lstPizzaName.Text.ToString()}, {toppings} \n{specialRequirements}\n" +
                $"Please pay {finalPrice} at the cashier.", "Your Order");

            Reset();
        }
    }
}