using JD_Electronics_Application.Sub_UserControl;
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

namespace JD_Electronics_Application.Main_User_Controls.Worker_UC
{
    public partial class Add_Customer : UserControl
    {
        public Add_Customer()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd;

        private void btnregister_Click(object sender, EventArgs e)
        {
            
            Customer_Register_Form obj = new Customer_Register_Form();
            obj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Customer_Update_Form obj = new Customer_Update_Form();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            User_Status_Form obj = new User_Status_Form();
            obj.Show();
        }

        private void txt_cus_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Customer_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(" Data Source=DESKTOP-UIDFTHQ;Initial Catalog=JD_COMPUTER_LOCAL_005;Integrated Security=True");
        }

        private void btncusSearch_Click(object sender, EventArgs e)
        {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("SELECT customerID, customerType, firstName FROM customer WHERE nic = @Nic AND tel = @Tel", con);
                    cmd.Parameters.AddWithValue("@Nic", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Tel", Convert.ToInt32(textBox3.Text));

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        textBox8.Text = reader["customerID"].ToString();
                        textBox10.Text = reader["customerType"].ToString();
                        textBox5.Text = reader["firstName"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Customer not found.");
                    }

                    reader.Close();
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

        private void btn_Click(object sender, EventArgs e)
        {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("SELECT * FROM customer WHERE nic = @Nic AND tel = @Tel", con);
                    cmd.Parameters.AddWithValue("@Nic", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Tel", Convert.ToInt32(textBox3.Text));

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txt_cus_ID.Text = reader["customerID"].ToString();
                        textBox9.Text = reader["customerType"].ToString();
                        txt_fname.Text = reader["firstName"].ToString();
                        txt_lname.Text = reader["lastName"].ToString();
                        txt_email.Text = reader["email"].ToString();
                        txt_tel.Text = reader["tel"].ToString();
                        txt_city.Text = reader["city"].ToString();
                        txt_nic.Text = reader["nic"].ToString();
                        textBox6.Text = reader["address"].ToString();
                        txtPwd.Text = reader["location"].ToString();
                        textBox1.Text = reader["dob"].ToString();
                        textBox4.Text = reader["regDate"].ToString();
                        textBox7.Text = reader["gender"].ToString();


                }
                    else
                    {
                        MessageBox.Show("Customer not found.");
                    }

                    reader.Close();
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

        }
    }
 

