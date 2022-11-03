using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace demoBelskiy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.progressBar1.Value += 25;
        }

        private void in_progress()
        {
            MessageBox.Show("Функция находится в рабработке", "Внимание!");
        }

        public void check()
        {
            if (количество_дней.Text == ""  && количество_человек.Text == "")
            {
                MessageBox.Show("Неободимо запонить поля!", "ERROR");
            }
            else
            {
                Form2 train = new Form2();
                this.Visible = false;
                train.ShowDialog();
                this.Close();
            }
        }

        private void далее_Click(object sender, EventArgs e)
        {
            check();
        }

        private void пропустить_Click(object sender, EventArgs e)
        {
            check();
        }

        private void количество_дней_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void поиск_Click(object sender, EventArgs e)
        {
            in_progress();
        }

        private void Избранное_Click(object sender, EventArgs e)
        {
            in_progress();
        }
    }
}
