namespace Example_07
{
    partial class CustomerTransactionsForm
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
            this.dataGridViewCustomerTransactions = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCustomerTransactions = new System.Windows.Forms.Button();
            this.listBoxCustomerIDs = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomerTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCustomerTransactions
            // 
            this.dataGridViewCustomerTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomerTransactions.Location = new System.Drawing.Point(252, 24);
            this.dataGridViewCustomerTransactions.Name = "dataGridViewCustomerTransactions";
            this.dataGridViewCustomerTransactions.RowHeadersWidth = 62;
            this.dataGridViewCustomerTransactions.RowTemplate.Height = 28;
            this.dataGridViewCustomerTransactions.Size = new System.Drawing.Size(625, 358);
            this.dataGridViewCustomerTransactions.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer ID";
            // 
            // buttonCustomerTransactions
            // 
            this.buttonCustomerTransactions.Location = new System.Drawing.Point(36, 314);
            this.buttonCustomerTransactions.Name = "buttonCustomerTransactions";
            this.buttonCustomerTransactions.Size = new System.Drawing.Size(198, 34);
            this.buttonCustomerTransactions.TabIndex = 3;
            this.buttonCustomerTransactions.Text = "Customer Transactions";
            this.buttonCustomerTransactions.UseVisualStyleBackColor = true;
            this.buttonCustomerTransactions.Click += new System.EventHandler(this.buttonCustomerTransactions_Click);
            // 
            // listBoxCustomerIDs
            // 
            this.listBoxCustomerIDs.FormattingEnabled = true;
            this.listBoxCustomerIDs.ItemHeight = 20;
            this.listBoxCustomerIDs.Location = new System.Drawing.Point(40, 80);
            this.listBoxCustomerIDs.Name = "listBoxCustomerIDs";
            this.listBoxCustomerIDs.Size = new System.Drawing.Size(171, 164);
            this.listBoxCustomerIDs.TabIndex = 4;
            // 
            // CustomerTransactionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 414);
            this.Controls.Add(this.listBoxCustomerIDs);
            this.Controls.Add(this.buttonCustomerTransactions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewCustomerTransactions);
            this.Name = "CustomerTransactionsForm";
            this.Text = "CustomerTransactionsForm";
            this.Load += new System.EventHandler(this.CustomerTransactionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomerTransactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCustomerTransactions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCustomerTransactions;
        private System.Windows.Forms.ListBox listBoxCustomerIDs;
    }
}