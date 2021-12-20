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
    public partial class UserControl3 : UserControl
    {

        public UserControl3()
        {
            InitializeComponent();
        }

        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);

        public event UpdateDelegate UpdateEventHandler;

        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }

        private void UserControl3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FP3SJ5L\SQLEXPRESS2;Initial Catalog=BillOfMaterials;Integrated Security=True");

            SqlCommand command = new SqlCommand("insert into PRODUCT values ('" + int.Parse(productid.Text) + "','" + productname.Text + "','" + productdescription.Text + "')", con);
            con.Open();
            command.ExecuteNonQuery();
            MessageBox.Show("Successfully Inserted.");
            con.Close();
            this.Hide();
            var uc2 = new UserControl2();
            uc2.Show();
            uc2.BringToFront();


        }

        private void backbtnadd_Click(object sender, EventArgs e)
        {
            this.Hide();
            var uc2 = new UserControl2();
            uc2.Show();
            uc2.BringToFront();
        }
    }
}
