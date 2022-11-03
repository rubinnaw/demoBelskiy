using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace demoBelskiy
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            this.progressBar1.Value = 100;
        }

        private void in_progress()
        {
            MessageBox.Show("Функция находится в рабработке", "Внимание!");
        }

        private void Избранное_Click(object sender, EventArgs e)
        {
            in_progress();
        }

        private void поиск_Click(object sender, EventArgs e)
        {
            in_progress();
        }
    }
}
