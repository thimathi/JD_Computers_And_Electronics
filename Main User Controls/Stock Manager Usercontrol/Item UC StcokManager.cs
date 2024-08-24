using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JD_Electronics_Application.Main_User_Controls
{
    public partial class Item_UC_StcokManager : UserControl
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlCommand cmd9;
        SqlCommand cmdQTY;
        SqlDataAdapter da;
        SqlDataAdapter da1;
        SqlDataAdapter da2;
        SqlDataAdapter da3;
        SqlDataAdapter da4;
        SqlDataAdapter daAll;
        SqlCommand cmdProName;
        public Item_UC_StcokManager()
        {
            InitializeComponent();
            ONLOAD();
        }
       

        private void Item_UC_StcokManager_Load(object sender, EventArgs e)
        {
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

        private void button9_Click(object sender, EventArgs e)//search btn
        {
            SqlConnection con5 = new SqlConnection(" Data Source=DESKTOP-UIDFTHQ;Initial Catalog=JD_COMPUTER_LOCAL_005;Integrated Security=True");
            con5.Open();
            try
            {

                cmd = new SqlCommand("Select * from ITEMS where itemID = '" + textBox3.Text + "'", con5);
                SqlDataReader drx = cmd.ExecuteReader();
                if (drx.Read())
                {
                    Debug.WriteLine(drx.GetValue(1).ToString());
                    textBox5.Text = drx.GetValue(1).ToString();
                    drx.Close();

                }
                else
                {
                    MessageBox.Show("Item Not Foud..!");
                }

                cmd9 = new SqlCommand("Select * from AvailableSTOCKS where itemID = '" + textBox3.Text + "'", con5);
                SqlDataReader drxx = cmd9.ExecuteReader();
                if (drxx.Read())
                {
                    Debug.WriteLine(drxx.GetValue(2).ToString());
                    int stocks = Convert.ToInt32(drxx.GetValue(2).ToString());
                    if (stocks <10)
                    {
                        radioButton5.Checked = true;
                        radioButton4.Checked = false;
                    }
                    else
                    {
                        radioButton5.Checked = false;
                        radioButton4.Checked = true;
                        textBox1.Text = drxx.GetValue(2).ToString();

                    }
                    drxx.Close();

                }
                else
                {
                    MessageBox.Show("Item Not Foud..!");
                }




                try//show available stocks
                {
                    
                    da1 = new SqlDataAdapter("Select * from AvailableSTOCKS where itemID = '" + textBox3.Text + "'", con5);
                    DataTable dt1 = new DataTable();
                    da1.Fill(dt1);
                    dataGridView3.DataSource = dt1;
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("SECTION 2" + ex.Message);
                }

                try//show Sold Stock
                {

                    da2 = new SqlDataAdapter("Select * from SOLDSTOCKS where itemID = '" + textBox3.Text + "'", con5);
                    DataTable dt1 = new DataTable();
                    da2.Fill(dt1);
                    dataGridView4.DataSource = dt1;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("SECTION 2" + ex.Message);
                }



                try//selection from items
                {
                    con.Open();
                    da = new SqlDataAdapter("Select * from ITEMS where itemID = '" + textBox3.Text + "'", con5);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("SECTION 2" + ex.Message);
                }
                con5.Close();



            }
            catch (Exception exs)
            {
                MessageBox.Show("SECTION 1 ERROR : " + exs.Message);

            }
            
        }

        public void ONLOAD()
        {

            con = new SqlConnection(" Data Source=DESKTOP-UIDFTHQ;Initial Catalog=JD_COMPUTER_LOCAL_005;Integrated Security=True");
            con.Open();
            daAll = new SqlDataAdapter("Select * from STOCKBUYING ", con);
            DataTable dataTable = new DataTable();
            daAll.Fill(dataTable);
            dataGridView2.DataSource = dataTable;
            
            ////////////////////////////
            ///
            SqlDataAdapter daAll1 = new SqlDataAdapter("Select * from SOLDSTOCKS ", con);
            DataTable dataTable2 = new DataTable();
            daAll1.Fill(dataTable2);
            dataGridView5.DataSource = dataTable2;
            con.Close();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)//add items
        {
            
            SqlConnection con2 = new SqlConnection(" Data Source=DESKTOP-UIDFTHQ;Initial Catalog=JD_COMPUTER_LOCAL_005;Integrated Security=True");
            con2.Open();
            try
            {
                string insertquery = "INSERT INTO ITEMS (itemID,modelNO,discription,supplierID,brand,category,barcode) VALUES (@a,@b,@c,@d,@e,@f,@g)";
                SqlCommand comnd = new SqlCommand(insertquery, con2);
                comnd.Parameters.AddWithValue("a", txt_cus_ID.Text);
                comnd.Parameters.AddWithValue("b", txt_fname.Text);
                comnd.Parameters.AddWithValue("c", txt_tel.Text);
                comnd.Parameters.AddWithValue("d", txtPwd.Text);
                comnd.Parameters.AddWithValue("e", txt_lname.Text);
                comnd.Parameters.AddWithValue("f", GetItemType(comboBox1.SelectedIndex));
                comnd.Parameters.AddWithValue("g", Convert.ToInt32(txt_city.Text));

               int i = comnd.ExecuteNonQuery();

                try
                {
                    string insertquery2 = "INSERT INTO STOCKBUYING (itemID,boughtQTY,unitPrice,sellingPricePerUnit) VALUES (@a,@b,@c,@d)";
                    SqlCommand comnd2 = new SqlCommand(insertquery2, con2);
                    comnd2.Parameters.AddWithValue("a", txt_cus_ID.Text);
                    comnd2.Parameters.AddWithValue("b", Convert.ToInt32(textBox8.Text));
                    comnd2.Parameters.AddWithValue("c", Convert.ToInt32(textBox10.Text));
                    comnd2.Parameters.AddWithValue("d", Convert.ToInt32(textBox9.Text));

                    int j = comnd2.ExecuteNonQuery();

                    try
                    {
                        string insertquery3 = "INSERT INTO AvailableSTOCKS (itemID,availableQTY) VALUES (@a,@b)";
                        SqlCommand comnd3 = new SqlCommand(insertquery3, con2);
                        comnd3.Parameters.AddWithValue("a", txt_cus_ID.Text);
                        comnd3.Parameters.AddWithValue("b", Convert.ToInt32(textBox8.Text));

                        int k = comnd3.ExecuteNonQuery();
                        if (i == 1 && j == 1 && k ==1)
                        {
                            MessageBox.Show("Item Added and New Stock Updated....!");
                            ONLOAD();

                        }
                        else
                        {

                            MessageBox.Show("Item Save Failed...!");

                        }


                    }
                    catch (Exception ex2)
                    {
                        MessageBox.Show("saving to Availibility table Error : " + ex2.Message);
                    }

                    

                }
                catch (Exception ex2)
                {
                    MessageBox.Show("saving to buy table Error : " + ex2.Message);
                }

               




            }
            catch(Exception ex1)
            {
                MessageBox.Show("saving to Item table Error" + ex1.Message);

            }

            
           
            con2.Close();



        }
        private string GetItemType(int positionID)
        {
            switch (positionID)
            {
                case 0: return "CCTV";
                case 1: return "DVR";
                case 2: return "Cables";
                case 3: return "Resivers";
                default: return "Unknown";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)//add stock
        {
            string uid;
            string newQuerry = "SELECT * FROM  ITEMS WHERE barcode = @a  ";

            SqlConnection con3 = new SqlConnection(" Data Source=DESKTOP-UIDFTHQ;Initial Catalog=JD_COMPUTER_LOCAL_005;Integrated Security=True");
            con3.Open();
            SqlCommand cmmd = new SqlCommand(newQuerry, con3);
            cmmd.Parameters.AddWithValue("a",Convert.ToInt32(textBox7.Text));
            SqlDataReader dr1 = cmmd.ExecuteReader();
            if (dr1.Read())
            {
                uid = dr1.GetValue(0).ToString();
                Debug.WriteLine("User id is : "+ uid);
                dr1.Close();
                try
                {
                    string insertquery4 = "INSERT INTO STOCKBUYING (itemID,boughtQTY,unitPrice,sellingPricePerUnit) VALUES (@a,@b,@c,@d)";
                    SqlCommand comnd4 = new SqlCommand(insertquery4, con3);
                    comnd4.Parameters.AddWithValue("a", uid);
                    comnd4.Parameters.AddWithValue("b", Convert.ToInt32(textBox6.Text));
                    comnd4.Parameters.AddWithValue("c", Convert.ToInt32(textBox4.Text));
                    comnd4.Parameters.AddWithValue("d", Convert.ToInt32(textBox11.Text));

                    int j = comnd4.ExecuteNonQuery();

                    try
                    {
                       
                        SqlCommand s1 = new SqlCommand("SELECT * FROM AvailableSTOCKS WHERE itemID = @c",con3);
                        s1.Parameters.AddWithValue("c", uid);
                        SqlDataReader dr2 = s1.ExecuteReader();
                        if (dr2.Read())
                        {
                            int curentStocks = Convert.ToInt32(dr2.GetValue(2).ToString());
                            dr2.Close();
                            Debug.WriteLine("total current stocks are  : " + curentStocks);
                            string newStock = textBox6.Text;
                            Debug.WriteLine("total current srting vaule  " + newStock);
                            int newStorcks = Convert.ToInt32(newStock);
                            Debug.WriteLine("total current srting vaule Converted  " + newStorcks);
                            int total = curentStocks + newStorcks ;
                            Debug.WriteLine("total is : "+ total);
                            string insertquery5 = "INSERT INTO AvailableSTOCKS (itemID,availableQTY) VALUES (@a,@b)";
                            SqlCommand comnd5 = new SqlCommand(insertquery5, con3);
                            comnd5.Parameters.AddWithValue("a", uid);
                            comnd5.Parameters.AddWithValue("b", total);

                            int k = comnd5.ExecuteNonQuery();
                            if (j == 1 && k == 1)
                            {
                                MessageBox.Show("Item Added and New Stock Updated....!");
                                ONLOAD();

                            }
                            else
                            {

                                MessageBox.Show("Item Save Failed...!");

                            }
                        }
                        else
                        {
                            MessageBox.Show("No Exsisting Stocks Found...!");

                        }
                        


                    }
                    catch (Exception ex2)
                    {
                        MessageBox.Show("saving to Availibility table Error : " + ex2.Message);
                    }



                }
                catch (Exception ex2)
                {
                    MessageBox.Show("saving to buy table Error : " + ex2.Message);
                }


            }
            else
            {
                MessageBox.Show("No Item Found .....!!!!");
            }




        }

        private void btnReview_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)//clearbtn 3
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }
    }
}
