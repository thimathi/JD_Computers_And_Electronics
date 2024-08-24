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

namespace JD_Electronics_Application.Main_User_Controls.Site_Engineer_UC
{
    public partial class Project_User_Control_SE : UserControl
    {
        public Project_User_Control_SE()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlCommand cmd;
        SqlCommand cmd2;
        SqlCommand cmd3;


        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void Project_User_Control_SE_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(" Data Source=DESKTOP-UIDFTHQ;Initial Catalog=JD_COMPUTER_LOCAL_005;Integrated Security=True");
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("Insert into projects value '"+textBox1.Text+"', '"+textBox6.Text+"','"+comboBox1.SelectedIndex+"','"+textBox9.Text+"','"+textBox10.Text+"','"+textBox2.Text+"','"+dateTimePicker11.Value+"'",conn);
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("Data Save Successfully !!!!");
                }
                else
                {
                    MessageBox.Show("Data Could Not Been Saved !!!!");
                    conn.Close();
                    cmd.Dispose();
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox6.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox2.Clear();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd2 = new SqlCommand("Update projects set projectID = '" + textBox1.Text + "', projectName = '" + textBox6.Text + "', projectType = '" + comboBox1.SelectedIndex + "', location = '" + textBox9.Text + "', customerID = '" + textBox10.Text + "', customerName = '" + textBox2.Text + "', createDate = '" + dateTimePicker11.Value + "' where projectID = '" + textBox1.Text + "'", conn);
                int i = cmd2.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("Data Updated Successfully");
                }
                else
                {
                    MessageBox.Show("Data Could not been updated");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnProjectUpdateClear_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            textBox5.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox3.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd3 = new SqlCommand("Insert into workingProcedure value '" + textBox12.Text + "', '" + textBox15.Text + "','" + comboBox4.SelectedIndex + "','" + textBox14.Text + "','" + textBox16.Text + "','" + dateTimePicker2.Value + "','" + textBox17.Text + "'", conn);
                int i = cmd3.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("Data Save Successfully !!!!");
                }
                else
                {
                    MessageBox.Show("Data Could Not Been Saved !!!!");
                    conn.Close();
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnProcedureUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd3 = new SqlCommand("Update workingProcedure set projectID = '" + textBox12.Text + "', projectName = '" + textBox15.Text + "', projectType = '" + comboBox4.SelectedIndex + "', location = '" + textBox14.Text + "', createDate = '" + dateTimePicker2.Value + "', cartID = '"+ textBox17.Text +"' where projectID = '" + textBox12.Text + "'", conn);
                int i = cmd3.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("Data Updated Successfully");
                }
                else
                {
                    MessageBox.Show("Data Could not been updated");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox12.Clear();
            textBox15.Clear();
            textBox14.Clear();
            textBox17.Clear();
            textBox16.Clear();
        }
    }
}
