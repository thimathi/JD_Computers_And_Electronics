using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace JD_Electronics_Application.Sub_UserControl
{
    public partial class Profile_User_Control : UserControl
    {
        private string currentUID;

        public Profile_User_Control()
        {
            InitializeComponent();
            GetOpenSession();
            SidebarDetails();
        }

        private void GetOpenSession()
        {
            try
            {
                string connectionString = @"Data Source=DESKTOP-UIDFTHQ;Initial Catalog=JD_COMPUTER_LOCAL_005;Integrated Security=True";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string querygetUID = "SELECT TOP 1 userID FROM sessionStart ORDER BY sessionID DESC";
                    SqlCommand getUname = new SqlCommand(querygetUID, conn);
                    SqlDataReader dr1 = getUname.ExecuteReader();
                    if (dr1.Read())
                    {
                        currentUID = dr1.GetString(0);
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
                        MessageBox.Show("Session Data Gathering Error: No user ID found!");
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Session Data Gathering Error: " + ex.Message);
            }
        }

        private void SidebarDetails()
        {
            try
            {
                string connectionString = @"Data Source=DESKTOP-UIDFTHQ;Initial Catalog=JD_COMPUTER_LOCAL_005;Integrated Security=True";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    // Retrieve user details
                    string queryGetUserDetails = "SELECT userID, adress, email, tpNO FROM JD_USERS WHERE userID = @userID";
                    using (SqlCommand getUserData = new SqlCommand(queryGetUserDetails, conn))
                    {
                        getUserData.Parameters.AddWithValue("@userID", currentUID);
                        using (SqlDataReader dr4 = getUserData.ExecuteReader())
                        {
                            if (dr4.Read())
                            {
                                label5.Text = dr4.IsDBNull(0) ? "NULL" : dr4.GetString(0); // userID
                                label4.Text = dr4.IsDBNull(1) ? "NULL" : dr4.GetString(1); // adress
                                label9.Text = dr4.IsDBNull(2) ? "NULL" : dr4.GetString(2); // email
                                label11.Text = dr4.GetValue(3).ToString();
                            }
                            else
                            {
                                MessageBox.Show("User data not found!");
                            }
                        }
                    }

                    // Retrieve employee details
                    string queryGetEmployeeDetails = "SELECT currentOccupation, currentWorkingBranch FROM JD_employes WHERE userID = @user_ID";
                    using (SqlCommand getEmployeeData = new SqlCommand(queryGetEmployeeDetails, conn))
                    {
                        getEmployeeData.Parameters.AddWithValue("@user_ID", currentUID);
                        using (SqlDataReader dr5 = getEmployeeData.ExecuteReader())
                        {
                            if (dr5.Read())
                            {
                                label2.Text = dr5.IsDBNull(0) ? "NULL" : dr5.GetString(0); // currentOccupation
                                label8.Text = dr5.IsDBNull(1) ? "NULL" : dr5.GetString(1); // currentWorkingBranch
                            }
                            else
                            {
                                MessageBox.Show("Employee data not found!");
                            }
                        }
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
