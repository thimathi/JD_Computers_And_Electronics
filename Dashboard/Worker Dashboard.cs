using JD_Electronics_Application.Home_Panel;
using JD_Electronics_Application.Main_User_Controls;
using JD_Electronics_Application.Main_User_Controls.Manager_User_Control;
using JD_Electronics_Application.Main_User_Controls.Worker_UC;

using JD_Electronics_Application.Sub_UserControl;
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

namespace JD_Electronics_Application.Dashboard
{
    public partial class Worker_Dashboard : Form
    {
        public Worker_Dashboard()
        {
            InitializeComponent();
            Home_Employee uc = new Home_Employee();
            GetOpenSession();
            addUsercontrols(uc);
            this.FormClosing += Form1_FormClosing;
        }
        private void addUsercontrols(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            EmployeeDashPanel.Controls.Clear();
            EmployeeDashPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        

        bool sidebarExpand = true;

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            {
                if (sidebarExpand)
                {
                    sidebar.Width -= 15;
                    if (sidebar.Width <= 52)
                    {
                        sidebarExpand = false;
                        sidebarTransition.Stop();
                    }
                }
                else
                {
                    sidebar.Width += 15;
                    if (sidebar.Width >= 230)
                    {
                        sidebarExpand = true;
                        sidebarTransition.Stop();

                    }
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home_Employee uc = new Home_Employee();
            addUsercontrols(uc);
        }

        private void btnFinancial_Click(object sender, EventArgs e)
        {
            Project_user_control uc = new Project_user_control();
            addUsercontrols(uc);
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            Worker_Item_UC uc = new Worker_Item_UC();
            addUsercontrols(uc);

        }


        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help_User_Control uc = new Help_User_Control();
            addUsercontrols(uc);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            logout();
        }

        private void btnCus_Click(object sender, EventArgs e)
        {

        }

        private void Employee_Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnProject_Click(object sender, EventArgs e)
        {
            Project_user_control uc=new Project_user_control();
            addUsercontrols(uc);
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            Schedule_UC_Employee uc=new Schedule_UC_Employee();
            addUsercontrols(uc);
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            Search_Result_user_control UC=new Search_Result_user_control();
            addUsercontrols(UC);
        }
        private void GetOpenSession()
        {
            string currentUID;
            try
            {
                string connectionString = @"Data Source=DESKTOP-8H5R6EE;Initial Catalog=JD_COMPUTER_LOCAL_001;Integrated Security=True";
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
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to End Session...?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                saveSession();
            }
            else
            {
                e.Cancel = true;
            }




        }
        private void saveSession()
        {
            string sessionstartID, CurrentUserID;
            try
            {

                string connectionString = @"Data Source=DESKTOP-8H5R6EE;Initial Catalog=JD_COMPUTER_LOCAL_001;Integrated Security=True";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {

                    conn.Open();
                    string querygetUID = "SELECT TOP 1 * FROM sessionStart ORDER BY sessionID DESC";
                    SqlCommand getUname = new SqlCommand(querygetUID, conn);
                    SqlDataReader dr1 = getUname.ExecuteReader();
                    if (dr1.Read() == true)
                    {
                        Debug.WriteLine("Current User ID found : ");
                        sessionstartID = dr1.GetValue(0).ToString();
                        CurrentUserID = dr1.GetValue(1).ToString();
                        dr1.Close();
                        try
                        {
                            string sessionQuery = "INSERT INTO sessionEnd (sessionStartID,userID) VALUES (@sessionSID,@user_Id)";
                            using (SqlCommand setUID = new SqlCommand(sessionQuery, conn))
                            {
                                setUID.Parameters.AddWithValue("@sessionSID", Convert.ToInt32(sessionstartID));
                                setUID.Parameters.AddWithValue("@user_ID", CurrentUserID);
                                int rowseffected = setUID.ExecuteNonQuery();
                                if (rowseffected > 0)
                                {
                                    Debug.WriteLine("Session Save Successfull...!!");

                                }
                                else
                                {
                                    MessageBox.Show("Session Save Faild..!!!!");

                                }


                            }

                        }
                        catch (Exception es)
                        {
                            MessageBox.Show("Session Data Gathering Error(Section_Final_2) : " + es);

                        }


                    }


                }

                // Cancel the form closing event

            }
            catch (Exception es1)
            {
                MessageBox.Show("Session Data Gathering Error(Section_Final_1) : " + es1);

            }

        }
        private void logout()
        {
            DialogResult result = MessageBox.Show("Are you sure you want to LOGOUT...?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                saveSession();
                this.Hide();
                Login_Form obj = new Login_Form();
                obj.Show();

            }
            else
            {
                MessageBox.Show("Resume Working...");

            }
        }
    }
}
