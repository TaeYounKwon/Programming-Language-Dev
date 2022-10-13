namespace Example_07
{
    partial class PappasPizzaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxPizzaSize = new System.Windows.Forms.GroupBox();
            this.radioButtonLarge = new System.Windows.Forms.RadioButton();
            this.radioButtonMedium = new System.Windows.Forms.RadioButton();
            this.radioButtonSmall = new System.Windows.Forms.RadioButton();
            this.groupBoxToppings = new System.Windows.Forms.GroupBox();
            this.checkBoxBlackOlives = new System.Windows.Forms.CheckBox();
            this.checkBoxMushrooms = new System.Windows.Forms.CheckBox();
            this.checkBoxPepperoni = new System.Windows.Forms.CheckBox();
            this.buttonTotalPrice = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.groupBoxSelectPizza = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxPizzaOrders = new System.Windows.Forms.ListBox();
            this.buttonClearOrders = new System.Windows.Forms.Button();
            this.buttonAddPizzaOrder = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.formsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.customerTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxCustomerIDs = new System.Windows.Forms.ListBox();
            this.groupBoxPizzaSize.SuspendLayout();
            this.groupBoxToppings.SuspendLayout();
            this.groupBoxSelectPizza.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPizzaSize
            // 
            this.groupBoxPizzaSize.Controls.Add(this.radioButtonLarge);
            this.groupBoxPizzaSize.Controls.Add(this.radioButtonMedium);
            this.groupBoxPizzaSize.Controls.Add(this.radioButtonSmall);
            this.groupBoxPizzaSize.Location = new System.Drawing.Point(18, 38);
            this.groupBoxPizzaSize.Name = "groupBoxPizzaSize";
            this.groupBoxPizzaSize.Size = new System.Drawing.Size(160, 182);
            this.groupBoxPizzaSize.TabIndex = 0;
            this.groupBoxPizzaSize.TabStop = false;
            this.groupBoxPizzaSize.Text = "Pizza Size";
            // 
            // radioButtonLarge
            // 
            this.radioButtonLarge.AutoSize = true;
            this.radioButtonLarge.Location = new System.Drawing.Point(23, 135);
            this.radioButtonLarge.Name = "radioButtonLarge";
            this.radioButtonLarge.Size = new System.Drawing.Size(75, 24);
            this.radioButtonLarge.TabIndex = 2;
            this.radioButtonLarge.TabStop = true;
            this.radioButtonLarge.Text = "Large";
            this.radioButtonLarge.UseVisualStyleBackColor = true;
            // 
            // radioButtonMedium
            // 
            this.radioButtonMedium.AutoSize = true;
            this.radioButtonMedium.Location = new System.Drawing.Point(23, 87);
            this.radioButtonMedium.Name = "radioButtonMedium";
            this.radioButtonMedium.Size = new System.Drawing.Size(90, 24);
            this.radioButtonMedium.TabIndex = 1;
            this.radioButtonMedium.TabStop = true;
            this.radioButtonMedium.Text = "Medium";
            this.radioButtonMedium.UseVisualStyleBackColor = true;
            // 
            // radioButtonSmall
            // 
            this.radioButtonSmall.AutoSize = true;
            this.radioButtonSmall.Location = new System.Drawing.Point(23, 41);
            this.radioButtonSmall.Name = "radioButtonSmall";
            this.radioButtonSmall.Size = new System.Drawing.Size(73, 24);
            this.radioButtonSmall.TabIndex = 0;
            this.radioButtonSmall.TabStop = true;
            this.radioButtonSmall.Text = "Small";
            this.radioButtonSmall.UseVisualStyleBackColor = true;
            // 
            // groupBoxToppings
            // 
            this.groupBoxToppings.Controls.Add(this.checkBoxBlackOlives);
            this.groupBoxToppings.Controls.Add(this.checkBoxMushrooms);
            this.groupBoxToppings.Controls.Add(this.checkBoxPepperoni);
            this.groupBoxToppings.Location = new System.Drawing.Point(215, 38);
            this.groupBoxToppings.Name = "groupBoxToppings";
            this.groupBoxToppings.Size = new System.Drawing.Size(177, 182);
            this.groupBoxToppings.TabIndex = 1;
            this.groupBoxToppings.TabStop = false;
            this.groupBoxToppings.Text = "Toppings";
            // 
            // checkBoxBlackOlives
            // 
            this.checkBoxBlackOlives.AutoSize = true;
            this.checkBoxBlackOlives.Location = new System.Drawing.Point(16, 135);
            this.checkBoxBlackOlives.Name = "checkBoxBlackOlives";
            this.checkBoxBlackOlives.Size = new System.Drawing.Size(120, 24);
            this.checkBoxBlackOlives.TabIndex = 2;
            this.checkBoxBlackOlives.Text = "Black Olives";
            this.checkBoxBlackOlives.UseVisualStyleBackColor = true;
            // 
            // checkBoxMushrooms
            // 
            this.checkBoxMushrooms.AutoSize = true;
            this.checkBoxMushrooms.Location = new System.Drawing.Point(16, 87);
            this.checkBoxMushrooms.Name = "checkBoxMushrooms";
            this.checkBoxMushrooms.Size = new System.Drawing.Size(118, 24);
            this.checkBoxMushrooms.TabIndex = 1;
            this.checkBoxMushrooms.Text = "Mushrooms";
            this.checkBoxMushrooms.UseVisualStyleBackColor = true;
            // 
            // checkBoxPepperoni
            // 
            this.checkBoxPepperoni.AutoSize = true;
            this.checkBoxPepperoni.Location = new System.Drawing.Point(16, 41);
            this.checkBoxPepperoni.Name = "checkBoxPepperoni";
            this.checkBoxPepperoni.Size = new System.Drawing.Size(107, 24);
            this.checkBoxPepperoni.TabIndex = 0;
            this.checkBoxPepperoni.Text = "Pepperoni";
            this.checkBoxPepperoni.UseVisualStyleBackColor = true;
            // 
            // buttonTotalPrice
            // 
            this.buttonTotalPrice.Location = new System.Drawing.Point(261, 371);
            this.buttonTotalPrice.Name = "buttonTotalPrice";
            this.buttonTotalPrice.Size = new System.Drawing.Size(161, 42);
            this.buttonTotalPrice.TabIndex = 2;
            this.buttonTotalPrice.Text = "Total Price";
            this.buttonTotalPrice.UseVisualStyleBackColor = true;
            this.buttonTotalPrice.Click += new System.EventHandler(this.buttonTotalPrice_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(432, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total Price:";
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTotalPrice.Location = new System.Drawing.Point(436, 381);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(142, 35);
            this.labelTotalPrice.TabIndex = 4;
            // 
            // groupBoxSelectPizza
            // 
            this.groupBoxSelectPizza.Controls.Add(this.label2);
            this.groupBoxSelectPizza.Controls.Add(this.listBoxPizzaOrders);
            this.groupBoxSelectPizza.Controls.Add(this.buttonClearOrders);
            this.groupBoxSelectPizza.Controls.Add(this.buttonAddPizzaOrder);
            this.groupBoxSelectPizza.Controls.Add(this.groupBoxToppings);
            this.groupBoxSelectPizza.Controls.Add(this.groupBoxPizzaSize);
            this.groupBoxSelectPizza.Location = new System.Drawing.Point(30, 39);
            this.groupBoxSelectPizza.Name = "groupBoxSelectPizza";
            this.groupBoxSelectPizza.Size = new System.Drawing.Size(604, 302);
            this.groupBoxSelectPizza.TabIndex = 5;
            this.groupBoxSelectPizza.TabStop = false;
            this.groupBoxSelectPizza.Text = "Select Pizza";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pizza Orders";
            // 
            // listBoxPizzaOrders
            // 
            this.listBoxPizzaOrders.FormattingEnabled = true;
            this.listBoxPizzaOrders.ItemHeight = 20;
            this.listBoxPizzaOrders.Location = new System.Drawing.Point(406, 58);
            this.listBoxPizzaOrders.Name = "listBoxPizzaOrders";
            this.listBoxPizzaOrders.Size = new System.Drawing.Size(177, 164);
            this.listBoxPizzaOrders.TabIndex = 4;
            // 
            // buttonClearOrders
            // 
            this.buttonClearOrders.Location = new System.Drawing.Point(406, 236);
            this.buttonClearOrders.Name = "buttonClearOrders";
            this.buttonClearOrders.Size = new System.Drawing.Size(167, 45);
            this.buttonClearOrders.TabIndex = 3;
            this.buttonClearOrders.Text = "Clear Orders";
            this.buttonClearOrders.UseVisualStyleBackColor = true;
            this.buttonClearOrders.Click += new System.EventHandler(this.buttonClearOrders_Click);
            // 
            // buttonAddPizzaOrder
            // 
            this.buttonAddPizzaOrder.Location = new System.Drawing.Point(18, 236);
            this.buttonAddPizzaOrder.Name = "buttonAddPizzaOrder";
            this.buttonAddPizzaOrder.Size = new System.Drawing.Size(374, 45);
            this.buttonAddPizzaOrder.TabIndex = 2;
            this.buttonAddPizzaOrder.Text = "Add Pizza Order";
            this.buttonAddPizzaOrder.UseVisualStyleBackColor = true;
            this.buttonAddPizzaOrder.Click += new System.EventHandler(this.buttonAddPizzaOrder_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(646, 33);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // formsToolStripMenuItem
            // 
            this.formsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customersToolStripMenuItem,
            this.customerTransactionsToolStripMenuItem});
            this.formsToolStripMenuItem.Name = "formsToolStripMenuItem";
            this.formsToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.formsToolStripMenuItem.Text = "Forms";
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(292, 34);
            this.customersToolStripMenuItem.Text = "Customers";
            this.customersToolStripMenuItem.Click += new System.EventHandler(this.customersToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Customer ID";
            // 
            // customerTransactionsToolStripMenuItem
            // 
            this.customerTransactionsToolStripMenuItem.Name = "customerTransactionsToolStripMenuItem";
            this.customerTransactionsToolStripMenuItem.Size = new System.Drawing.Size(292, 34);
            this.customerTransactionsToolStripMenuItem.Text = "Customer Transactions";
            this.customerTransactionsToolStripMenuItem.Click += new System.EventHandler(this.customerTransactionsToolStripMenuItem_Click);
            // 
            // listBoxCustomerIDs
            // 
            this.listBoxCustomerIDs.FormattingEnabled = true;
            this.listBoxCustomerIDs.ItemHeight = 20;
            this.listBoxCustomerIDs.Location = new System.Drawing.Point(131, 357);
            this.listBoxCustomerIDs.Name = "listBoxCustomerIDs";
            this.listBoxCustomerIDs.Size = new System.Drawing.Size(114, 64);
            this.listBoxCustomerIDs.TabIndex = 8;
            // 
            // PappasPizzaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 432);
            this.Controls.Add(this.listBoxCustomerIDs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBoxSelectPizza);
            this.Controls.Add(this.labelTotalPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTotalPrice);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PappasPizzaForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pappa\'s Pizza";
            this.Load += new System.EventHandler(this.PappasPizzaForm_Load);
            this.groupBoxPizzaSize.ResumeLayout(false);
            this.groupBoxPizzaSize.PerformLayout();
            this.groupBoxToppings.ResumeLayout(false);
            this.groupBoxToppings.PerformLayout();
            this.groupBoxSelectPizza.ResumeLayout(false);
            this.groupBoxSelectPizza.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPizzaSize;
        private System.Windows.Forms.RadioButton radioButtonLarge;
        private System.Windows.Forms.RadioButton radioButtonMedium;
        private System.Windows.Forms.RadioButton radioButtonSmall;
        private System.Windows.Forms.GroupBox groupBoxToppings;
        private System.Windows.Forms.CheckBox checkBoxBlackOlives;
        private System.Windows.Forms.CheckBox checkBoxMushrooms;
        private System.Windows.Forms.CheckBox checkBoxPepperoni;
        private System.Windows.Forms.Button buttonTotalPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.GroupBox groupBoxSelectPizza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxPizzaOrders;
        private System.Windows.Forms.Button buttonClearOrders;
        private System.Windows.Forms.Button buttonAddPizzaOrder;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem customerTransactionsToolStripMenuItem;
        private System.Windows.Forms.ListBox listBoxCustomerIDs;
    }
}

