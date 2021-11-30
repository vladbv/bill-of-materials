using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            userControl11.Hide();
            userControl21.Show();
            userControl21.BringToFront();
            userControl31.Hide();
            userControl42.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Show();
            userControl42.Hide();
            userControl31.BringToFront();
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
            userControl51.Show();
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
            userControl42.Hide();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            userControl51.Show();
            userControl51.BringToFront();
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
            userControl42.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            userControl11.Show();
            userControl11.BringToFront();
            userControl21.Hide();
            userControl31.Hide();
            userControl42.Hide();
            userControl51.Hide();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            userControl11.Hide();
       
            userControl21.Hide();
            userControl31.Hide();
            userControl42.Show();
            userControl42.BringToFront();
            userControl51.Hide();

        }

        private void userControl31_Load(object sender, EventArgs e)
        {

        }

        private void userControl42_Load(object sender, EventArgs e)
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
