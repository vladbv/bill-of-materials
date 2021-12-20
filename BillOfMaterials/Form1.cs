using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BillOfMaterials
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

         
        }

    
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            userControl12.Hide();
            userControl22.Show();
            userControl22.BringToFront();
            userControl32.Hide();
            userControl41.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            userControl12.Hide();
            userControl22.Hide();
            userControl32.Show();
            userControl41.Hide();
            userControl32.BringToFront();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        userControl22.Show();
            userControl12.Hide();
            userControl52.Hide();
            userControl32.Hide();
            userControl41.Hide();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            userControl52.Show();
            userControl52.BringToFront();
            userControl12.Hide();
            userControl22.Hide();
            userControl32.Hide();
            userControl41.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            userControl12.Show();
            userControl12.BringToFront();
            userControl22.Hide();
            userControl32.Hide();
            userControl41.Hide();
            userControl52.Hide();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            userControl12.Hide();
       
            userControl22.Hide();
            userControl32.Hide();
            userControl41.Show();
            userControl41.BringToFront();
            userControl52.Hide();

        }

        private void userControl31_Load(object sender, EventArgs e)
        {

        }

        private void userControl42_Load(object sender, EventArgs e)
        {

        }
        private void addnewproduct_Click(object sender, EventArgs e)
        {
            

        }
        private void userControl42_Load_1(object sender, EventArgs e)
        {

        }

        private void userControl21_Load(object sender, EventArgs e)
        {

        }
    }
}
