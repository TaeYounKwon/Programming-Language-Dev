
namespace IceCreamShop_V2
{
    partial class Form_IceCreamShop
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_Select = new System.Windows.Forms.GroupBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.listBoxOrders = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.groupBoxToppings = new System.Windows.Forms.GroupBox();
            this.checkBoxCherry = new System.Windows.Forms.CheckBox();
            this.checkBoxSprinkles = new System.Windows.Forms.CheckBox();
            this.checkBoxChoppedNuts = new System.Windows.Forms.CheckBox();
            this.groupBoxFlavor = new System.Windows.Forms.GroupBox();
            this.radioButtonStrawberry = new System.Windows.Forms.RadioButton();
            this.radioButtonVanilla = new System.Windows.Forms.RadioButton();
            this.radioButtonChocolate = new System.Windows.Forms.RadioButton();
            this.groupBoxBottom = new System.Windows.Forms.GroupBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.buttonTotal = new System.Windows.Forms.Button();
            this.groupBoxData = new System.Windows.Forms.GroupBox();
            this.listBoxAllOrders = new System.Windows.Forms.ListBox();
            this.labelData = new System.Windows.Forms.Label();
            this.buttonDatabase = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.formsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_Select.SuspendLayout();
            this.groupBoxToppings.SuspendLayout();
            this.groupBoxFlavor.SuspendLayout();
            this.groupBoxBottom.SuspendLayout();
            this.groupBoxData.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Select
            // 
            this.groupBox_Select.Controls.Add(this.buttonClear);
            this.groupBox_Select.Controls.Add(this.listBoxOrders);
            this.groupBox_Select.Controls.Add(this.label1);
            this.groupBox_Select.Controls.Add(this.buttonAdd);
            this.groupBox_Select.Controls.Add(this.groupBoxToppings);
            this.groupBox_Select.Controls.Add(this.groupBoxFlavor);
            this.groupBox_Select.ForeColor = System.Drawing.Color.MediumBlue;
            this.groupBox_Select.Location = new System.Drawing.Point(12, 40);
            this.groupBox_Select.Name = "groupBox_Select";
            this.groupBox_Select.Size = new System.Drawing.Size(603, 366);
            this.groupBox_Select.TabIndex = 0;
            this.groupBox_Select.TabStop = false;
            this.groupBox_Select.Text = "Select Ice Cream Cone";
            // 
            // buttonClear
            // 
            this.buttonClear.ForeColor = System.Drawing.Color.Black;
            this.buttonClear.Location = new System.Drawing.Point(384, 276);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(203, 59);
            this.buttonClear.TabIndex = 8;
            this.buttonClear.Text = "Clear Ice Cream Cone Orders";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // listBoxOrders
            // 
            this.listBoxOrders.FormattingEnabled = true;
            this.listBoxOrders.ItemHeight = 23;
            this.listBoxOrders.Location = new System.Drawing.Point(384, 50);
            this.listBoxOrders.Name = "listBoxOrders";
            this.listBoxOrders.Size = new System.Drawing.Size(203, 188);
            this.listBoxOrders.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(380, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ice Cream Cone Orders";
            // 
            // buttonAdd
            // 
            this.buttonAdd.ForeColor = System.Drawing.Color.Black;
            this.buttonAdd.Location = new System.Drawing.Point(23, 283);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(323, 44);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add Ice Cream Cone Order";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // groupBoxToppings
            // 
            this.groupBoxToppings.Controls.Add(this.checkBoxCherry);
            this.groupBoxToppings.Controls.Add(this.checkBoxSprinkles);
            this.groupBoxToppings.Controls.Add(this.checkBoxChoppedNuts);
            this.groupBoxToppings.ForeColor = System.Drawing.Color.MediumBlue;
            this.groupBoxToppings.Location = new System.Drawing.Point(202, 31);
            this.groupBoxToppings.Name = "groupBoxToppings";
            this.groupBoxToppings.Size = new System.Drawing.Size(172, 222);
            this.groupBoxToppings.TabIndex = 0;
            this.groupBoxToppings.TabStop = false;
            this.groupBoxToppings.Text = "Toppings";
            // 
            // checkBoxCherry
            // 
            this.checkBoxCherry.AutoSize = true;
            this.checkBoxCherry.ForeColor = System.Drawing.Color.Black;
            this.checkBoxCherry.Location = new System.Drawing.Point(15, 124);
            this.checkBoxCherry.Name = "checkBoxCherry";
            this.checkBoxCherry.Size = new System.Drawing.Size(84, 27);
            this.checkBoxCherry.TabIndex = 4;
            this.checkBoxCherry.Text = "Cherry";
            this.checkBoxCherry.UseVisualStyleBackColor = true;
            // 
            // checkBoxSprinkles
            // 
            this.checkBoxSprinkles.AutoSize = true;
            this.checkBoxSprinkles.ForeColor = System.Drawing.Color.Black;
            this.checkBoxSprinkles.Location = new System.Drawing.Point(15, 33);
            this.checkBoxSprinkles.Name = "checkBoxSprinkles";
            this.checkBoxSprinkles.Size = new System.Drawing.Size(102, 27);
            this.checkBoxSprinkles.TabIndex = 2;
            this.checkBoxSprinkles.Text = "Sprinkles";
            this.checkBoxSprinkles.UseVisualStyleBackColor = true;
            // 
            // checkBoxChoppedNuts
            // 
            this.checkBoxChoppedNuts.AutoSize = true;
            this.checkBoxChoppedNuts.ForeColor = System.Drawing.Color.Black;
            this.checkBoxChoppedNuts.Location = new System.Drawing.Point(15, 78);
            this.checkBoxChoppedNuts.Name = "checkBoxChoppedNuts";
            this.checkBoxChoppedNuts.Size = new System.Drawing.Size(141, 27);
            this.checkBoxChoppedNuts.TabIndex = 3;
            this.checkBoxChoppedNuts.Text = "Chopped Nuts";
            this.checkBoxChoppedNuts.UseVisualStyleBackColor = true;
            // 
            // groupBoxFlavor
            // 
            this.groupBoxFlavor.Controls.Add(this.radioButtonStrawberry);
            this.groupBoxFlavor.Controls.Add(this.radioButtonVanilla);
            this.groupBoxFlavor.Controls.Add(this.radioButtonChocolate);
            this.groupBoxFlavor.ForeColor = System.Drawing.Color.MediumBlue;
            this.groupBoxFlavor.Location = new System.Drawing.Point(23, 31);
            this.groupBoxFlavor.Name = "groupBoxFlavor";
            this.groupBoxFlavor.Size = new System.Drawing.Size(173, 227);
            this.groupBoxFlavor.TabIndex = 0;
            this.groupBoxFlavor.TabStop = false;
            this.groupBoxFlavor.Text = "Flavor";
            // 
            // radioButtonStrawberry
            // 
            this.radioButtonStrawberry.AutoSize = true;
            this.radioButtonStrawberry.ForeColor = System.Drawing.Color.Black;
            this.radioButtonStrawberry.Location = new System.Drawing.Point(17, 123);
            this.radioButtonStrawberry.Name = "radioButtonStrawberry";
            this.radioButtonStrawberry.Size = new System.Drawing.Size(118, 27);
            this.radioButtonStrawberry.TabIndex = 7;
            this.radioButtonStrawberry.TabStop = true;
            this.radioButtonStrawberry.Text = "Strawberry";
            this.radioButtonStrawberry.UseVisualStyleBackColor = true;
            // 
            // radioButtonVanilla
            // 
            this.radioButtonVanilla.AutoSize = true;
            this.radioButtonVanilla.ForeColor = System.Drawing.Color.Black;
            this.radioButtonVanilla.Location = new System.Drawing.Point(17, 77);
            this.radioButtonVanilla.Name = "radioButtonVanilla";
            this.radioButtonVanilla.Size = new System.Drawing.Size(81, 27);
            this.radioButtonVanilla.TabIndex = 6;
            this.radioButtonVanilla.TabStop = true;
            this.radioButtonVanilla.Text = "Vanilla";
            this.radioButtonVanilla.UseVisualStyleBackColor = true;
            // 
            // radioButtonChocolate
            // 
            this.radioButtonChocolate.AutoSize = true;
            this.radioButtonChocolate.ForeColor = System.Drawing.Color.Black;
            this.radioButtonChocolate.Location = new System.Drawing.Point(17, 33);
            this.radioButtonChocolate.Name = "radioButtonChocolate";
            this.radioButtonChocolate.Size = new System.Drawing.Size(107, 27);
            this.radioButtonChocolate.TabIndex = 5;
            this.radioButtonChocolate.TabStop = true;
            this.radioButtonChocolate.Text = "Chocolate";
            this.radioButtonChocolate.UseVisualStyleBackColor = true;
            // 
            // groupBoxBottom
            // 
            this.groupBoxBottom.Controls.Add(this.labelResult);
            this.groupBoxBottom.Controls.Add(this.labelTotal);
            this.groupBoxBottom.Controls.Add(this.buttonTotal);
            this.groupBoxBottom.Location = new System.Drawing.Point(12, 412);
            this.groupBoxBottom.Name = "groupBoxBottom";
            this.groupBoxBottom.Size = new System.Drawing.Size(603, 87);
            this.groupBoxBottom.TabIndex = 1;
            this.groupBoxBottom.TabStop = false;
            // 
            // labelResult
            // 
            this.labelResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelResult.Location = new System.Drawing.Point(288, 29);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(202, 38);
            this.labelResult.TabIndex = 6;
            // 
            // labelTotal
            // 
            this.labelTotal.Location = new System.Drawing.Point(196, 37);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(94, 18);
            this.labelTotal.TabIndex = 5;
            this.labelTotal.Text = "Total Price";
            // 
            // buttonTotal
            // 
            this.buttonTotal.Location = new System.Drawing.Point(14, 29);
            this.buttonTotal.Name = "buttonTotal";
            this.buttonTotal.Size = new System.Drawing.Size(182, 38);
            this.buttonTotal.TabIndex = 3;
            this.buttonTotal.Text = "Total Price";
            this.buttonTotal.UseVisualStyleBackColor = true;
            this.buttonTotal.Click += new System.EventHandler(this.buttonTotal_Click);
            // 
            // groupBoxData
            // 
            this.groupBoxData.Controls.Add(this.listBoxAllOrders);
            this.groupBoxData.Controls.Add(this.labelData);
            this.groupBoxData.Controls.Add(this.buttonDatabase);
            this.groupBoxData.ForeColor = System.Drawing.Color.MediumBlue;
            this.groupBoxData.Location = new System.Drawing.Point(637, 40);
            this.groupBoxData.Name = "groupBoxData";
            this.groupBoxData.Size = new System.Drawing.Size(216, 459);
            this.groupBoxData.TabIndex = 2;
            this.groupBoxData.TabStop = false;
            this.groupBoxData.Text = "All Customer Orders";
            // 
            // listBoxAllOrders
            // 
            this.listBoxAllOrders.FormattingEnabled = true;
            this.listBoxAllOrders.ItemHeight = 23;
            this.listBoxAllOrders.Location = new System.Drawing.Point(17, 50);
            this.listBoxAllOrders.Name = "listBoxAllOrders";
            this.listBoxAllOrders.Size = new System.Drawing.Size(173, 234);
            this.listBoxAllOrders.TabIndex = 3;
            // 
            // labelData
            // 
            this.labelData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelData.ForeColor = System.Drawing.Color.Black;
            this.labelData.Location = new System.Drawing.Point(20, 389);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(170, 50);
            this.labelData.TabIndex = 2;
            // 
            // buttonDatabase
            // 
            this.buttonDatabase.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDatabase.ForeColor = System.Drawing.Color.Black;
            this.buttonDatabase.Location = new System.Drawing.Point(17, 307);
            this.buttonDatabase.Name = "buttonDatabase";
            this.buttonDatabase.Size = new System.Drawing.Size(188, 48);
            this.buttonDatabase.TabIndex = 1;
            this.buttonDatabase.Text = "Total Up All Transactions";
            this.buttonDatabase.UseVisualStyleBackColor = true;
            this.buttonDatabase.Click += new System.EventHandler(this.buttonDatabase_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(865, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // formsToolStripMenuItem
            // 
            this.formsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customersToolStripMenuItem});
            this.formsToolStripMenuItem.Name = "formsToolStripMenuItem";
            this.formsToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.formsToolStripMenuItem.Text = "Forms";
            this.formsToolStripMenuItem.Click += new System.EventHandler(this.formsToolStripMenuItem_Click);
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.customersToolStripMenuItem.Text = "Customers";
            // 
            // Form_IceCreamShop
            // 
            this.ClientSize = new System.Drawing.Size(865, 506);
            this.Controls.Add(this.groupBoxData);
            this.Controls.Add(this.groupBoxBottom);
            this.Controls.Add(this.groupBox_Select);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_IceCreamShop";
            this.ShowIcon = false;
            this.Text = "Ice Cream Shop";
            this.groupBox_Select.ResumeLayout(false);
            this.groupBox_Select.PerformLayout();
            this.groupBoxToppings.ResumeLayout(false);
            this.groupBoxToppings.PerformLayout();
            this.groupBoxFlavor.ResumeLayout(false);
            this.groupBoxFlavor.PerformLayout();
            this.groupBoxBottom.ResumeLayout(false);
            this.groupBoxData.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.GroupBox groupBox_Select;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.ListBox listBoxOrders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.GroupBox groupBoxToppings;
        private System.Windows.Forms.CheckBox checkBoxCherry;
        private System.Windows.Forms.CheckBox checkBoxSprinkles;
        private System.Windows.Forms.CheckBox checkBoxChoppedNuts;
        private System.Windows.Forms.GroupBox groupBoxFlavor;
        private System.Windows.Forms.RadioButton radioButtonStrawberry;
        private System.Windows.Forms.RadioButton radioButtonVanilla;
        private System.Windows.Forms.RadioButton radioButtonChocolate;
        private System.Windows.Forms.GroupBox groupBoxBottom;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button buttonTotal;
        private System.Windows.Forms.GroupBox groupBoxData;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Button buttonDatabase;
        private System.Windows.Forms.ListBox listBoxAllOrders;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
    }
}

