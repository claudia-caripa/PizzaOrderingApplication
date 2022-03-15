namespace PizzaOrderingApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double price;

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Reset()
        {

            lstPizzaName.SelectedItem = "Indian Apache";
            CalculateBasePrice(lstPizzaName);


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

        private void CalculateBasePrice(ListBox listBox)
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

            // Print price in the label lblPrice
            lblPrice.Text = price.ToString("C");
        }

        /*Update the price depending on the pizza name selected in the listBox*/
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateBasePrice(lstPizzaName);
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
    }
}