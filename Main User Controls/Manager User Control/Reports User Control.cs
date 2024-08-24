
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using JD_Electronics_Application.Main_User_Controls.Reports;
using JD_Electronics_Application.Main_User_Controls.Manager_User_Control;


namespace JD_Electronics_Application.Main_User_Controls
{
    public partial class Reports_User_Control : UserControl
    {
        public Reports_User_Control()
        {
            InitializeComponent();
        }

        private void Reports_User_Control_Load(object sender, EventArgs e)
        {

        }

        private void btnGenarate_Click(object sender, EventArgs e)
        {
           
                // Clear previous report controls from the panel
                panel4.Controls.Clear();

                if (comboBox2.SelectedIndex == 3)
                {
                    Business_Analyst_Report obj = new Business_Analyst_Report();
                    panel4.Controls.Add(obj);
                }
                else if (comboBox2.SelectedIndex == 1)
                {
                    Stock_Buying_Report obj = new Stock_Buying_Report();
                    panel4.Controls.Add(obj);
                }
                else if (comboBox2.SelectedIndex == 2)
                {
                    User_Login_Credential_Report obj = new User_Login_Credential_Report();
                    panel4.Controls.Add(obj);
                }
                else
                {
                    Available_Stock_Report available_Stock_Report = new Available_Stock_Report();
                    panel4.Controls.Add(available_Stock_Report);
                }
            }


        

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

 
    }
}
