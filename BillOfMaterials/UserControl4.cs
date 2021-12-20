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
    public partial class UserControl4 : UserControl
    {
        public UserControl4()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FP3SJ5L\SQLEXPRESS2;Initial Catalog=BillOfMaterials;Integrated Security=True");

            SqlCommand command = new SqlCommand("insert into MATERIALS values ('" + int.Parse(materialid.Text) + "','" + materialname.Text + "','" + materialdescription.Text + "','" + materialmeasurement.Text + "')", con);
            con.Open();
            command.ExecuteNonQuery();
            MessageBox.Show("Successfully Inserted.");
            con.Close();
            this.Hide();
            var uc2 = new UserControl5();
            uc2.Show();
            uc2.BringToFront();
        }

        private void backbtnadd_Click(object sender, EventArgs e)
        {

            this.Hide();
            var uc2 = new UserControl5();
            uc2.Show();
            uc2.BringToFront();
        }
    }
}
