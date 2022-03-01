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
    public partial class Form5 : Form
    {
        public Form5(bool isActive)
        {
            InitializeComponent();

            //присваиваем глобальной переменной значение, передаваемое из первой формы
            this._isActive = isActive;

            //устанавлием для кнопок флаг активности
            button3.Enabled = _isActive;

            button4.Enabled = _isActive;

            button1.Enabled = _isActive;

        }

        private bool _isActive;

        MySqlConnection connection = new MySqlConnection("server = localhost; port = 3306; username = root; password = root; database = kafedra; SSL Mode=None");
        MySqlCommand command;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        private void Form5_Load(object sender, EventArgs e)
        {
            populateDGV();
            
                try
                {
                    MySqlConnection connection = new MySqlConnection("server = localhost; port = 3306; username = root; password = root; database = kafedra; SSL Mode=None");
                    string selectQuery = "SELECT * FROM admin";
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(selectQuery, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        comboBox1.Items.Add(reader.GetString("rolea"));
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            
        }

        public void populateDGV()
        {
            string selectQuery = "SELECT * FROM users";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TextBox_1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            TextBox_2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e) // добавить роль
        {
            Form6 newfrm = new Form6();
            newfrm.Show();
            this.Hide();
        }

        public void openConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {

                connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public void executeMyQuery(string query)
        {
            try
            {
                openConnection();
                command = new MySqlCommand(query, connection);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Запрос выполнен");
                }
                else
                {
                    MessageBox.Show("Запрос не выполнен");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeConnection();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE `role` SET login='" + TextBox_2.Text + "', roles='" + comboBox1.Text + "' WHERE id =" + int.Parse(TextBox_1.Text);
            executeMyQuery(updateQuery);
            populateDGV();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO role(id, login, roles) VALUES ('" + TextBox_1.Text + "', '" + TextBox_2.Text + "', '" + comboBox1.Text + "')";
            executeMyQuery(insertQuery);
            populateDGV();
        }

        private void button2_Click(object sender, EventArgs e) // Выход
        {
            Form2 newfrm = new Form2(_isActive);
            newfrm.Show();
            this.Hide();
        }

    }
}
