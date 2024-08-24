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

namespace JD_Electronics_Application.Main_User_Controls.Administrator_User_Control
{
    public partial class Employee_UC_Admin : UserControl
    {
        public Employee_UC_Admin()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter da;
        SqlDataAdapter da1;
        SqlDataAdapter da2;
        private void Employee_UC_Admin_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(" Data Source=DESKTOP-UIDFTHQ;Initial Catalog=JD_COMPUTER_LOCAL_005;Integrated Security=True");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                da = new SqlDataAdapter("Select * from JD_USERS where uNIC = '" + textBox11.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                con.Open();
                da2 = new SqlDataAdapter("Select * from JD_USERS where fullName = '" + textBox1.Text + "'", con);
                DataTable dt = new DataTable();
                da2.Fill(dt);
                dataGridView1.DataSource = dt;
                
            }

            
            finally 
            { 
                con.Close(); 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                da1 = new SqlDataAdapter("Select * from JD_USERS where userID LIKE '%U%'", con);
                DataTable dt = new DataTable();
                da1.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox11.Clear();
        }
    }
}
