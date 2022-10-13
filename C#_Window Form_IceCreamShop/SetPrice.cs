using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace IceCreamShop_V2
{
    public partial class SetPrice : Form
    {
        public SetPrice()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(local); integrated security=SSPI; Database=Price";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            
            string sqlString = "Insert Into Customers (Chocolate, Vanilla, Strawberry, Sprinkles, ChoppedNuts, Cherry) Values ("
                + "'" + textBoxChocolate.Text + "'" + ","
                + "'" + textBoxVanilla.Text + "'" + ","
                + "'" + textBoxStrawberry.Text + "'" + ","
                + "'" + textBoxSprinkles.Text + "'" + ","
                + "'" + textBoxChoppedNuts.Text + "'" + ","
                + "'" + textBoxCherry.Text + "'" 
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
