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
    public partial class Show_Reset_Form_user_control : UserControl
    {
        public Show_Reset_Form_user_control()
        {
            InitializeComponent();
        }

        private void btnbtnUpdate_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-UIDFTHQ;Initial Catalog=JD_COMPUTER_LOCAL_005;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    //string query2 = ""

                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Reset Passward Error..!" + Ex.Message);

                }
            }
        }
    }
}
