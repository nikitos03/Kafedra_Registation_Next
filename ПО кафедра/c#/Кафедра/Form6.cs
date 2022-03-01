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
    public partial class Form6 : Form
    {

        private bool _isActive;

        public Form6()
        {
            InitializeComponent();
            rolea.Text = "Введите имя";
            rolea.ForeColor = Color.Gray;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 newfrm = new Form5(_isActive);
            newfrm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (rolea.Text == "")
            {
                MessageBox.Show("Введите роль");
                return;
            }

            if (isUserExists())
                return;

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `admin` (`rolea`) VALUES (@rolea)", db.GetConnection());

            command.Parameters.Add("@rolea", MySqlDbType.VarChar).Value = rolea.Text;

            db.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Роль была создана");
            else
                MessageBox.Show("Роль не был создан");

            db.CloseConnection();

        }

        public Boolean isUserExists()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `admin` WHERE `rolea` = @uL", db.GetConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = rolea.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такая роль уже есть");
                return true;
            }

            else
                return false;
        }
    }
}
