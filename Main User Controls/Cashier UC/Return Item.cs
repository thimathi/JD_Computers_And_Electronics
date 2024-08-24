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

namespace JD_Electronics_Application.Main_User_Controls.Cashier_UC
{
    public partial class Return_Item : UserControl
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;


        public Return_Item()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-UIDFTHQ;Initial Catalog=JD_COMPUTER_LOCAL_005;Integrated Security=True");
        }

        private void btnScanItem_Click(object sender, EventArgs e)
        {

        }

        private void btnScanCus_Click(object sender, EventArgs e)
        {

        }

        private void Return_Item_Load(object sender, EventArgs e)
        {

        }
    }
}
