using JD_Electronics_Application.Main_User_Controls;
using JD_Electronics_Application.Main_User_Controls.Cashier_UC;
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
    public partial class Home_Employee : UserControl
    {
        public Home_Employee()
        {
            InitializeComponent();
            GetOpenSession();
        }

        private void addUsercontrols(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            HomeWorkerPanel.Controls.Clear();
            HomeWorkerPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            Add_Customer uc=new Add_Customer();
            addUsercontrols(uc);
        }

        private void btnProject_Click(object sender, EventArgs e)
        {
            Project_user_control uc = new Project_user_control();
            addUsercontrols(uc);
        }

        private void btnEstimate_Click(object sender, EventArgs e)
        {
            Bill_Estimate uc=new Bill_Estimate();
            addUsercontrols(uc);
        }

        private void btnStocks_Click(object sender, EventArgs e)
        {
            Stock_User_Control uc=new Stock_User_Control();
            addUsercontrols(uc);
        }

        private void btnScheduler_Click(object sender, EventArgs e)
        {
            Schedule_UC_Employee uc=new Schedule_UC_Employee();
            addUsercontrols(uc);
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
