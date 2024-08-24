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
using System.Windows.Media;

namespace JD_Electronics_Application.Main_User_Controls.Cashier_UC
{
    public partial class Bill_Estimate : UserControl
    {
        private SqlConnection connection;
        private List<Item> items = new List<Item>();
        private string connectionString = "Data Source=DESKTOP-UIDFTHQ;Initial Catalog=JD_COMPUTER_LOCAL_005;Integrated Security=True";
        private SqlDataAdapter da;

        public Bill_Estimate()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private class Item
        {
            public string ItemID { get; set; }
            public int Quantity { get; set; }
            public double SellingPricePerUnit { get; set; }
        }


        private void Bill_Estimate_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-UIDFTHQ;Initial Catalog=JD_COMPUTER_LOCAL_005;Integrated Security=True");
            try
            {

                con.Open();
                da = new SqlDataAdapter("Select * from BillESIMATE", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Fetch item details and add to items list
            if (textBox1.Text != "" && textBox4.Text != "" && int.TryParse(textBox4.Text, out int buyEstimateQty))
            {
                string query = "SELECT sellingPricePerUnit FROM STOCKBUYING WHERE itemID = @itemID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@itemID", textBox1.Text);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        double sellingPricePerUnit = Convert.ToDouble(result);
                        items.Add(new Item { ItemID = textBox1.Text, Quantity = buyEstimateQty, SellingPricePerUnit = sellingPricePerUnit });

                        // Update DataGridView or any UI to display added items
                        UpdateDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Selling price not found for the selected item.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Please enter valid values for item ID and buy estimate quantity.");
            }

            // Clear input fields
            textBox1.Clear();
            textBox4.Clear();
        }

        private void UpdateDataGridView()
        {
            // Update DataGridView with items list
            DataTable dt = new DataTable();
            dt.Columns.Add("Item ID");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("Price");

            foreach (Item item in items)
            {
                double itemValue = item.SellingPricePerUnit * item.Quantity;
                dt.Rows.Add(item.ItemID, item.Quantity, itemValue);
            }

            dataGridView1.DataSource = dt;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Calculate total estimate bill
            double totalEstimatePrice = 0;
            foreach (Item item in items)
            {
                totalEstimatePrice += item.SellingPricePerUnit * item.Quantity;
            }

            // Display total estimate bill
            label13.Text = totalEstimatePrice.ToString();

            // Clear input fields
            textBox7.Clear();
            txt_cus_ID.Clear();
            items.Clear(); // Clear items list after generating bill
            UpdateDataGridView(); // Update DataGridView to reflect cleared items list
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Clear input fields
            textBox1.Clear();
            textBox4.Clear();
            textBox7.Clear();
            txt_cus_ID.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT availableQTY FROM AvailableSTOCKS WHERE itemID = @itemID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@itemID", textBox1.Text);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    textBox2.Text = reader["availableQTY"].ToString();
                }
                else
                {
                    textBox2.Text = "0"; // Item not found or not available
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void txt_cus_ID_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT customerType FROM JD_CUSTOMERS WHERE customerID = @customerID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@customerID", textBox3.Text);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    comboBox4.Text = reader["customerType"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
