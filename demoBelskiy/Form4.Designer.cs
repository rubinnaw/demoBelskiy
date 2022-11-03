
namespace demoBelskiy
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Избранное = new System.Windows.Forms.Button();
            this.поиск = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Результаты = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.шаг = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Избранное
            // 
            this.Избранное.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Избранное.Location = new System.Drawing.Point(271, 12);
            this.Избранное.Name = "Избранное";
            this.Избранное.Size = new System.Drawing.Size(110, 37);
            this.Избранное.TabIndex = 18;
            this.Избранное.Text = "Избранное";
            this.Избранное.UseVisualStyleBackColor = true;
            this.Избранное.Click += new System.EventHandler(this.Избранное_Click);
            // 
            // поиск
            // 
            this.поиск.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.поиск.Location = new System.Drawing.Point(155, 12);
            this.поиск.Name = "поиск";
            this.поиск.Size = new System.Drawing.Size(110, 37);
            this.поиск.TabIndex = 17;
            this.поиск.Text = "Поиск";
            this.поиск.UseVisualStyleBackColor = true;
            this.поиск.Click += new System.EventHandler(this.поиск_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Посик",
            "Избранное"});
            this.comboBox1.Location = new System.Drawing.Point(15, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 16;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.CadetBlue;
            this.progressBar1.Location = new System.Drawing.Point(12, 68);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(776, 34);
            this.progressBar1.TabIndex = 19;
            // 
            // Результаты
            // 
            this.Результаты.AutoSize = true;
            this.Результаты.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Результаты.Location = new System.Drawing.Point(307, 129);
            this.Результаты.Name = "Результаты";
            this.Результаты.Size = new System.Drawing.Size(183, 28);
            this.Результаты.TabIndex = 20;
            this.Результаты.Text = "Результаты поиска";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(15, 180);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 233);
            this.panel1.TabIndex = 21;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(754, 210);
            this.dataGridView1.TabIndex = 0;
            // 
            // шаг
            // 
            this.шаг.AutoSize = true;
            this.шаг.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.шаг.Font = new System.Drawing.Font("Segoe UI", 18.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.шаг.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.шаг.Location = new System.Drawing.Point(359, 68);
            this.шаг.Name = "шаг";
            this.шаг.Size = new System.Drawing.Size(87, 35);
            this.шаг.TabIndex = 25;
            this.шаг.Text = "ШАГ 4";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.шаг);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Результаты);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Избранное);
            this.Controls.Add(this.поиск);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Избранное;
        private System.Windows.Forms.Button поиск;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label Результаты;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label шаг;
    }
}