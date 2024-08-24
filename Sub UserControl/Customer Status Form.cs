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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace JD_Electronics_Application.Sub_UserControl
{
    public partial class User_Status_Form : Form
    {
        public User_Status_Form()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void User_Status_Form_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(" Data Source=DESKTOP-UIDFTHQ;Initial Catalog=JD_COMPUTER_LOCAL_005;Integrated Security=True");
        }

        private void button2_Click(object sender, EventArgs e)
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
                    textBox5.Text = reader["customerType"].ToString();
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


                    da = new SqlDataAdapter("SELECT * from customer where customerID like '%c%'",con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();
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
