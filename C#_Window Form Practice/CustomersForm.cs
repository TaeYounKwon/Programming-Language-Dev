using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example_07
{
    public partial class CustomersForm : Form
    {
        public CustomersForm()
        {
            InitializeComponent();
        }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            //Write record to database table
            string connectionString = "Data Source=(local); integrated security=SSPI; Database=PapasPizza";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string sqlString = "Insert Into Customers (CustomerID, Firstname, Lastname, Email) Values ("
                + "'" + textBoxCustomerID.Text + "'" + ","
                + "'" + textBoxFirstname.Text + "'" + ","
                + "'" + textBoxLastname.Text + "'" + ","
                + "'" + textBoxEmail.Text + "'"
                + ")";

            SqlCommand command = new SqlCommand(sqlString, connection);
            //or
            //command.Connection = connection;
            //command.CommandText = sqlString;

            command.ExecuteNonQuery();

            connection.Close();
        }
    }
}
