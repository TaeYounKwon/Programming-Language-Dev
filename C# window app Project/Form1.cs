using System;
using System.Windows.Forms;
using System.Data.SqlClient;

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

            listBoxAllOrders.Items.Add(totalPrice.ToString());

            string connectionString = "Data Source=(local); integrated security=SSPI; Database=IceCreamOrders";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            DateTime dateTime = DateTime.Now;

            string dateTimeString = dateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");

            string sqlString = "Insert Into Orders (DateTime, TotalPrice, CustomerID) Values (" 
                +"'"+dateTimeString
                +"'"+","+ totalPrice 
                + "'"+")" ;
            SqlCommand command = new SqlCommand(sqlString, connection);

            command.ExecuteNonQuery();

            connection.Close();

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

        private void buttonDatabase_Click(object sender, EventArgs e)
        {
            decimal alltotalPrice = 0;
            for (int index = 0; index < listBoxAllOrders.Items.Count; index++)
            {
                string itemPrice = listBoxAllOrders.Items[index].ToString();
                alltotalPrice += Decimal.Parse(itemPrice);
            }
            labelData.Text = alltotalPrice.ToString();

        }

        private void formsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomersForm form = new CustomersForm();

            form.ShowDialog();
        }

        private void listBoxCustomerIDs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
