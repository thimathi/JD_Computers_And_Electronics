using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JD_Electronics_Application.Main_User_Controls.Accountant_UC
{
    public partial class Salary_user_Control : UserControl
    {
        public Salary_user_Control()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        String empID, empName, userType;
        double basicSalary, finalbasicSalary;
        double incentive, hourRate, etf;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Salary_user_Control_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection("Data Source=DESKTOP-UIDFTHQ;Initial Catalog=JD_COMPUTER_LOCAL_005;Integrated Security=True");
                con.Open();
                da = new SqlDataAdapter("Select * from JD_EMPLOYEE_PAYSHEET where empID like '%e%'", con);
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

        private void button2_Click(object sender, EventArgs e)
        {
            emp_id.Clear();
            emp_name.Clear();
            textBox8.Clear();
            textBox5.Clear();
            textBox3.Clear();
            textBox2.Clear();
            textBox6.Clear();
            textBox7.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
            
        }

        

        private void emp_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void emp_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("Update JD_EMPLOYEE_PAYSHEET set empID = '" + emp_id.Text + "',empName = '" + emp_name.Text + "',userType = '" + comboBox1.SelectedIndex + "', Month = '" + dateTimePicker1.Value + "', basicSalary = '" + textBox8.Text + "',incentive = '" + textBox5.Text + "',workDays = '" + textBox3.Text + "',otHours = '" + textBox2.Text + "',etf = '" + textBox6.Text + "', totalSalary = '" + label10.Text + "' where empID = '" + emp_id.Text + "'", con);
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("Data Update Successfully !!!!");
                }
                else
                {
                    MessageBox.Show("Data Cannot Update !!!!");
                    con.Close();
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        int workDays, otHours, positionIndex;
        DateTime month;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                empID = emp_id.Text;
                empName = emp_name.Text;
                positionIndex = comboBox1.SelectedIndex;
                userType = "";

                switch (positionIndex)
                {
                    case 0:
                        userType = "Manager";
                        break;
                    case 1:
                        userType = "Accountant";
                        break;
                    case 2:
                        userType = "Cashier";
                        break;
                    case 3:
                        userType = "Site Engineer";
                        break;
                    case 4:
                        userType = "Stock Manager";
                        break;
                    case 5:
                        userType = "Worker";
                        break;

                }
                month = dateTimePicker1.Value;
                basicSalary = Convert.ToDouble(textBox8.Text);
                double creditPrice = 100.00;
                incentive = (creditPrice  * Convert.ToDouble(textBox5.Text)) ;
                workDays = Convert.ToInt32(textBox3.Text);
                otHours = Convert.ToInt32(textBox2.Text);
                hourRate = Convert.ToInt32(textBox7.Text);
                etf = Convert.ToDouble(textBox6.Text);

                finalbasicSalary = Convert.ToDouble(textBox8.Text);
                double otIncome = Convert.ToDouble(otHours * hourRate * workDays);

                double totSalary = finalbasicSalary + incentive + etf + otIncome;
                label10.Text = Convert.ToString(totSalary);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Try Again !!!!!!!");
            }
        }
    }
}

