namespace PizzaOrderingApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lstPizzaName = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbExtraToppings = new System.Windows.Forms.GroupBox();
            this.cbOnion = new System.Windows.Forms.CheckBox();
            this.cbBacon = new System.Windows.Forms.CheckBox();
            this.cbChicken = new System.Windows.Forms.CheckBox();
            this.cbSalami = new System.Windows.Forms.CheckBox();
            this.cbPineapple = new System.Windows.Forms.CheckBox();
            this.cbPepperoni = new System.Windows.Forms.CheckBox();
            this.cbHam = new System.Windows.Forms.CheckBox();
            this.cbSausage = new System.Windows.Forms.CheckBox();
            this.cbMushrooms = new System.Windows.Forms.CheckBox();
            this.cbJalapenos = new System.Windows.Forms.CheckBox();
            this.cbExtraCheese = new System.Windows.Forms.CheckBox();
            this.cbGreenPeppers = new System.Windows.Forms.CheckBox();
            this.cbSweetcorn = new System.Windows.Forms.CheckBox();
            this.cbTomatoes = new System.Windows.Forms.CheckBox();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.rbPersonal = new System.Windows.Forms.RadioButton();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.txtSpecialRequirements = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.gbExtraToppings.SuspendLayout();
            this.gbSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order a Pizza";
            // 
            // lstPizzaName
            // 
            this.lstPizzaName.FormattingEnabled = true;
            this.lstPizzaName.ItemHeight = 15;
            this.lstPizzaName.Items.AddRange(new object[] {
            "Indian Apache",
            "Mexican Pepper Volcano",
            "All Day Breakfast",
            "Bacon Apache",
            "Buffalo",
            "Cajun Apache",
            "Chiken Apache",
            "Geronimo",
            "Hot Apache",
            "Sitting Bull",
            "Texas Beef Fiesta",
            "Tomahawk",
            "Vegetarian",
            "Wigwammer"});
            this.lstPizzaName.Location = new System.Drawing.Point(30, 73);
            this.lstPizzaName.Name = "lstPizzaName";
            this.lstPizzaName.Size = new System.Drawing.Size(156, 229);
            this.lstPizzaName.TabIndex = 1;
            this.lstPizzaName.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // gbExtraToppings
            // 
            this.gbExtraToppings.Controls.Add(this.cbOnion);
            this.gbExtraToppings.Controls.Add(this.cbBacon);
            this.gbExtraToppings.Controls.Add(this.cbChicken);
            this.gbExtraToppings.Controls.Add(this.cbSalami);
            this.gbExtraToppings.Controls.Add(this.cbPineapple);
            this.gbExtraToppings.Controls.Add(this.cbPepperoni);
            this.gbExtraToppings.Controls.Add(this.cbHam);
            this.gbExtraToppings.Controls.Add(this.cbSausage);
            this.gbExtraToppings.Controls.Add(this.cbMushrooms);
            this.gbExtraToppings.Controls.Add(this.cbJalapenos);
            this.gbExtraToppings.Controls.Add(this.cbExtraCheese);
            this.gbExtraToppings.Controls.Add(this.cbGreenPeppers);
            this.gbExtraToppings.Controls.Add(this.cbSweetcorn);
            this.gbExtraToppings.Controls.Add(this.cbTomatoes);
            this.gbExtraToppings.Location = new System.Drawing.Point(214, 55);
            this.gbExtraToppings.Name = "gbExtraToppings";
            this.gbExtraToppings.Size = new System.Drawing.Size(228, 230);
            this.gbExtraToppings.TabIndex = 3;
            this.gbExtraToppings.TabStop = false;
            this.gbExtraToppings.Text = "Extra Toppings";
            // 
            // cbOnion
            // 
            this.cbOnion.AutoSize = true;
            this.cbOnion.Location = new System.Drawing.Point(21, 58);
            this.cbOnion.Name = "cbOnion";
            this.cbOnion.Size = new System.Drawing.Size(59, 19);
            this.cbOnion.TabIndex = 13;
            this.cbOnion.Text = "Onion";
            this.cbOnion.UseVisualStyleBackColor = true;
            this.cbOnion.CheckedChanged += new System.EventHandler(this.cbOnion_CheckedChanged);
            this.cbOnion.Click += new System.EventHandler(this.ToppingClicked);
            // 
            // cbBacon
            // 
            this.cbBacon.AutoSize = true;
            this.cbBacon.Location = new System.Drawing.Point(21, 158);
            this.cbBacon.Name = "cbBacon";
            this.cbBacon.Size = new System.Drawing.Size(59, 19);
            this.cbBacon.TabIndex = 12;
            this.cbBacon.Text = "Bacon";
            this.cbBacon.UseVisualStyleBackColor = true;
            this.cbBacon.CheckedChanged += new System.EventHandler(this.cbBacon_CheckedChanged);
            this.cbBacon.Click += new System.EventHandler(this.ToppingClicked);
            // 
            // cbChicken
            // 
            this.cbChicken.AutoSize = true;
            this.cbChicken.Location = new System.Drawing.Point(21, 183);
            this.cbChicken.Name = "cbChicken";
            this.cbChicken.Size = new System.Drawing.Size(69, 19);
            this.cbChicken.TabIndex = 11;
            this.cbChicken.Text = "Chicken";
            this.cbChicken.UseVisualStyleBackColor = true;
            this.cbChicken.CheckedChanged += new System.EventHandler(this.cbChicken_CheckedChanged);
            this.cbChicken.Click += new System.EventHandler(this.ToppingClicked);
            // 
            // cbSalami
            // 
            this.cbSalami.AutoSize = true;
            this.cbSalami.Location = new System.Drawing.Point(122, 183);
            this.cbSalami.Name = "cbSalami";
            this.cbSalami.Size = new System.Drawing.Size(61, 19);
            this.cbSalami.TabIndex = 10;
            this.cbSalami.Text = "Salami";
            this.cbSalami.UseVisualStyleBackColor = true;
            this.cbSalami.CheckedChanged += new System.EventHandler(this.cbSalami_CheckedChanged);
            this.cbSalami.Click += new System.EventHandler(this.ToppingClicked);
            // 
            // cbPineapple
            // 
            this.cbPineapple.AutoSize = true;
            this.cbPineapple.Location = new System.Drawing.Point(122, 33);
            this.cbPineapple.Name = "cbPineapple";
            this.cbPineapple.Size = new System.Drawing.Size(78, 19);
            this.cbPineapple.TabIndex = 9;
            this.cbPineapple.Text = "Pineapple";
            this.cbPineapple.UseVisualStyleBackColor = true;
            this.cbPineapple.CheckedChanged += new System.EventHandler(this.cbPineapple_CheckedChanged);
            this.cbPineapple.Click += new System.EventHandler(this.ToppingClicked);
            // 
            // cbPepperoni
            // 
            this.cbPepperoni.AutoSize = true;
            this.cbPepperoni.Location = new System.Drawing.Point(21, 83);
            this.cbPepperoni.Name = "cbPepperoni";
            this.cbPepperoni.Size = new System.Drawing.Size(80, 19);
            this.cbPepperoni.TabIndex = 8;
            this.cbPepperoni.Text = "Pepperoni";
            this.cbPepperoni.UseVisualStyleBackColor = true;
            this.cbPepperoni.CheckedChanged += new System.EventHandler(this.cbPepperoni_CheckedChanged);
            this.cbPepperoni.Click += new System.EventHandler(this.ToppingClicked);
            // 
            // cbHam
            // 
            this.cbHam.AutoSize = true;
            this.cbHam.Location = new System.Drawing.Point(21, 108);
            this.cbHam.Name = "cbHam";
            this.cbHam.Size = new System.Drawing.Size(52, 19);
            this.cbHam.TabIndex = 7;
            this.cbHam.Text = "Ham";
            this.cbHam.UseVisualStyleBackColor = true;
            this.cbHam.CheckedChanged += new System.EventHandler(this.cbHam_CheckedChanged);
            this.cbHam.Click += new System.EventHandler(this.ToppingClicked);
            // 
            // cbSausage
            // 
            this.cbSausage.AutoSize = true;
            this.cbSausage.Location = new System.Drawing.Point(21, 133);
            this.cbSausage.Name = "cbSausage";
            this.cbSausage.Size = new System.Drawing.Size(69, 19);
            this.cbSausage.TabIndex = 6;
            this.cbSausage.Text = "Sausage";
            this.cbSausage.UseVisualStyleBackColor = true;
            this.cbSausage.CheckedChanged += new System.EventHandler(this.cbSausage_CheckedChanged);
            this.cbSausage.Click += new System.EventHandler(this.ToppingClicked);
            // 
            // cbMushrooms
            // 
            this.cbMushrooms.AutoSize = true;
            this.cbMushrooms.Location = new System.Drawing.Point(122, 58);
            this.cbMushrooms.Name = "cbMushrooms";
            this.cbMushrooms.Size = new System.Drawing.Size(90, 19);
            this.cbMushrooms.TabIndex = 5;
            this.cbMushrooms.Text = "Mushrooms";
            this.cbMushrooms.UseVisualStyleBackColor = true;
            this.cbMushrooms.CheckedChanged += new System.EventHandler(this.cbMushrooms_CheckedChanged);
            this.cbMushrooms.Click += new System.EventHandler(this.ToppingClicked);
            // 
            // cbJalapenos
            // 
            this.cbJalapenos.AutoSize = true;
            this.cbJalapenos.Location = new System.Drawing.Point(122, 83);
            this.cbJalapenos.Name = "cbJalapenos";
            this.cbJalapenos.Size = new System.Drawing.Size(77, 19);
            this.cbJalapenos.TabIndex = 4;
            this.cbJalapenos.Text = "Jalapenos";
            this.cbJalapenos.UseVisualStyleBackColor = true;
            this.cbJalapenos.CheckedChanged += new System.EventHandler(this.cbJalapenos_CheckedChanged);
            this.cbJalapenos.Click += new System.EventHandler(this.ToppingClicked);
            // 
            // cbExtraCheese
            // 
            this.cbExtraCheese.AutoSize = true;
            this.cbExtraCheese.Location = new System.Drawing.Point(122, 158);
            this.cbExtraCheese.Name = "cbExtraCheese";
            this.cbExtraCheese.Size = new System.Drawing.Size(93, 19);
            this.cbExtraCheese.TabIndex = 3;
            this.cbExtraCheese.Text = "Extra Cheese";
            this.cbExtraCheese.UseVisualStyleBackColor = true;
            this.cbExtraCheese.CheckedChanged += new System.EventHandler(this.cbExtraCheese_CheckedChanged);
            this.cbExtraCheese.Click += new System.EventHandler(this.ToppingClicked);
            // 
            // cbGreenPeppers
            // 
            this.cbGreenPeppers.AutoSize = true;
            this.cbGreenPeppers.Location = new System.Drawing.Point(122, 133);
            this.cbGreenPeppers.Name = "cbGreenPeppers";
            this.cbGreenPeppers.Size = new System.Drawing.Size(102, 19);
            this.cbGreenPeppers.TabIndex = 2;
            this.cbGreenPeppers.Text = "Green Peppers";
            this.cbGreenPeppers.UseVisualStyleBackColor = true;
            this.cbGreenPeppers.CheckedChanged += new System.EventHandler(this.cbGreenPeppers_CheckedChanged);
            this.cbGreenPeppers.Click += new System.EventHandler(this.ToppingClicked);
            // 
            // cbSweetcorn
            // 
            this.cbSweetcorn.AutoSize = true;
            this.cbSweetcorn.Location = new System.Drawing.Point(122, 108);
            this.cbSweetcorn.Name = "cbSweetcorn";
            this.cbSweetcorn.Size = new System.Drawing.Size(81, 19);
            this.cbSweetcorn.TabIndex = 1;
            this.cbSweetcorn.Text = "Sweetcorn";
            this.cbSweetcorn.UseVisualStyleBackColor = true;
            this.cbSweetcorn.CheckedChanged += new System.EventHandler(this.cbSweetcorn_CheckedChanged);
            this.cbSweetcorn.Click += new System.EventHandler(this.ToppingClicked);
            // 
            // cbTomatoes
            // 
            this.cbTomatoes.AutoSize = true;
            this.cbTomatoes.Location = new System.Drawing.Point(21, 33);
            this.cbTomatoes.Name = "cbTomatoes";
            this.cbTomatoes.Size = new System.Drawing.Size(77, 19);
            this.cbTomatoes.TabIndex = 0;
            this.cbTomatoes.Text = "Tomatoes";
            this.cbTomatoes.UseVisualStyleBackColor = true;
            this.cbTomatoes.CheckedChanged += new System.EventHandler(this.cbTomatoes_CheckedChanged);
            this.cbTomatoes.Click += new System.EventHandler(this.ToppingClicked);
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.rbLarge);
            this.gbSize.Controls.Add(this.rbMedium);
            this.gbSize.Controls.Add(this.rbSmall);
            this.gbSize.Controls.Add(this.rbPersonal);
            this.gbSize.Location = new System.Drawing.Point(473, 55);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(156, 127);
            this.gbSize.TabIndex = 4;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(6, 97);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(54, 19);
            this.rbLarge.TabIndex = 3;
            this.rbLarge.TabStop = true;
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Location = new System.Drawing.Point(6, 72);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(70, 19);
            this.rbMedium.TabIndex = 2;
            this.rbMedium.TabStop = true;
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(6, 47);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(54, 19);
            this.rbSmall.TabIndex = 1;
            this.rbSmall.TabStop = true;
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            // 
            // rbPersonal
            // 
            this.rbPersonal.AutoSize = true;
            this.rbPersonal.Location = new System.Drawing.Point(6, 22);
            this.rbPersonal.Name = "rbPersonal";
            this.rbPersonal.Size = new System.Drawing.Size(70, 19);
            this.rbPersonal.TabIndex = 0;
            this.rbPersonal.TabStop = true;
            this.rbPersonal.Text = "Personal";
            this.rbPersonal.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(479, 209);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(479, 252);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(84, 23);
            this.btnOrder.TabIndex = 6;
            this.btnOrder.Text = "Place Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            // 
            // txtSpecialRequirements
            // 
            this.txtSpecialRequirements.Location = new System.Drawing.Point(30, 356);
            this.txtSpecialRequirements.Multiline = true;
            this.txtSpecialRequirements.Name = "txtSpecialRequirements";
            this.txtSpecialRequirements.Size = new System.Drawing.Size(412, 61);
            this.txtSpecialRequirements.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Special Requirements";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(479, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Price";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(479, 359);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 15);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "$0.00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSpecialRequirements);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.gbExtraToppings);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstPizzaName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Pizza Order Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.ToppingClicked);
            this.gbExtraToppings.ResumeLayout(false);
            this.gbExtraToppings.PerformLayout();
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ListBox lstPizzaName;
        private Label label2;
        private GroupBox gbExtraToppings;
        private CheckBox cbOnion;
        private CheckBox cbBacon;
        private CheckBox cbChicken;
        private CheckBox cbSalami;
        private CheckBox cbPineapple;
        private CheckBox cbPepperoni;
        private CheckBox cbHam;
        private CheckBox cbSausage;
        private CheckBox cbMushrooms;
        private CheckBox cbJalapenos;
        private CheckBox cbExtraCheese;
        private CheckBox cbGreenPeppers;
        private CheckBox cbSweetcorn;
        private CheckBox cbTomatoes;
        private GroupBox gbSize;
        private RadioButton rbLarge;
        private RadioButton rbMedium;
        private RadioButton rbSmall;
        private RadioButton rbPersonal;
        private Button btnReset;
        private Button btnOrder;
        private TextBox txtSpecialRequirements;
        private Label label3;
        private Label label4;
        private Label lblPrice;
    }
}