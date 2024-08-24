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
    public partial class Schedule_UC_Employee : UserControl
    {
        public Schedule_UC_Employee()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;

        private void Schedule_UC_Employee_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(" Data Source=DESKTOP-UIDFTHQ;Initial Catalog=JD_COMPUTER_LOCAL_005;Integrated Security=True");
            try
            {
                con.Open();
                da = new SqlDataAdapter("Select * from schedule where employeeID like '%E%'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        
        
        }
    }
}
