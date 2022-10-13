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
    public partial class CustomerTransactionsForm : Form
    {
        public CustomerTransactionsForm()
        {
            InitializeComponent();
        }

        private void CustomerTransactionsForm_Load(object sender, EventArgs e)
        {
            //Populate the DataGrid with all order transactions
            string connectionString = "Data Source=(local); integrated security=SSPI; Database=PapasPizza";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "Select * From Orders";

            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = command;

            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            DataTable dataTable = dataSet.Tables[0];

            dataGridViewCustomerTransactions.DataSource = dataTable;
            dataGridViewCustomerTransactions.Refresh();

            connection.Close();

            //Populate the list box with all existing customer IDs
            connectionString = "Data Source=(local); integrated security=SSPI; Database=PapasPizza";
            connection = new SqlConnection(connectionString);
            connection.Open();

            command = new SqlCommand();
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

        private void buttonCustomerTransactions_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(local); integrated security=SSPI; Database=PapasPizza";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "Select * From Orders Where CustomerID=" + "'" + listBoxCustomerIDs.SelectedItem.ToString() + "'";

            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = command;

            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            DataTable dataTable = dataSet.Tables[0];

            dataGridViewCustomerTransactions.DataSource = dataTable;
            dataGridViewCustomerTransactions.Refresh();
        }
    }
}
