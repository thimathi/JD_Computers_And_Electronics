using JD_Electronics_Application;
using JD_Electronics_Application.Dashboard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Diagnostics;

namespace JD_Electronics_Application
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;


        }

        private void btnLogin_Click(object sender, EventArgs e)        
        {
            String username, user_password;
          
            int user_positionID;

            username = txtUserName.Text;
            user_password = txtPwd.Text;
            user_positionID = comboBox1.SelectedIndex;


            string connectionString = @"Data Source=DESKTOP-UIDFTHQ;Initial Catalog=JD_COMPUTER_LOCAL_005;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM JD_userLoginCredentials WHERE userName = @username AND pwd = @password AND occupationINDEX = @positionID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                      
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", user_password);
                        cmd.Parameters.AddWithValue("@positionID", user_positionID);

                        int count = (int)cmd.ExecuteScalar();
                        if (count > 0)
                        {
                            switch (user_positionID)
                            {
                                case 0:
                                    CreateSession();
                                    System.Threading.Thread.Sleep(3500);
                                    AdministratorDashborad d = new AdministratorDashborad();
                                    d.Show();
                                    this.Hide();
                                  
                                    break;
                                case 1:
                                    CreateSession();
                                    System.Threading.Thread.Sleep(3500);
                                    Manager_Dashboard manager_Dashboard = new Manager_Dashboard();
                                    manager_Dashboard.Show();
                                    this.Hide();
                                    
                                    break;
                                case 2:
                                    CreateSession();
                                    System.Threading.Thread.Sleep(3500);
                                    Accountant_Dashboard accountant_Dashboard = new Accountant_Dashboard();
                                    accountant_Dashboard.Show();
                                    this.Hide();
                                    

                                    break;
                                case 3:
                                    CreateSession();
                                    System.Threading.Thread.Sleep(3500);
                                    Cashier_Dashboard cashier_Dashboard = new Cashier_Dashboard();
                                    cashier_Dashboard.Show();
                                    this.Hide();
                       
                                    break;
                                case 4:
                                    CreateSession();
                                    System.Threading.Thread.Sleep(3500);
                                    Site_Engineer_Dashboard site_Engineer_Dashboard = new Site_Engineer_Dashboard();
                                    site_Engineer_Dashboard.Show();
                                    this.Hide();
                                   

                                    break;
                                case 5:
                                    CreateSession();
                                    System.Threading.Thread.Sleep(3500);
                                    Stock_Manager_Dashboard stck_Manager_ = new Stock_Manager_Dashboard();
                                    stck_Manager_.Show();
                                    this.Hide();
                                    
                                    break;
                                case 6:
                                    CreateSession();
                                    System.Threading.Thread.Sleep(3500);
                                    Worker_Dashboard worker_Dashboard = new Worker_Dashboard();
                                    worker_Dashboard.Show();
                                    this.Hide();
                                  ;
                                    break;
                                default:
                                    MessageBox.Show("Invalid position selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    break;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid Login Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }
        

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void login_label_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void watermark_footer_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void forget_pwd_label_Click(object sender, EventArgs e)
        {
            Reset_Password d = new Reset_Password();
            d.Show();
            this.Hide();
        }

        private void txtPwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        { }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }

        private void CreateSession()
        {
           
            string userId;
            //Session Sql Commands-Start
            string connectionString = @"Data Source=DESKTOP-UIDFTHQ;Initial Catalog=JD_COMPUTER_LOCAL_005;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            try
            {
                //getuserid
                string query_1 = "SELECT * FROM JD_userLoginCredentials WHERE userName = @username AND pwd =@pwd";
                SqlCommand getUID = new SqlCommand(query_1, conn);
                getUID.Parameters.AddWithValue("@username", txtUserName.Text);
                getUID.Parameters.AddWithValue("@pwd", txtPwd.Text);
                SqlDataReader dr = getUID.ExecuteReader();
                if (dr.Read() == true)
                {

                    userId = dr.GetValue(1).ToString();
                    Debug.WriteLine(dr.GetValue(1).ToString());
                    dr.Close();
                    string sessionQuery = "INSERT INTO sessionStart (userID) VALUES (@user_ID)";
                    using (SqlCommand setUID = new SqlCommand(sessionQuery, conn))
                    {
                        setUID.Parameters.AddWithValue("@user_ID", userId);
                        int rowseffected = setUID.ExecuteNonQuery();
                        if (rowseffected >0)
                        {
                            Debug.WriteLine("Session Creation Successfull...!!");

                        }
                        else
                        {
                            MessageBox.Show("Session Creation Faild..!!!!");
                        }
                        


                    }
                    


                }
                else
                {
                    MessageBox.Show("Error Occuerd During CreatingThe Session..!!");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Session Creation Error : " + ex.Message);

            }
           
            
            
            //Session sql  Commands-End
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Your custom logic here
            // For example, ask the user for confirmation before closing
            DialogResult result = MessageBox.Show("Are you sure you want to close...?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true; // Cancel the form closing event
            }
        }
    }
}
