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

namespace JD_Electronics_Application.Main_User_Controls
{
    public partial class Schedule_user_control : UserControl
    {
        public Schedule_user_control()
        {
            InitializeComponent();
        }
        SqlConnection connection;
        SqlCommand cmd;
        SqlDataAdapter da;

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker7_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void schedulertable_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Schedule_user_control_Load_1(object sender, EventArgs e)
        {
            connection = new SqlConnection(" Data Source=DESKTOP-UIDFTHQ;Initial Catalog=JD_COMPUTER_LOCAL_005;Integrated Security=True");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            connection = new SqlConnection(" Data Source=DESKTOP-UIDFTHQ;Initial Catalog=JD_COMPUTER_LOCAL_005;Integrated Security=True");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String employeeID, eventName, location;
            DateTime time, date;

            int rangeDate, rangeHour, rangeMinut;
            rangeDate = DateTime.Now.Day - dateTimePicker11.Value.Day;
            rangeHour = DateTime.Now.Hour - dateTimePicker11.Value.Hour;
            rangeMinut = DateTime.Now.Minute - dateTimePicker11.Value.Minute;

            employeeID = textBox1.Text;
            eventName = textBox2.Text;
            time = dateTimePicker11.Value;
            date = dateTimePicker12.Value;
            location = textBox8.Text;



            if(rangeDate <0 && rangeHour <0 && rangeMinut <0)
            {
                try
                {
                    connection.Open();
                    cmd = new SqlCommand("Insert into schedule values (@a,@b,@c,@d,@e)", connection);
                    cmd.Parameters.AddWithValue("a", employeeID);
                    cmd.Parameters.AddWithValue("b", eventName);
                    cmd.Parameters.AddWithValue("d", time);
                    cmd.Parameters.AddWithValue("c", date);
                    cmd.Parameters.AddWithValue("e", location);

                    int i = cmd.ExecuteNonQuery();

                    if (i == 1)
                    {
                        MessageBox.Show("Data Save Successfully !!!!");
                    }
                    else
                    {
                        MessageBox.Show("Data Save Unsuccessfully !!!!");
                    }

                    da = new SqlDataAdapter("Select * from schedule where employeeID = '" + textBox1.Text + "'", connection);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Found, Please Try Again !!!!");
                }

                finally
                {
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Cannot Create Schedule in past !!!");
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox8.Clear();
        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
