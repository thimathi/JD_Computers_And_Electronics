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

namespace JD_Electronics_Application.Sub_UserControl
{
    public partial class Customer_Update_Form : Form
    {
        public Customer_Update_Form()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd;
        SqlCommand cmd2;

        private void Customer_Update_Form_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(" Data Source=DESKTOP-UIDFTHQ;Initial Catalog=JD_COMPUTER_LOCAL_005;Integrated Security=True");


        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT * FROM customer WHERE nic = @Nic", con);
                cmd.Parameters.AddWithValue("@Nic", txt_cus_ID.Text);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txt_cus_ID.Text = reader["customerID"].ToString();
                    txt_fname.Text = reader["firstName"].ToString();
                    txt_lname.Text = reader["lastName"].ToString();
                    txt_email.Text = reader["email"].ToString();
                    txt_tel.Text = reader["tel"].ToString();
                    txt_city.Text = reader["city"].ToString();
                    txt_nic.Text = reader["nic"].ToString();
                    textBox10.Text = reader["address"].ToString();
                    txtPwd.Text = reader["location"].ToString();

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

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            String customerType = "";
            String gender = "";

            if (comboBox1.SelectedIndex == 0)
            {
                customerType = "Regular Customer";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                customerType = "Loyalty Customer";
            }
            else
            {
                customerType = "Other";
            }

            if (radioButton4.Checked == true)
            {
                gender = "Male";
            }
            else if (radioButton5.Checked == true)
            {
                gender = "Female";
            }
            else if (radioButton6.Checked == true)
            {
                gender = "Prefer Not To Say";
            }

            try
            {
                cmd2 = new SqlCommand("Update customer set customerID = '" + txt_cus_ID.Text + "', customerType = '" + customerType + "', firstName = '" + txt_fname.Text + "', lastName ='" + txt_lname.Text + "', email = '" + txt_email.Text + "', tel = '" + txt_tel.Text + "', city = '" + txt_city.Text + "', nic ='" + txt_nic.Text + "', address='" + textBox10.Text + "',location = '" + txtPwd.Text + "',dob = '" + dateTimePicker1.Value + "', regDate = '" + dateTimePicker4.Value + "', gender = '" + gender + "'");
                int i = cmd2.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("Data Updated Successfully");
                }
                else
                {
                    MessageBox.Show("Data Could not been updated");
                    con.Close();
                    cmd2.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txt_cus_ID.Clear();
            txt_fname.Clear();
            txt_lname.Clear();
            txt_email.Clear();
            txt_tel.Clear();
            txt_city.Clear();
            txt_nic.Clear();
            textBox10.Clear();
            txtPwd.Clear();
        }
    }
}

