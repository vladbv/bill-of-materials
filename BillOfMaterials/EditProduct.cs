using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BillOfMaterials
{
    public partial class EditProduct : Form
    {
        public EditProduct()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void editpbutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FP3SJ5L\SQLEXPRESS2;Initial Catalog=BillOfMaterials;Integrated Security=True");
            con.Open();
            SqlCommand command = new SqlCommand("update PRODUCT set PRODUCT_NAME = '" + editpname.Text + "', PRODUCT_DESCRIPTION = '" + editpdescription.Text + "' where PRODUCT_ID ='" + int.Parse(editpid.Text) + "' ", con);
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("The Data was successfully updated");

        }
    }
}
