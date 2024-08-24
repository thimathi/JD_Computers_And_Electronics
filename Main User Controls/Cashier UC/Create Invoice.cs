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

namespace JD_Electronics_Application.Main_User_Controls.Cashier_UC
{
    public partial class Create_Invoice : UserControl
    {
        private SqlConnection connection;
        private List<Item> items = new List<Item>();
        private string connectionString = "Data Source=DESKTOP-UIDFTHQ;Initial Catalog=JD_COMPUTER_LOCAL_005;Integrated Security=True";
        private SqlDataAdapter da;
        private double totalEstimatePrice = 0; 

        public Create_Invoice()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
        }
        private class Item
        {
            public string ItemID { get; set; }
            public int Quantity { get; set; }
            public double SellingPricePerUnit { get; set; }
        }
        private void Create_Invoice_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT totalEstimatePrice FROM BillESIMATE WHERE billID = @BillID", connection);
                cmd.Parameters.AddWithValue("@BillID", textBox17.Text);
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    double totalEstimate = Convert.ToDouble(result);
                    double discountRate = Convert.ToDouble(textBox1.Text);
                    totalEstimatePrice = totalEstimate * (1 - (discountRate / 100));
                    textBox2.Text = totalEstimatePrice.ToString();
                }
                else
                {
                    MessageBox.Show("Bill ID not found!");
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

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO JD_INVOICE (billID, customerType, cusID,itemID,availableQTY,discountRate,totalEstimatePrice) VALUES (@BillID, @CustomerType, @CusID,@itemID,@availableQTY,@discountRate,@totalEstimatePrice); SELECT SCOPE_IDENTITY()", connection);
                cmd.Parameters.AddWithValue("@BillID", textBox17.Text);
                cmd.Parameters.AddWithValue("@CustomerType", comboBox3.Text);
                cmd.Parameters.AddWithValue("@CusID", textBox18.Text);
                cmd.Parameters.AddWithValue("@itemID",textBox7.Text);
                cmd.Parameters.AddWithValue("@availableQTY", textBox4.Text);
                cmd.Parameters.AddWithValue("@discountRate", textBox1.Text);
                cmd.Parameters.AddWithValue("@totalEstimatePrice", textBox2.Text);
                

                foreach (Item item in items)
                {
                    SqlCommand insertItemCmd = new SqlCommand("INSERT INTO SOLDSTOCKS (itemID, soldQTY, discountRate, totalSold) VALUES ( @ItemID, @SoldQTY, @DiscountRate, @TotalSold)", connection);
                    
                    insertItemCmd.Parameters.AddWithValue("@ItemID", item.ItemID);
                    insertItemCmd.Parameters.AddWithValue("@SoldQTY", item.Quantity);
                    insertItemCmd.Parameters.AddWithValue("@DiscountRate", textBox1.Text);
                    insertItemCmd.Parameters.AddWithValue("@TotalSold", totalEstimatePrice);
                    insertItemCmd.ExecuteNonQuery();
                }

                MessageBox.Show("Invoice created successfully!");
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

        private void button5_Click(object sender, EventArgs e)
        {
            textBox16.Clear();
            textBox2.Clear();
            textBox18.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox15.Clear();
            textBox1.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox17.Clear();

        }
    }
}
