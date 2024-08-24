using Microsoft.ReportingServices.Diagnostics.Internal;
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

namespace JD_Electronics_Application.Main_User_Controls
{
    public partial class Financial_User_control : UserControl
    {
        public Financial_User_control()
        {
            InitializeComponent();
        }

        private void Financial_User_control_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCalculateIncome_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-UIDFTHQ;Initial Catalog=JD_COMPUTER_LOCAL_005;Integrated Security=True");
            SqlCommand cmd;

            DateTime fromDate = metroDateTime1.Value;
            DateTime toDate = metroDateTime2.Value;
            double serviceChargePercentage = 0.10;
            double avgPriceCharge = 500.0;
            double serviceCharge = 0;
            double totalSales = 0;
            int totalSold = 0;

            try
            {
                con.Open();

                string sqlQuery = "SELECT SUM(totalSold) AS TotalSold FROM SOLDSTOCKS WHERE soldDATE BETWEEN @fromDate AND @toDate";
                cmd = new SqlCommand(sqlQuery, con);
                cmd.Parameters.AddWithValue("@fromDate", fromDate);
                cmd.Parameters.AddWithValue("@toDate", toDate);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    if (reader["TotalSold"] != DBNull.Value)
                    {
                        totalSold = Convert.ToInt32(reader["TotalSold"]);
                        textBox8.Text = totalSold.ToString();

                        serviceCharge = (serviceChargePercentage * avgPriceCharge );

                        textBox5.Text = serviceCharge.ToString();
                        
                        totalSales = (totalSold * avgPriceCharge) + serviceCharge;
                        label10.Text = totalSales.ToString();
                    }
                    else
                    {
                        textBox8.Text = "0"; // No sales found
                        MessageBox.Show("No sales found for the specified date range.");

                        serviceCharge = 0.00;

                        textBox5.Text = serviceCharge.ToString();

                        totalSales = (totalSold * avgPriceCharge) + serviceCharge;
                        label10.Text = totalSales.ToString();

                    }
                }
                else
                {
                    textBox8.Text = "0"; // No sales found
                    MessageBox.Show("No sales found for the specified date range.");


                    serviceCharge = 0.00;

                    textBox5.Text = serviceCharge.ToString();

                    totalSales = (totalSold * avgPriceCharge) + serviceCharge;
                    label10.Text = totalSales.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            metroDateTime1.Value = DateTime.Now;
            metroDateTime2.Value = DateTime.Now;

            comboBox2.SelectedIndex = -1;
        }
    }


    }

