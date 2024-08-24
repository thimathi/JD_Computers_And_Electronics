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
    public partial class Stock_User_Control : UserControl
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        SqlCommand cmdQTY;
        SqlDataAdapter daAll;
        public Stock_User_Control()
        {
            InitializeComponent();
            ONLOAD();
        }
        
        private void Stock_User_Control_Load(object sender, EventArgs e)
        {


        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                if (textBox3.Text == "")
                {
                    MessageBox.Show("Please Enter Both Barcode and ITEMS Code !!!!");
                }
                else
                {
                    MessageBox.Show("Please Scan The Barcode !!!!!");
                }
            }
            else if (textBox3.Text == "")
            {
                if (textBox2.Text == "")
                {
                    MessageBox.Show("Please Enter Both Barcode and ITEMS Code");
                }
                else
                {
                    MessageBox.Show("Please Enter The ITEMS Code");
                }
            }
            else
            {
                cmd = new SqlCommand("Select ITEMSName from ITEMS where itemID = '" + textBox3.Text + "'", con);
                textBox5.Text = Convert.ToString(cmd);

                cmdQTY = new SqlCommand("Select qty from ITEMS where itemID = '" + textBox3.Text + "'", con);

                if (radioButton4.Checked == true)
                {
                    textBox1.Text = Convert.ToString(cmdQTY);
                }
                else if (radioButton5.Checked == true)
                {
                    textBox1.Text = "0";
                }

                try
                {
                    con.Open();
                    da = new SqlDataAdapter("Select * from ITEMS where itemID = '" + textBox3.Text + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error!!!!!");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            void SimulateScan()
            {

                Random rand = new Random();
                string barcode = rand.Next(100000, 999999).ToString();

                ProcessScannedBarcode(barcode);
            }

            void ProcessScannedBarcode(string barcode)
            {

                MessageBox.Show($"Scanned barcode: {barcode}");
            }

            SimulateScan();
        }

        public void ONLOAD()
        {
            con = new SqlConnection(" Data Source=DESKTOP-UIDFTHQ;Initial Catalog=JD_COMPUTER_LOCAL_005;Integrated Security=True");
            con.Open();
            daAll = new SqlDataAdapter("Select * from ITEMS where itemID Like '%i%'", con);
            DataTable dataTable = new DataTable();
            daAll.Fill(dataTable);
            dataGridView2.DataSource = dataTable;
            con.Close();
        }
    }
        
}

