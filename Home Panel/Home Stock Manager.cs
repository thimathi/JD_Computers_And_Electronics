using JD_Electronics_Application.Main_User_Controls;
using JD_Electronics_Application.Main_User_Controls.Cashier_UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace JD_Electronics_Application.Home_Panel
{
    public partial class Home_Stock_Manager : UserControl
    {
        public Home_Stock_Manager()
        {
            InitializeComponent();
            FillChart();
            GetOpenSession();
        }
        private void addUsercontrols(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            HomeStockManagerPanel.Controls.Clear();
            HomeStockManagerPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void HomeStockManagerPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void btnISupplier_Click(object sender, EventArgs e)
        {
            Supplier_user_Control uc=new Supplier_user_Control();
            addUsercontrols(uc);
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnStocks_Click(object sender, EventArgs e)
        {
            Stock_User_Control uc=new Stock_User_Control();
            addUsercontrols(uc);
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btnEstimate_Click(object sender, EventArgs e)
        {
            Return_Item uc=new Return_Item();
            addUsercontrols (uc);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnScheduler_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            Item_UC_StcokManager uc=new Item_UC_StcokManager();
            addUsercontrols(uc);

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void chart3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnScan_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnFind_Click(object sender, EventArgs e)
        {

        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        void FillChart()
        {

            // Fill chart3
            using (SqlConnection con3 = new SqlConnection("Data Source=DESKTOP-UIDFTHQ;Initial Catalog=JD_COMPUTER_LOCAL_005;Integrated Security=True"))
            {
                DataTable dt3 = new DataTable();
                con3.Open();
                SqlDataAdapter da3 = new SqlDataAdapter("SELECT itemID, availableQTY FROM AvailableSTOCKS", con3);
                da3.Fill(dt3);
                chart3.DataSource = dt3;
                con3.Close();

                chart3.Series["ITEM"].XValueMember = "itemID";
                chart3.Series["ITEM"].YValueMembers = "availableQTY";
                chart3.Titles.Add("Current Stock Available");
            }
        }


        private void GetOpenSession()
        {
            string currentUID;
            try
            {
                string connectionString = @"Data Source=DESKTOP-UIDFTHQ;Initial Catalog=JD_COMPUTER_LOCAL_005;Integrated Security=True";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string querygetUID = "SELECT TOP 1 * FROM sessionStart ORDER BY sessionID DESC";
                    SqlCommand getUname = new SqlCommand(querygetUID, conn);
                    SqlDataReader dr1 = getUname.ExecuteReader();
                    if (dr1.Read() == true)
                    {
                        currentUID = dr1.GetValue(1).ToString();
                        Debug.WriteLine("Current User ID found : " + currentUID);
                        dr1.Close();

                        try
                        {
                            string querySetName = "SELECT * FROM JD_USERS WHERE userID = @user_ID";
                            using (SqlCommand setData = new SqlCommand(querySetName, conn))
                            {
                                setData.Parameters.AddWithValue("@user_ID", currentUID);
                                SqlDataReader dr2 = setData.ExecuteReader();
                                if (dr2.Read() == true)
                                {
                                    Debug.WriteLine("Current User Name found " + dr2.GetValue(1).ToString());
                                    label1.Text = dr2.GetValue(1).ToString();

                                    dr2.Close();

                                }
                                else
                                {
                                    MessageBox.Show("Session Data Gathering Error(SECTION_2)...!");

                                }
                            }

                        }
                        catch (Exception ex1)
                        {
                            MessageBox.Show("Session Data Gathering Error(Section_2) : " + ex1);

                        }


                    }
                    else
                    {
                        MessageBox.Show("Session Data Gathering Error...!");
                    }
                    conn.Close();

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Session Data Gathering Error(Section_1) : " + ex);
            }




        }


        }


}
