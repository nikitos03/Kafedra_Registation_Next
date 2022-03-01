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
    public partial class Form2 : Form
    {

        private bool _isActive;

        public Form2(bool isActive)
        {
            InitializeComponent();

            //присваиваем глобальной переменной значение, передаваемое из первой формы
            this._isActive = isActive;

            //устанавлием для кнопок флаг активности (true - кнопки активны / false - кнопки не активны)
            button4.Enabled = _isActive;

        }

        private void button1_Click(object sender, EventArgs e) // Выход
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e) // otdel kadrov
        {
            Otdel_Kadrov newfrm = new Otdel_Kadrov(_isActive);
            newfrm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e) // otdel dekanata
        {
            Otdel_Dekanata newfrm = new Otdel_Dekanata(_isActive);
            newfrm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e) // dla admina
        {
            Form5 newfrm = new Form5(_isActive);
            newfrm.Show();
            this.Hide();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
