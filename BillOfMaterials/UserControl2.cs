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

    public partial class UserControl2 : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FP3SJ5L\SQLEXPRESS2;Initial Catalog=BillOfMaterials;Integrated Security=True");
        
        public UserControl2()
        {

            InitializeComponent();
            
            BindData();
        
        }
        
        void BindData()
        {

            SqlCommand command = new SqlCommand("select * from PRODUCT", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            productsdata.DataSource = dt;

        }
        
       
        
        private DataTable dt = new DataTable();
        private DataSet ds = new DataSet();

        public DataTable Source()
        {
            SqlCommand command = new SqlCommand("select * from PRODUCT", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            return dt;
      
        }
        
        private void U3_UpdateEventHandler(object sender, UserControl3.UpdateEventArgs args)
        {
            productsdata.DataSource = Source();
        }
       
        private void UserControl2_Load(object sender, EventArgs e)
        {
            
            userControl32.Hide();
            BindData();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            userControl32.Show();
            userControl32.BringToFront();
       
        }
        private void addnewproduct_Click(object sender, EventArgs e)
        {
            
            userControl31.Show();
           userControl31.BringToFront();
            BindData();
        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void userControl31_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void userControl32_Load(object sender, EventArgs e)
        {

        }

        private void productrefresh_Click(object sender, EventArgs e)
        {
            
            BindData();
       
        }

        private void deleteproduct_Click(object sender, EventArgs e)
        {
            
            if (pid.Text != "")
            {

                if (MessageBox.Show("Do you want to remove this Product?", "Remove Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("Delete PRODUCT where PRODUCT_ID = '" + int.Parse(pid.Text) + "'", con);

                    command.ExecuteNonQuery();
                    con.Close();
                    BindData();
                }
                else
                {
                    MessageBox.Show("Product is not removed", "Removal of Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
        }

        private void searchexpenses_Click(object sender, EventArgs e)
        {
            
            if (comboBox1.SelectedItem.ToString() == "By ID")
            {
                SqlCommand command = new SqlCommand("select * from PRODUCT where PRODUCT_ID ='" + int.Parse(pid.Text) + "'", con);
                SqlDataAdapter sd = new SqlDataAdapter(command);

                DataTable dt = new DataTable();
                sd.Fill(dt);
                productsdata.DataSource = dt;
            }
            else if (comboBox1.SelectedItem.ToString() == "By Name")
            {
                SqlCommand command = new SqlCommand("select * from PRODUCT where PRODUCT_NAME like'" + pname.Text + "'", con);
                SqlDataAdapter sd = new SqlDataAdapter(command);

                DataTable dt = new DataTable();
                sd.Fill(dt);
                productsdata.DataSource = dt;
            }

        
        }

        private void editproduct_Click(object sender, EventArgs e)
        {
            EditProduct f2 = new EditProduct();
            f2.editpid.Text = this.productsdata.CurrentRow.Cells[0].Value.ToString();
            f2.editpname.Text = this.productsdata.CurrentRow.Cells[1].Value.ToString();
            f2.editpdescription.Text = this.productsdata.CurrentRow.Cells[2].Value.ToString();
            f2.ShowDialog();
        }
    }
           

        }
