using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace IceCreamShop_V2
{
    public partial class Form_IceCreamShop : Form
    {
        public Form_IceCreamShop()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            const decimal Chocolate = 5.00M;
            const decimal Vanilla = 3.00M;
            const decimal Strawberry = 4.00M;

            const decimal Sprinkles = 1.00M;
            const decimal ChoppedNuts = 2.00M;
            const decimal Cherry = 2.00M;

            decimal totalPrice = 0;

            if (radioButtonChocolate.Checked == true)
            {
                totalPrice = Chocolate;
            }
            else if (radioButtonVanilla.Checked == true)
            {
                totalPrice = Vanilla;
            }
            else
            {
                totalPrice = Strawberry;
            }

            if (checkBoxCherry.Checked == true)
            {
                totalPrice += Cherry;
            }
            if (checkBoxChoppedNuts.Checked == true)
            {
                totalPrice += ChoppedNuts;
            }
            if (checkBoxSprinkles.Checked == true)
            {
                totalPrice += Sprinkles;
            }

            listBoxOrders.Items.Add(totalPrice.ToString());

        }

        private void buttonTotal_Click(object sender, EventArgs e)
        {
            decimal totalPrice = 0;
            for(int index=0; index<listBoxOrders.Items.Count; index++)
            {
                string itemPrice = listBoxOrders.Items[index].ToString();
                totalPrice += Decimal.Parse(itemPrice);
            }
            labelResult.Text = totalPrice.ToString();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBoxOrders.Items.Clear();
            checkBoxCherry.Checked = false;
            checkBoxChoppedNuts.Checked = false;
            checkBoxSprinkles.Checked = false;

            radioButtonChocolate.Checked = false;
            radioButtonStrawberry.Checked = false;
            radioButtonVanilla.Checked = false;

            labelResult.Text = string.Empty;
        }

        private void CustomersformsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetPrice form = new SetPrice();

            form.ShowDialog();
        }
    }
    
}
