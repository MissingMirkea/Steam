using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamAplication
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
            string ConnectionString = "Data Source=DESKTOP-UBC4JA8\\SQLEXPRESS;Initial Catalog=STEAM;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string AccountName = textBox2.Text;
            string AccountPassword = textBox4.Text;
            string AccountMail = textBox1.Text;
            string AccountSecretWord = textBox3.Text;
            string query = "Insert into accounts(acc_mail,acc_name,acc_password,acc_secretword) Values ('"+AccountMail+"', '"+AccountName+"' , '"+AccountPassword+"','"+AccountSecretWord+"')";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.Add("@acc_mail", AccountMail);
            cmd.Parameters.Add("@acc_name", AccountName);
            cmd.Parameters.Add("@acc_password", AccountPassword);
            cmd.Parameters.Add("@acc_secretword", AccountSecretWord);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Created an account");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
