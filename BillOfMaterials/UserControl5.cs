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
    public partial class UserControl5 : UserControl
    {
        public UserControl5()
        {
            InitializeComponent();
            BindData();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FP3SJ5L\SQLEXPRESS2;Initial Catalog=BillOfMaterials;Integrated Security=True");
        void BindData()
        {
            SqlCommand command = new SqlCommand("select * from MATERIALS", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
           materialdata.DataSource = dt;
        }
        private void buttonedit_Click(object sender, EventArgs e)
        {

        }
        private void UserControl5_Load(object sender, EventArgs e)
        {
            userControl41.Hide();
            BindData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditMaterial f2 = new EditMaterial();
            f2.editmid.Text = this.materialdata.CurrentRow.Cells[0].Value.ToString();
            f2.editmname.Text = this.materialdata.CurrentRow.Cells[1].Value.ToString();
            f2.editmdescription.Text = this.materialdata.CurrentRow.Cells[2].Value.ToString();
            f2.editmmeasurement.Text = this.materialdata.CurrentRow.Cells[3].Value.ToString();
            f2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (materialid.Text != "")
            {

                if (MessageBox.Show("Do you want to remove this Product?", "Remove Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("Delete MATERIALS where MATERIAL_ID = '" + int.Parse(materialid.Text) + "'", con);

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

        private void button4_Click(object sender, EventArgs e)
        {
            userControl41.Show();
            userControl41.BringToFront();
            BindData();
        }

        private void productrefresh_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materialrefresh_Click(object sender, EventArgs e)
        {
            BindData();

        }

        private void searchmaterial_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "By ID")
            {
                SqlCommand command = new SqlCommand("select * from MATERIALS where MATERIAL_ID ='" + int.Parse(materialid.Text) + "'", con);
                SqlDataAdapter sd = new SqlDataAdapter(command);

                DataTable dt = new DataTable();
                sd.Fill(dt);
                materialdata.DataSource = dt;
            }
            else if (comboBox1.SelectedItem.ToString() == "By Name")
            {
                SqlCommand command = new SqlCommand("select * from MATERIALS where MATERIAL_NAME like'" + materialname.Text + "'", con);
                SqlDataAdapter sd = new SqlDataAdapter(command);

                DataTable dt = new DataTable();
                sd.Fill(dt);
                materialdata.DataSource = dt;
            }

        }
    }
  
}
