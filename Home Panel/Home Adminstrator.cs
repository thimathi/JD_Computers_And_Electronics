using JD_Electronics_Application.Main_User_Controls;
using JD_Electronics_Application.Main_User_Controls.Administrator_User_Control;
using JD_Electronics_Application.Main_User_Controls.Worker_UC;
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

namespace JD_Electronics_Application.Home_Panel
{
    public partial class Home_Adminstrator : UserControl
    {
        public Home_Adminstrator()
        {
            InitializeComponent();
            GetLiveSession();
            FillChart();
            GetOpenSession();
        }
        private void addUsercontrols(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            HomeAdminPanel.Controls.Clear();
            HomeAdminPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {

        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            Employee_UC_Admin uc = new Employee_UC_Admin();
            addUsercontrols(uc);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Reports_User_Control uc = new Reports_User_Control();
            addUsercontrols(uc);
        }

        private void btnScheduler_Click(object sender, EventArgs e)
        {
            Schedule_UC_Employee uc = new Schedule_UC_Employee();
            addUsercontrols(uc);
        }

        private void btnProject_Click(object sender, EventArgs e)
        {
            Project_user_control uc = new Project_user_control();
            addUsercontrols(uc);
        }

        private void btnFinancial_Click(object sender, EventArgs e)
        {
            Financial_User_control uc = new Financial_User_control();
            addUsercontrols(uc);
        }

        private void btnScheduler_Click_1(object sender, EventArgs e)
        {
            Schedule_UC_Employee uc = new Schedule_UC_Employee();
            addUsercontrols(uc);
        }

        private void btnEmployee_Click_1(object sender, EventArgs e)
        {
            Employee_UC_Admin uc = new Employee_UC_Admin();
            addUsercontrols(uc);
        }

        private void btnReport_Click_1(object sender, EventArgs e)
        {
            Reports_User_Control uc = new Reports_User_Control();
            addUsercontrols(uc);
        }

        private void btnFinancial_Click_1(object sender, EventArgs e)
        {
            Financial_User_control uc = new Financial_User_control();
            addUsercontrols(uc);
        }

        private void btnProject_Click_1(object sender, EventArgs e)
        {
            Project_user_control uc = new Project_user_control();
            addUsercontrols(uc);
        }


        private void GetLiveSession()
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

        private void profile_User_Control1_Load(object sender, EventArgs e)
        {

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

        void FillChart()
        {
            // Fill chart1
            using (SqlConnection con1 = new SqlConnection("Data Source=DESKTOP-UIDFTHQ;Initial Catalog=JD_COMPUTER_LOCAL_005;Integrated Security=True"))
            {
                DataTable dt1 = new DataTable();
                con1.Open();
                SqlDataAdapter da1 = new SqlDataAdapter("SELECT itemID, boughtQTY FROM STOCKBUYING", con1);
                da1.Fill(dt1);
                chart1.DataSource = dt1;
                con1.Close();

                chart1.Series["ITEM"].XValueMember = "itemID";
                chart1.Series["ITEM"].YValueMembers = "boughtQTY";
                chart1.Titles.Add("Current Stock Buying");
            }

            // Fill chart2
            using (SqlConnection con2 = new SqlConnection("Data Source=DESKTOP-UIDFTHQ;Initial Catalog=JD_COMPUTER_LOCAL_005;Integrated Security=True"))
            {
                DataTable dt2 = new DataTable();
                con2.Open();
                SqlDataAdapter da2 = new SqlDataAdapter("SELECT itemID, soldQTY FROM SOLDSTOCKS", con2);
                da2.Fill(dt2);
                chart2.DataSource = dt2;
                con2.Close();

                chart2.Series["ITEM"].XValueMember = "itemID";
                chart2.Series["ITEM"].YValueMembers = "soldQTY";
                chart2.Titles.Add("Current Stock Sold");
            }

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



        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
