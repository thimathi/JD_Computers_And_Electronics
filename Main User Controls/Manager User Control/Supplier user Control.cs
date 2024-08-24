using Microsoft.Reporting.Map.WebForms.BingMaps;
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
    public partial class Supplier_user_Control : UserControl
    {
        public Supplier_user_Control()
        {
            InitializeComponent();
            getGrid1();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataAdapter dasales;

        private void Supplier_user_Control_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(" Data Source=DESKTOP-UIDFTHQ;Initial Catalog=JD_COMPUTER_LOCAL_005;Integrated Security=True");
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            String supplierID, supplierType, firstName, address, city, nic, location, email,company, product;
            int tel, positionID;

            

            try
            {
                supplierID = textBox2.Text;
                positionID = listBox2.SelectedIndex;
                supplierType = GetUserType(positionID);
                firstName = textBox3.Text;
                address = textBox10.Text;
                email = textBox5.Text;
                company = textBox17.Text;
                tel = Convert.ToInt32(textBox7.Text);

                con.Open();
                cmd = new SqlCommand("Insert INTO SUPPLIERS (supID,supName,email,tel,company,adress,supplierType) values (@a,@b,@c,@d,@e,@f,@g)", con);
                cmd.Parameters.AddWithValue("a", supplierID);
                cmd.Parameters.AddWithValue("b", firstName);
                cmd.Parameters.AddWithValue("c", email);
                cmd.Parameters.AddWithValue("d", tel);
                cmd.Parameters.AddWithValue("e", company);
                cmd.Parameters.AddWithValue("f", address);
                cmd.Parameters.AddWithValue("g", supplierType);




                int i = cmd.ExecuteNonQuery();

                if (i == 1)
                {
                    MessageBox.Show("Data Save Successfully !!!! New Supplier Added..!!");
                }
                else
                {
                    MessageBox.Show("Data Could not been Saved");
                    con.Close();
                    cmd.Dispose();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Found !!!!!" + ex.Message);
            }


    }

        private void btnclear_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            listBox2.Items.Clear();
            textBox3.Clear();
            textBox10.Clear();
            textBox5.Clear();
            textBox7.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                dasales = new SqlDataAdapter("Select item.itemID, supplier.SupplierID, supplier.nic, supplierSales.SalesQTY FROM ((item INNER JOIN supplier ON item.itemID = supplier.product) INNER JOIN supplierSales ON supplier.nic = supplierSales.SupplierNIC)", con);
                DataTable dt = new DataTable();
                dasales.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch( Exception ex )
            {
                MessageBox.Show("Error Found!!!!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox12.Clear();
            textBox11.Clear();
            textBox6.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                da = new SqlDataAdapter("Select * from supplier where supplierID = '" + textBox12.Text + "' AND company = '" + textBox11.Text+"' AND product = '" + textBox6.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Found, Please Try Again");
            }
        }



        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }
        private void  getGrid1()
        {
            con = new SqlConnection(" Data Source=DESKTOP-UIDFTHQ;Initial Catalog=JD_COMPUTER_LOCAL_005;Integrated Security=True");
            con.Open();
            SqlDataAdapter daAll = new SqlDataAdapter("Select * from SUPPLIERS ", con);
            DataTable dataTable = new DataTable();
            daAll.Fill(dataTable);
            dataGridView2.DataSource = dataTable;

        }
        private string GetUserType(int positionID)
        {
            switch (positionID)
            {
                case 0: return "Regular";
                case 1: return "Whole Sale";
                default: return "Unknown";
            }
        }
    }
}
