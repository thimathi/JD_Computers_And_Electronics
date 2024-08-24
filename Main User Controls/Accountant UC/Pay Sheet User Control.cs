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
using System.IO;
using Microsoft.VisualBasic;

namespace JD_Electronics_Application.Main_User_Controls.Accountant_UC
{
    public partial class Pay_Sheet_User_Control : UserControl
    {
        public Pay_Sheet_User_Control()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
        private void Pay_Sheet_User_Control_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-UIDFTHQ;Initial Catalog=JD_COMPUTER_LOCAL_005;Integrated Security=True");
            GenerateNextPaySheetID();
        }
        String empID, empName, userType;
        double basicSalary, finalbasicSalary; 
        double incentive , hourRate, etf;
        int workDays, otHours, positionIndex;
        DateTime month;

        private void button4_Click(object sender, EventArgs e)
        {
            String empID, empName, userType;
            double basicSalary, incentive, hourRate, etf, totalSalary;
            int workDays, otHours, positionIndex;
            DateTime month;

            empID = textBox4.Text;
            empName = textBox1.Text;
            positionIndex = comboBox1.SelectedIndex;
            userType = "";

            switch (positionIndex)
            {
                case 0:
                    userType = "Manager";
                    break;
                case 1:
                    userType = "Accountant";
                    break;
                case 2:
                    userType = "Cashier";
                    break;
                case 3:
                    userType = "Site Engineer";
                    break;
                case 4:
                    userType = "Stock Manager";
                    break;
                case 5:
                    userType = "Worker";
                    break;

            }
            month = dateTimePicker1.Value;
            basicSalary = Convert.ToDouble(textBox8.Text);
            double creditPrice = 100.00;
            incentive = (creditPrice * Convert.ToDouble(textBox5.Text));
            workDays = Convert.ToInt32(textBox3.Text);
            otHours = Convert.ToInt32(textBox2.Text);
            hourRate = Convert.ToInt32(textBox6.Text);
            etf = Convert.ToDouble(textBox7.Text);
            totalSalary = Convert.ToDouble(label17.Text);

            try
            {
                con.Open();
                cmd = new SqlCommand("INSERT INTO JD_EMPLOYEE_PAYSHEET (empID, empName, userType, month, basicSalary, incentive, workDays, otHours, hourRate, etf, totalSalary) VALUES (@a, @b, @c, @d, @e, @f, @g, @h, @i, @j, @k)", con);
                cmd.Parameters.AddWithValue("a", empID);
                cmd.Parameters.AddWithValue("b", empName);
                cmd.Parameters.AddWithValue("c", userType);
                cmd.Parameters.AddWithValue("d", month);
                cmd.Parameters.AddWithValue("e", basicSalary);
                cmd.Parameters.AddWithValue("f", incentive);
                cmd.Parameters.AddWithValue("g", workDays);
                cmd.Parameters.AddWithValue("h", otHours);
                cmd.Parameters.AddWithValue("i", hourRate);
                cmd.Parameters.AddWithValue("j", etf);
                cmd.Parameters.AddWithValue("k", totalSalary);

                int i = cmd.ExecuteNonQuery();

                if(i == 1)
                {
                    MessageBox.Show("Data Save Successfully !");
                }
                else
                {
                    MessageBox.Show("Data Could not been Saved !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }


            string paySheetID = paySheet_txt.Text;

            if (!string.IsNullOrEmpty(paySheetID))
            {
                try
                {
                    con.Open();
                    string query = "SELECT TOP 1 * FROM JD_EMPLOYEE_PAYSHEET WHERE paysheetID = @paySheetID ORDER BY paysheetID DESC";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@paySheetID", paySheetID);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        DataTable data = new DataTable();
                        data.Load(reader);

                        paySheetReport psr = new paySheetReport();
                        psr.SetDataSource(data); // Pass the retrieved data to the report

                        crystalReportViewer1.ReportSource = psr; // Set the report source
                    }
                    else
                    {
                        MessageBox.Show("Report Not Found !!!!!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Payment Sheet ID is invalid !!!!");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            empID = textBox4.Text;
            empName = textBox1.Text;
            positionIndex = comboBox1.SelectedIndex;
            month = dateTimePicker1.Value;
            basicSalary = 0.00;
            userType = "";

            switch (positionIndex)
            {
                case 0:
                    userType = "Manager";
                    basicSalary = 50000.00;
                    break;
                case 1:
                    userType = "Accountant";
                    basicSalary = 30000.00;
                    break;
                case 2:
                    userType = "Cashier";
                    basicSalary = 25000.00;
                    break;
                case 3:
                    userType = "Site Engineer";
                    basicSalary = 50000.00;
                    break;
                case 4:
                    userType = "Stock Manager";
                    basicSalary = 50000.00;
                    break;
                case 5:
                    userType = "Worker";
                    basicSalary = 20000.00;
                    break;

            }
            textBox8.Text = Convert.ToString(basicSalary);

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            finalbasicSalary = Convert.ToDouble(textBox8.Text);
            double creditPrice = 100.00;
            incentive = (creditPrice * Convert.ToDouble(textBox5.Text));
            workDays = Convert.ToInt32(textBox3.Text);
            otHours = Convert.ToInt32(textBox2.Text);
            hourRate = Convert.ToInt32(textBox6.Text);
            etf = Convert.ToDouble(textBox7.Text);
            double otIncome = Convert.ToDouble(otHours * hourRate * workDays);

            double totSalary = finalbasicSalary + incentive + etf + otIncome;
            label17.Text = Convert.ToString(totSalary);

            

        }




        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            textBox1.Clear();
            textBox8.Clear();
            textBox5.Clear();
            textBox3.Clear();
            textBox2.Clear();
            textBox6.Clear();
            textBox7.Clear();
        }

        private void GenerateNextPaySheetID()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT ISNULL(MAX(paysheetID), 0) + 1 FROM JD_EMPLOYEE_PAYSHEET", con);
                int nextPaySheetID = (int)cmd.ExecuteScalar();
                paySheet_txt.Text = nextPaySheetID.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating next paysheet ID: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

    }
}
