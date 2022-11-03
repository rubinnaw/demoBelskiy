using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace demoBelskiy
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.progressBar1.Value = 75;
        }

        private void in_progress()
        {
            MessageBox.Show("Функция находится в рабработке", "Внимание!");
        }

        public void check()
        {
            if (category.SelectedItem == null && type.SelectedItem == null)
            {
                MessageBox.Show("Неободимо выбрать значения!", "ERROR");
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

        private void поиск_Click(object sender, EventArgs e)
        {
            in_progress();
        }

        private void Избранное_Click(object sender, EventArgs e)
        {
            in_progress();
        }

        private void Стоимость_Scroll(object sender, EventArgs e)
        {
            min.Text = "" + trackBar1.Value;
        }

        private void maxCost_Scroll(object sender, EventArgs e)
        {
            max.Text = "" + trackBar1.Value;
        }

        private void пропустить_Click(object sender, EventArgs e)
        {
            check();
        }
    }
}
