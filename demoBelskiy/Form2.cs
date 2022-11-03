using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace demoBelskiy
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.progressBar1.Value += 50;
        }

        private void next()
        {
            Form3 train = new Form3();
            this.Visible = false;
            train.ShowDialog();
            this.Close();
        }
        private void in_progress()
        {
            MessageBox.Show("Функция находится в рабработке", "Внимание!");
        }

        private void далее_Click(object sender, EventArgs e)
        {
            next();
        }

        private void пропустить_Click(object sender, EventArgs e)
        {
            next();
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
