using JD_Electronics_Application.Dashboard;
using JD_Electronics_Application.Main_User_Controls.Manager_User_Control;
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

namespace JD_Electronics_Application.Main_User_Controls
{
    public partial class Home_ManagerUC : UserControl
    {
        public Home_ManagerUC()
        {
            InitializeComponent();
            GetOpenSession();


        }
        private void addUsercontrols(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            HomeManagerUC.Controls.Clear();
            HomeManagerUC.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Project_user_control uc = new Project_user_control(); 
            addUsercontrols(uc);

        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            Employee_User_Control uc = new Employee_User_Control();
            addUsercontrols(uc);
        }

        private void btnScheduler_Click(object sender, EventArgs e)
        {
            Schedule_UC_Employee uc=new Schedule_UC_Employee();
            addUsercontrols(uc);
        }

        private void btnFinancial_Click(object sender, EventArgs e)
        {
            Financial_User_control uc=new Financial_User_control();
            addUsercontrols(uc);
        }

        private void Home_Manager_Load(object sender, EventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Reports_User_Control uc=new Reports_User_Control();

            addUsercontrols(uc);
        }

        private void btnStocks_Click(object sender, EventArgs e)
        {
            Stock_User_Control uc=new Stock_User_Control();
            addUsercontrols(uc);
        }

        private void HomeManagerUC_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEmployee_Click_1(object sender, EventArgs e)
        {
            Employee_User_Control uc = new Employee_User_Control();
            addUsercontrols(uc);
        }

        private void btnStocks_Click_1(object sender, EventArgs e)
        {
            Stock_User_Control uc = new Stock_User_Control();
            addUsercontrols(uc);
        }

        private void btnReport_Click_1(object sender, EventArgs e)
        {
            Reports_User_Control uc = new Reports_User_Control();
            addUsercontrols(uc);
        }

        private void btnScheduler_Click_1(object sender, EventArgs e)
        {
            Schedule_user_control uc = new Schedule_user_control();
            addUsercontrols(uc);
        }

        private void btnFinancial_Click_1(object sender, EventArgs e)
        {
            Financial_User_control uc = new Financial_User_control();
            addUsercontrols(uc);
        }

        private void btnProject_Click(object sender, EventArgs e)
        {
            Project_user_control uc = new Project_user_control();
            addUsercontrols(uc);
        }

        private void btnUserAccount_Click(object sender, EventArgs e)
        {
            Employee_User_Control uc = new Employee_User_Control();
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

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
