using JD_Electronics_Application.Sub_UserControl;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing.Text;
using System.Windows.Forms;

namespace JD_Electronics_Application.Main_User_Controls
{
    public partial class UserAccount_Panel_Form : UserControl
    {
        public UserAccount_Panel_Form()
        {
            InitializeComponent();
            LoadData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer_Register_Form obj = new Customer_Register_Form();
            obj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer_Update_Form obj = new Customer_Update_Form();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            User_Status_Form obj = new User_Status_Form();
            obj.Show();
        }

        public SqlConnection con;
        private SqlCommand cmd;
        private SqlDataAdapter da;

        private void UserAccount_Panel_Form_Load(object sender, EventArgs e)
        {
           
            
        }

        private void LoadData()
        {
            con = new SqlConnection("Data Source=DESKTOP-UIDFTHQ;Initial Catalog=JD_COMPUTER_LOCAL_005;Integrated Security=True");
            try
            {
                con.Open();
                da = new SqlDataAdapter("SELECT * FROM JD_USERS WHERE uNIC NOT LIKE '0%'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-UIDFTHQ;Initial Catalog=JD_COMPUTER_LOCAL_005;Integrated Security=True");
            string userID, userType, fullName ,userName, email,nic,empID,adress,pwd;
            int tel, positionID;
            DateTime Dob;

            userID = textBox4.Text;
            empID = textBox11.Text;
            fullName = textBox6.Text;
            positionID = comboBox1.SelectedIndex;
            userType = GetUserType(positionID);
            nic = textBox12.Text;
            tel = (int)Convert.ToInt64(textBox13.Text);
            email = textBox1.Text;
            adress = textBox14.Text;
            Dob = dateTimePicker4.Value;
            userName = textBox9.Text;
            pwd = textBox7.Text;
            
           
           

            try
            {
                con.Open();
                cmd = new SqlCommand("INSERT INTO JD_USERS (userID, fullName,uNIC,email,adress ,tpNO, dob) VALUES (@a, @b, @c, @d, @e, @f,@g)", con);
                cmd.Parameters.AddWithValue("@a", userID);
                cmd.Parameters.AddWithValue("@b", fullName);
                cmd.Parameters.AddWithValue("@c",nic);
                cmd.Parameters.AddWithValue("@d", email);
                cmd.Parameters.AddWithValue("@e", adress);
                cmd.Parameters.AddWithValue("@f", tel);
                cmd.Parameters.AddWithValue("@g", Dob);

                if (positionID != 0 || empID!="")
                {
                    SqlCommand cmd2 = new SqlCommand("INSERT INTO JD_employes (empID,userID,currentOccupation) VALUES (@h,@i,@j)", con);
                    cmd2.Parameters.AddWithValue("@h", empID);
                    cmd2.Parameters.AddWithValue("@i", userID);
                    cmd2.Parameters.AddWithValue("@j", userType);
                    int j = cmd2.ExecuteNonQuery();
                    addtoCredentials();

                }
                else
                {
                    addtoCredentials();

                }

                void addtoCredentials()
                {
                    SqlCommand cmd3 = new SqlCommand("INSERT INTO JD_userLoginCredentials (userID,userName,pwd,occupationINDEX) VALUES (@k,@l,@m,@n)", con);
                    cmd3.Parameters.AddWithValue("@k", userID);
                    cmd3.Parameters.AddWithValue("@l", userName);
                    cmd3.Parameters.AddWithValue("@m", pwd);
                    cmd3.Parameters.AddWithValue("@n", positionID);

                    int i = cmd.ExecuteNonQuery();

                    int k = cmd3.ExecuteNonQuery();

                    if (i == 1 && k == 1)
                    {
                        MessageBox.Show("Data Save Successfully");
                        LoadData(); // Refresh the data grid
                    }
                    else
                    {
                        MessageBox.Show("Data Save Failed");
                    }

                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private string GetUserType(int positionID)
        {
            switch (positionID)
            {
                case 0: return "Administrator";
                case 1: return "Manager";
                case 2: return "Accountant";
                case 3: return "Cashier";
                case 4: return "Site Engineer";
                case 5: return "Stock Manager";
                case 6: return "Worker";
                default: return "Unknown";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox4.Clear();
            textBox6.Clear();
            textBox12.Clear();
            textBox13.Clear();
        }

        private void btncusSearch_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-UIDFTHQ;Initial Catalog=JD_COMPUTER_LOCAL_005;Integrated Security=True");
            string nic = textBox2.Text;
            string tel = textBox3.Text;

            try
            {
                string userid;
                con.Open();
                string query = "SELECT userID,fullName FROM JD_USERS WHERE uNIC = @nic AND tpNO = @tel";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@nic", nic);
                cmd.Parameters.AddWithValue("@tel", tel);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        textBox8.Text = reader["userID"].ToString();
                        userid = reader["userID"].ToString();
                       
                        textBox5.Text = reader["fullName"].ToString();
                       
                        try
                        {
                            Debug.WriteLine("UserID is : " + userid);
                            SqlCommand cmd2 = new SqlCommand("SELECT * FROM JD_employes WHERE userID =@uid", con);
                            cmd2.Parameters.AddWithValue("@uid", userid);
                            SqlDataReader reader2 = cmd2.ExecuteReader();

                            
                            
                            if (reader2.Read())
                            {
                               textBox10.Text = reader2.GetValue(1).ToString();
                                Debug.WriteLine("User Occupation Found : " + reader2.GetValue(1).ToString());

                            }

                            

                        }
                        catch (Exception exe)
                        {

                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("No matching records found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-UIDFTHQ;Initial Catalog=JD_COMPUTER_LOCAL_005;Integrated Security=True");
            string nic = textBox2.Text;
            string tel = textBox3.Text;

            try
            {
                con.Open();
                da = new SqlDataAdapter("SELECT * FROM JD_USERS WHERE nic = @nic AND tel = @tel", con);
                da.SelectCommand.Parameters.AddWithValue("@nic", nic);
                da.SelectCommand.Parameters.AddWithValue("@tel", tel);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
