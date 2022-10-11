using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace IceCreamShop_V2
{
    public partial class CustomersForm : Form
    {
        public CustomersForm()
        {
            InitializeComponent();
        }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(local); integrated security=SSPI; Database=IceCreamOrders";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string sqlString = "Insert Into Customers (CustomerID, Firstname, Lastname, Email) Values (" 
                + "'" + textBoxCustomerID.Text + "'" + ","
                + "'" + textBoxFirstname.Text + "'" + ","
                + "'" + textBoxLastname.Text + "'" + ","
                + "'" + textBoxEmail.Text + "'" +","
                +  ")";

            SqlCommand command = new SqlCommand(sqlString, connection);

            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
