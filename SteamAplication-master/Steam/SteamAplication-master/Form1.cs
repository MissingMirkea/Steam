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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SteamAplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            textBox1.Text = Properties.Settings.Default.LastText;
            checkBox1.Checked = Properties.Settings.Default.CheckStatus;
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            Properties.Settings.Default.LastText = textBox1.Text;
            Properties.Settings.Default.Save();
            string username, password;
            username = textBox1.Text;
            password = textBox2.Text;
            string ConnectionString = "Data Source=DESKTOP-UBC4JA8\\SQLEXPRESS;Initial Catalog=STEAM;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            try
            {
                String query = "Select *FROM accounts where acc_name = '"+textBox1.Text+"' and where acc_password = '"+textBox2.Text+"'";
                SqlDataAdapter sda = new SqlDataAdapter(query,connection);
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
         
                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    username = textBox1.Text;
                    password = textBox2.Text;
                    this.Close();

                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                connection.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            Properties.Settings.Default.LastText = textBox1.Text;
            Properties.Settings.Default.Save();
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.CheckStatus = checkBox1.Checked;
            Properties.Settings.Default.Save();
        }
    }
}
