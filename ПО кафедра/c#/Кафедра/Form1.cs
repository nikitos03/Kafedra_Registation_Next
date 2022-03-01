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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            DB db = new DB();

            string mySelectQuery = "SELECT r.roles, COUNT(r.roles) AS cnt FROM `role` as r INNER JOIN `users` as u on r.id = u.id WHERE u.login = @uL AND u.pass = @uP GROUP BY r.roles";

            MySqlConnection myConnection = new MySqlConnection("server = localhost; port = 3306; username = root; password = root; database = kafedra; SSL Mode=None");

            MySqlCommand myCommand = new MySqlCommand(mySelectQuery, myConnection);

            myCommand.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginField.Text;

            myCommand.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passField.Text;

            myConnection.Open();

            MySqlDataReader myReader;

            myReader = myCommand.ExecuteReader();

            int cnt = 0;

            string role = " ";

            while (myReader.Read())
            {
                role = myReader.GetString(0);

                cnt = myReader.GetInt32(1);
            }
            myReader.Close();

            myConnection.Close();

            bool isActive = false;

            if (cnt == 0)
            {
                MessageBox.Show("Вы не ввели логин или пароль");
            }
            else
            {
                if (role == "Admin" || role == "Developer" || role == "System Administrator" || role == "Руководитель")
                {
                    isActive = true;
                }
                

                Form2 mainForm = new Form2(isActive);

                mainForm.Show();

                this.Hide();
            }


        }

        private void button2_Click(object sender, EventArgs e) //register
        {
            Form3 newfrm = new Form3();
            newfrm.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e) //выход
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e) //смена пароля
        {
            Form4 newfrm = new Form4();
            newfrm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form7 newfrm = new Form7();
            newfrm.Show();
            this.Hide();
        }
    }
}
