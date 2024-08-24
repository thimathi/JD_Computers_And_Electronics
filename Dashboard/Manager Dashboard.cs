using JD_Electronics_Application.Main_User_Controls;
using JD_Electronics_Application.Main_User_Controls.Worker_UC;
using JD_Electronics_Application.Main_User_Controls.Manager_User_Control;
using JD_Electronics_Application.Sub_UserControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JD_Electronics_Application.Dashboard;
using System.Data.SqlClient;
using System.Diagnostics;

namespace JD_Electronics_Application
{
    public partial class Manager_Dashboard : Form
    {
        public Manager_Dashboard()
        {
            InitializeComponent();
            GetOpenSession();
            Home_ManagerUC uc = new Home_ManagerUC();
            addUsercontrols(uc);
            this.FormClosing += Form1_FormClosing;

        }

        private void addUsercontrols(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            ManagerDashPanel.Controls.Clear();
            ManagerDashPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        bool menuExpand = false;

        public void timer1_Tick(object sender, EventArgs e)
        {

         if (menuExpand == false)
            {
                menuContainer.Height += 15;
                if(menuContainer.Height >= 155) 
                {
                    mainCon2.Stop();
                    menuExpand = true;
                }
            }  
         else
            {
                menuContainer.Height -= 15;
                if (menuContainer.Height <=45) {
                    mainCon2.Stop();
                    menuExpand=false;
                }
            }
        }
              

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void Admin_Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void home_button_Click(object sender, EventArgs e)
        {
            
        }

        private void workingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void left_menu_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            //mainCon2.Start();
            UserAccount_Panel_Form uc = new UserAccount_Panel_Form();
            addUsercontrols(uc);
        }



        bool sidebarExpand = true;
        
        
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            
        }
        private void button5_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }
        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home_ManagerUC uc = new Home_ManagerUC();
            addUsercontrols(uc);
        }

        private void sidebarTransition_Tick_1(object sender, EventArgs e)
        {
            {
                if (sidebarExpand)
                {
                    sidebar.Width -= 50;
                    if (sidebar.Width <= 52) {
                        sidebarExpand = false;
                        sidebarTransition.Stop();
                    }
                }
                else
                {
                    sidebar.Width += 50;
                    if (sidebar.Width >= 230)
                    {
                        sidebarExpand = true; 
                        sidebarTransition.Stop();
                        
                    }
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dash_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stock_User_Control uc = new Stock_User_Control();
            addUsercontrols(uc);
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            Employee_User_Control uc = new Employee_User_Control();
            addUsercontrols(uc);
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            Supplier_user_Control uc = new Supplier_user_Control();
            addUsercontrols(uc);
        }

        

        private void btnFinancial_Click(object sender, EventArgs e)
        {
            Financial_User_control uc=new Financial_User_control();
            addUsercontrols(uc);

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Reports_User_Control uc=new Reports_User_Control();
            addUsercontrols(uc);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help_User_Control uc=new Help_User_Control();
            addUsercontrols(uc);
        }

        private void btnLogout_Click(object sender, EventArgs e)
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

        private void ManagerDashPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listWorkspace_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistor_Click(object sender, EventArgs e)
        {
            Customer_Register_Form frm1=new Customer_Register_Form();
            frm1.Show();
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            Customer_Update_Form frm2=new Customer_Update_Form();
            frm2.Show();
        }

        private void btnCusStetus_Click(object sender, EventArgs e)
        {
            User_Status_Form frm3=new User_Status_Form();
            frm3.Show();

        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            Schedule_user_control uc=new Schedule_user_control();
            addUsercontrols(uc);

        }

        private void btnWorkers_Click(object sender, EventArgs e)
        {
            Worker_User_Control uc =new Worker_User_Control();
            addUsercontrols(uc);
        }

        private void btnfinancial_Click_1(object sender, EventArgs e)
        {
            Financial_User_control uc=new Financial_User_control();
            addUsercontrols (uc);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                
                case 0:
                    Cashier_Dashboard Cashier = new Cashier_Dashboard();
                    Cashier.Show();
                    break;
                
                case 1:
                    Stock_Manager_Dashboard StockManager = new Stock_Manager_Dashboard();
                    StockManager.Show();
                    break;
               
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            Search_Result_user_control uc=new Search_Result_user_control();
            addUsercontrols(uc);
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
    }
}
