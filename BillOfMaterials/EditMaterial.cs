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
    public partial class EditMaterial : Form
    {
        public EditMaterial()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void materialeditfinish_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FP3SJ5L\SQLEXPRESS2;Initial Catalog=BillOfMaterials;Integrated Security=True");
            con.Open();
            SqlCommand command = new SqlCommand("update MATERIALS set MATERIAL_NAME = '" + editmname.Text + "', MATERIAL_DESCRIPTION = '"+editmdescription.Text+"', MATERIAL_MEASURE = '"+editmmeasurement.Text+"' where MATERIAL_ID ='" + int.Parse(editmid.Text) + "' ", con);
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("The Data was successfully updated");
           
        }
    }
}
