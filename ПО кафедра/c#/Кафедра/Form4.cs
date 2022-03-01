using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Кафедра
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 newfrm = new Form1();
            newfrm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e) //смена пароля
        {
            string connectionString = "server = localhost; port = 3306; username = root; password = root; database = kafedra; SSL Mode=None";
            
            MySqlConnection connection = new MySqlConnection(connectionString);
            
            connection.Open();
            
            string query = $"UPDATE users SET pass = '{textBox2.Text}' WHERE pass = '{textBox1.Text}'";
            
            MySqlCommand command = new MySqlCommand(query, connection);
            
            int result = command.ExecuteNonQuery();
            
            connection.Close();
            
            if (result == 0)
            {
                MessageBox.Show("Пароль не изменен, так как введен неверный старый пароль.");
            }
            else
            {
                MessageBox.Show("Пароль успешно изменен.");
            }

        }
    }
}
