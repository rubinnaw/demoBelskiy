
namespace demoBelskiy
{
    partial class Form2
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
            this.пропустить = new System.Windows.Forms.Button();
            this.далее = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.шаг = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Избранное
            // 
            this.Избранное.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Избранное.Location = new System.Drawing.Point(278, 12);
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
            this.поиск.Location = new System.Drawing.Point(162, 12);
            this.поиск.Name = "поиск";
            this.поиск.Size = new System.Drawing.Size(110, 37);
            this.поиск.TabIndex = 17;
            this.поиск.Text = "Поиск";
            this.поиск.UseVisualStyleBackColor = true;
            this.поиск.Click += new System.EventHandler(this.поиск_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Посик",
            "Избранное"});
            this.comboBox1.Location = new System.Drawing.Point(10, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 16;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.CadetBlue;
            this.progressBar1.Location = new System.Drawing.Point(10, 74);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(776, 34);
            this.progressBar1.TabIndex = 19;
            // 
            // пропустить
            // 
            this.пропустить.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.пропустить.Location = new System.Drawing.Point(238, 400);
            this.пропустить.Name = "пропустить";
            this.пропустить.Size = new System.Drawing.Size(111, 38);
            this.пропустить.TabIndex = 22;
            this.пропустить.Text = "Пропустить";
            this.пропустить.UseVisualStyleBackColor = true;
            this.пропустить.Click += new System.EventHandler(this.пропустить_Click);
            // 
            // далее
            // 
            this.далее.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.далее.Location = new System.Drawing.Point(407, 400);
            this.далее.Name = "далее";
            this.далее.Size = new System.Drawing.Size(96, 38);
            this.далее.TabIndex = 21;
            this.далее.Text = "Далее";
            this.далее.UseVisualStyleBackColor = true;
            this.далее.Click += new System.EventHandler(this.далее_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(53, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 238);
            this.panel1.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(148, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 159);
            this.label1.TabIndex = 0;
            this.label1.Text = "СКИП";
            // 
            // шаг
            // 
            this.шаг.AutoSize = true;
            this.шаг.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.шаг.Font = new System.Drawing.Font("Segoe UI", 18.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.шаг.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.шаг.Location = new System.Drawing.Point(345, 74);
            this.шаг.Name = "шаг";
            this.шаг.Size = new System.Drawing.Size(87, 35);
            this.шаг.TabIndex = 24;
            this.шаг.Text = "ШАГ 2";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.шаг);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.пропустить);
            this.Controls.Add(this.далее);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Избранное);
            this.Controls.Add(this.поиск);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Избранное;
        private System.Windows.Forms.Button поиск;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button пропустить;
        private System.Windows.Forms.Button далее;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label шаг;
    }
}