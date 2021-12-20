using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BillOfMaterials
{
    public partial class LoginForm : Form
    {
        //      private MySqlConnection conn;
        //    private string server;
        //  private string database;
        //private string uid;
        //private string password;

        public LoginForm()
        {
            /*   server = "DESKTOP-FP3SJ5L\SQLEXPRESS2";
               database = "BillOfMaterials";
               uid = "DESKTOP-FP3SJ5L\Blaskov";
               password = "";

               string connString;
               connString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";

               conn = new MySqlConnection(connString);
   */
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-FP3SJ5L\SQLEXPRESS2;Initial Catalog=BillOfMaterials;Integrated Security=True");


        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username, user_password;

            username = txt_username.Text;
            user_password = txt_password.Text;

            try
            {
                String querry = "SELECT * FROM USERS WHERE username = '" + txt_username.Text + "' AND password = '" + txt_password.Text + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    username = txt_username.Text;
                    user_password = txt_password.Text;

                    // Page to load next

                    new Form1().Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_username.Clear();
                    txt_password.Clear();

                    txt_username.Focus();

                }
            }

            catch
            {
                MessageBox.Show("ERROR");
            }
            finally
            {
                conn.Close();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
    namespace MySQL_Login_Register_Form_Tut
    {
        
    }
      
    }


