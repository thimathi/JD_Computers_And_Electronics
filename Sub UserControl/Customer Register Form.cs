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
    public partial class Customer_Register_Form : Form
    {
        public Customer_Register_Form()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;

        private void txtPwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void Customer_Register_Form_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(" Data Source=DESKTOP-UIDFTHQ;Initial Catalog=JD_COMPUTER_LOCAL_005;Integrated Security=True");
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            String customerID = textBox2.Text;
            String customerType = "";

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

            String firstName = textBox3.Text;
            String lastName = textBox4.Text;
            String email = textBox5.Text;
            String tel = textBox7.Text;
            String city = textBox8.Text;
            String nic = textBox9.Text;
            String address = textBox10.Text;
            String location = textBox1.Text;
            String dob = Convert.ToString(dateTimePicker1.Value);
            String gender = "";

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
                con.Open();
                cmd = new SqlCommand("Insert into customer values (@a,@b,@c,@d,@e,@f,@g,@h,@i,@j,@k,@l,@m)",con);
                cmd.Parameters.AddWithValue("a",customerID);
                cmd.Parameters.AddWithValue("b",customerType);
                cmd.Parameters.AddWithValue("c", firstName);
                cmd.Parameters.AddWithValue("d", lastName);
                cmd.Parameters.AddWithValue("e", email);
                cmd.Parameters.AddWithValue("f", tel);
                cmd.Parameters.AddWithValue("g", city);
                cmd.Parameters.AddWithValue("h", nic);
                cmd.Parameters.AddWithValue("i", address);
                cmd.Parameters.AddWithValue("j", location);
                cmd.Parameters.AddWithValue("k", dob);
                cmd.Parameters.AddWithValue("l", gender);

                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("Data Save Successfully !!!!");
                }
                else
                {
                    MessageBox.Show("Data Could not been saved !!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();

        }
    }
}
