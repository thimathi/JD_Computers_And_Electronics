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

namespace JD_Electronics_Application.Main_User_Controls.Manager_User_Control
{
    public partial class Employee_User_Control : UserControl
    {
        public Employee_User_Control()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-UIDFTHQ;Initial Catalog=JD_COMPUTER_LOCAL_005;Integrated Security=True");

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string employeeID, employeeType, firstName, lastName, address, city, nic, gender, location, email;
            int tel,positionID,occID;
            DateTime dob, regDate;

            employeeID = textBox2.Text;
            positionID = comboBox1.SelectedIndex;
            employeeType = GetUserType(positionID);
            occID = setOccupationIndex(positionID);
           

            try
            {
                

                conn.Open();
                SqlCommand cmd = new SqlCommand("Insert Into JD_employes(empID,userID,currentOccupation) values (@a, @b, @c)", conn);
                cmd.Parameters.AddWithValue("a", employeeID);
                cmd.Parameters.AddWithValue("b",textBox9.Text);
                cmd.Parameters.AddWithValue("c", employeeType);
                

                SqlCommand cmd2 = new SqlCommand("UPDATE JD_userLoginCredentials SET occupationINDEX=@value WHERE userID=@userID",conn);
                cmd2.Parameters.AddWithValue("value",occID);
                cmd2.Parameters.AddWithValue("userID",textBox9.Text);
               

                int i = cmd.ExecuteNonQuery();
                int j = cmd2.ExecuteNonQuery();

                if (i == 1&&j==1)
                {
                    MessageBox.Show("Data Save Successfully");
                   
                }
                else
                {
                    MessageBox.Show("Data Could not Save");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private string GetUserType(int positionID)
        {
            switch (positionID)
            {
                
                case 0: return "Manager";
                case 1: return "Accountant";
                case 2: return "Cashier";
                case 3: return "Site Engineer";
                case 4: return "Stock Manager";
                case 5: return "Worker";
                default: return "Unknown";
            }
        }
        private int setOccupationIndex(int positionId)
        {
            switch (positionId)
            {

                case 0: return 1;
                case 1: return 2;
                case 2: return 3;
                case 3: return 4;
                case 4: return 5;
                case 5: return 6;
                default: return 0;
            }

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            comboBox1.Items.Clear();
            
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-UIDFTHQ;Initial Catalog=JD_COMPUTER_LOCAL_005;Integrated Security=True");
        SqlDataAdapter da;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
   
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox11.Text is null)
                {
                    if(comboBox2.SelectedIndex == -1)
                    {
                        MessageBox.Show("Enter Value For Both NIC and Employee Type");
                    }
                    else
                    {
                        MessageBox.Show("Enter Proper Value For NIC");
                    }
                }
                else if(comboBox2.SelectedIndex == -1)
                {
                    if(textBox11.Text is null)
                    {
                        MessageBox.Show("Enter Value For Both NIC and Employee Type");
                    }
                    else
                    {
                        MessageBox.Show("Enter Proper Value For Employee Type");
                    }
                }
                else
                {
                    con.Open();
                    //
                    string connectionString = "YourConnectionString";

                   
                    
                        string query = @"SELECT e.empID, e.userID, e.currentOccupation, e.currentWorkingBranch, e.companyExperiance,
                           u.fullName, u.uNIC, u.email, u.adress, u.tpNO, u.dob, u.createdDate
                    FROM JD_employes e
                    INNER JOIN JD_USERS u ON e.userID = u.userID
                    WHERE e.currentOccupation = '"+ GetUserType2(comboBox2.SelectedIndex) + "' AND u.uNIC ='"+textBox11.Text+"'";

                        using (SqlDataAdapter command = new SqlDataAdapter(query, con))
                        {

                              DataTable dt = new DataTable();
                              command.Fill(dt);
                              dataGridView1.DataSource = dt;





                    }


                    //
                    //da = new SqlDataAdapter("Select * from JD_employes where nic = '" + textBox11.Text + "' AND employeeType = '" + comboBox2.SelectedIndex + "'",con);
                    //DataTable dt = new DataTable();
                    //da.Fill(dt);
                    //dataGridView1.DataSource = dt;
                }

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);

            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox11.Clear();
            comboBox2.Items.Clear();
        }
        private void ClearAllText(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                else if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex = -1;
                }
                else if (c is RichTextBox)
                {
                    ((RichTextBox)c).Clear();
                }
                else if (c is MaskedTextBox)
                {
                    ((MaskedTextBox)c).Clear();
                }
                else if (c is NumericUpDown)
                {
                    ((NumericUpDown)c).Value = 0;
                }
                else if (c is DateTimePicker)
                {
                    ((DateTimePicker)c).Value = DateTime.Now;
                }
                else if (c is GroupBox || c is Panel || c is TabPage)
                {
                    ClearAllText(c); // Recursively clear controls in contained controls
                }
            }
        }

        // Call this method passing your form instance to clear all text
        private void ClearFormText()
        {
            ClearAllText(this);
        }
        private string GetUserType2(int positionID)
        {
            switch (positionID)
            {
                
                case 0: return "Manager";
                case 1: return "Accountant";
                case 2: return "Cashier";
                case 3: return "Site Engineer";
                case 4: return "Stock Manager";
                case 5: return "Worker";
                default: return "Unknown";
            }
        }

    }
}
