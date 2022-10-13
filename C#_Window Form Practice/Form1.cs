using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Example_07
{
    public partial class PappasPizzaForm : Form
    {
        public PappasPizzaForm()
        {
            InitializeComponent();
        }

        private void buttonTotalPrice_Click(object sender, EventArgs e)
        {
            decimal totalPrice = 0;

            for (int index = 0; index < listBoxPizzaOrders.Items.Count; index++)
            {
                string itemPrice = listBoxPizzaOrders.Items[index].ToString();

                totalPrice += Decimal.Parse(itemPrice);
            }

            labelTotalPrice.Text = totalPrice.ToString();

            //Write record to database table
            string connectionString = "Data Source=(local); integrated security=SSPI; Database=PapasPizza";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            DateTime dateTime = DateTime.Now;
        
            string dateTimeString = dateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");

            string sqlString = "Insert Into Orders (DateTime, TotalPrice, CustomerID) Values (" 
                + "'" + dateTimeString + "'" + "," + totalPrice + "," + "'" + listBoxCustomerIDs.SelectedItem.ToString() + "'" + ")";
            
            SqlCommand command = new SqlCommand(sqlString, connection);
            //or
            //command.Connection = connection;
            //command.CommandText = sqlString;

            command.ExecuteNonQuery();

            connection.Close();

        }

        private void buttonAddPizzaOrder_Click(object sender, EventArgs e)
        {
            const decimal PIZZA_SIZE_SMALL = 5.00M;
            const decimal PIZZA_SIZE_MEDIUM = 10.00M;
            const decimal PIZZA_SIZE_LARGE = 15.00M;

            const decimal TOPPING_PEPPERONI = 4.00M;
            const decimal TOPPING_MUSHROOMS = 2.00M;
            const decimal TOPPING_BLACK_OLIVES = 1.00M;

            decimal totalPrice = 0;

            if (radioButtonSmall.Checked == true)
            {
                totalPrice = PIZZA_SIZE_SMALL;
            }
            else if (radioButtonMedium.Checked == true)
            {
                totalPrice = PIZZA_SIZE_MEDIUM;
            }
            else
            {
                totalPrice = PIZZA_SIZE_LARGE;
            }

            if (checkBoxPepperoni.Checked == true)
            {
                totalPrice += TOPPING_PEPPERONI;
            }

            if (checkBoxMushrooms.Checked == true)
            {
                totalPrice += TOPPING_MUSHROOMS;
            }

            if (checkBoxBlackOlives.Checked == true)
            {
                totalPrice += TOPPING_BLACK_OLIVES;
            }

            listBoxPizzaOrders.Items.Add(totalPrice.ToString());
        }

        private void buttonClearOrders_Click(object sender, EventArgs e)
        {
            listBoxPizzaOrders.Items.Clear();

            checkBoxPepperoni.Checked = false;
            checkBoxMushrooms.Checked = false;
            checkBoxBlackOlives.Checked = false;

            radioButtonSmall.Checked = false;
            radioButtonMedium.Checked = false;
            radioButtonLarge.Checked = false;

            labelTotalPrice.Text = String.Empty;
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomersForm form = new CustomersForm();

            form.ShowDialog();

            string connectionString = "Data Source=(local); integrated security=SSPI; Database=PapasPizza";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "Select CustomerID From Customers";

            SqlDataReader reader = command.ExecuteReader();

            bool hasMoreRecords = reader.Read();

            listBoxCustomerIDs.Items.Clear();

            while (hasMoreRecords == true)
            {
                listBoxCustomerIDs.Items.Add(reader["CustomerID"].ToString().Trim());


                hasMoreRecords = reader.Read();
            }

            reader.Close();

            connection.Close();
        }

        private void customerTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerTransactionsForm form = new CustomerTransactionsForm();

            form.ShowDialog();
        }

        private void PappasPizzaForm_Load(object sender, EventArgs e)
        {
            //Populate the list box with all existing customer IDs
            string connectionString = "Data Source=(local); integrated security=SSPI; Database=PapasPizza";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "Select CustomerID From Customers";

            SqlDataReader reader = command.ExecuteReader();

            bool hasMoreRecords = reader.Read();

            while (hasMoreRecords == true)
            {
                listBoxCustomerIDs.Items.Add(reader["CustomerID"].ToString().Trim());


                hasMoreRecords = reader.Read();
            }

            reader.Close();

            connection.Close();
        }
    }
}
