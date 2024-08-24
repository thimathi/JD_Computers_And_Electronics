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

namespace JD_Electronics_Application
{
    public partial class Reset_Password : Form
    {
        public Reset_Password()
        {
            InitializeComponent();
        }


        private void addUsercontrols(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            ResetFormPanel.Controls.Clear();
            ResetFormPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            String username = txtUserName.Text;
            String nic = txtNIC.Text;

            string connectionString = "Data Source=DESKTOP-UIDFTHQ;Initial Catalog=JD_COMPUTER_LOCAL_005;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT COUNT(*) FROM JD_USERS WHERE tpNO = @username AND NIC = @nic";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@username", Convert.ToInt32(username));
                        cmd.Parameters.AddWithValue("@nic", nic);

                        int count = (int)cmd.ExecuteScalar();
                        if (count > 0)
                        {
                            Show_Reset_Form_user_control uc = new Show_Reset_Form_user_control();
                            addUsercontrols(uc);
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or NIC");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Form obj = new Login_Form();
            obj.Show();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void ResetFormPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNIC_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void login_label_Click(object sender, EventArgs e)
        {

        }

        private void watermark_footer_Click(object sender, EventArgs e)
        {

        }
    }
}
