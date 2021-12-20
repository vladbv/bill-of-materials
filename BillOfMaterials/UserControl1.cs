using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BillOfMaterials
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
           BindData();
        }
       SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FP3SJ5L\SQLEXPRESS2;Initial Catalog=BillOfMaterials;Integrated Security=True");
       
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into EXPENCES values ('" + int.Parse(expenseid.Text) + "','" + expensename.Text +"')", con);
            con.Open();
            command.ExecuteNonQuery();
            MessageBox.Show("Successfully Inserted.");
            con.Close();
            BindData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        void BindData()
        {
            SqlCommand command = new SqlCommand("select * from EXPENCES", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            expensesdatagrid.DataSource = dt;
        }
        private void UserControl1_Load(object sender, EventArgs e)
        {
           BindData();    
        }
       
        private void expensesdatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void editexpenses_Click(object sender, EventArgs e)
        {
            
            con.Open();
            SqlCommand command = new SqlCommand("update EXPENCES set EXPENCE_NAME = '" + expensename.Text + "' where EXPENCE_ID ='" + int.Parse(expenseid.Text) + "' ", con);
       command.ExecuteNonQuery();
                con.Close();
            MessageBox.Show("The Data was successfully updated");
                BindData();
           
            }
           
        private void deleteexpenses_Click(object sender, EventArgs e)
        {
            
            if (expenseid.Text != "")
            {

                if (MessageBox.Show("Do you want to remove this Expense?", "Remove Expense", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("Delete EXPENCES where EXPENCE_ID = '" + int.Parse(expenseid.Text) + "'", con);

                    command.ExecuteNonQuery();
                    con.Close();
                    BindData();
                }
                else
                {
                    MessageBox.Show("Expense is not removed", "Removal of Expense", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
            }

        private void searchexpenses_Click(object sender, EventArgs e)
        {
            
            if (comboBox1.SelectedItem.ToString() == "By ID")
            {
                SqlCommand command = new SqlCommand("select * from EXPENCES where EXPENCE_ID ='" + int.Parse(expenseid.Text) + "'", con);
                SqlDataAdapter sd = new SqlDataAdapter(command);

                DataTable dt = new DataTable();
                sd.Fill(dt);
                expensesdatagrid.DataSource = dt;
            }
            else if (comboBox1.SelectedItem.ToString() == "By Name")
            {
                SqlCommand command = new SqlCommand("select * from EXPENCES where EXPENCE_NAME like'" +expensename.Text + "'", con);
                SqlDataAdapter sd = new SqlDataAdapter(command);

                DataTable dt = new DataTable();
                sd.Fill(dt);
                expensesdatagrid.DataSource = dt;
            }
          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UserControl1_Load_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
