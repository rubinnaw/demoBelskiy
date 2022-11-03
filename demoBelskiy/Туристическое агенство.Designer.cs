
namespace demoBelskiy
{
    partial class Form1
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.ОснованаяИнформация = new System.Windows.Forms.Label();
            this.ДатаНачалаПериода = new System.Windows.Forms.Label();
            this.ДатаОкончанияПериода = new System.Windows.Forms.Label();
            this.колвоЧеловек = new System.Windows.Forms.Label();
            this.колвоДней = new System.Windows.Forms.Label();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.количество_дней = new System.Windows.Forms.TextBox();
            this.количество_человек = new System.Windows.Forms.TextBox();
            this.Дети = new System.Windows.Forms.CheckBox();
            this.далее = new System.Windows.Forms.Button();
            this.пропустить = new System.Windows.Forms.Button();
            this.поиск = new System.Windows.Forms.Button();
            this.Избранное = new System.Windows.Forms.Button();
            this.шаг = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Посик",
            "Избранное"});
            this.comboBox1.Location = new System.Drawing.Point(4, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 0;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.CadetBlue;
            this.progressBar1.Location = new System.Drawing.Point(12, 72);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(776, 34);
            this.progressBar1.TabIndex = 1;
            // 
            // ОснованаяИнформация
            // 
            this.ОснованаяИнформация.AutoSize = true;
            this.ОснованаяИнформация.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ОснованаяИнформация.Location = new System.Drawing.Point(262, 127);
            this.ОснованаяИнформация.Name = "ОснованаяИнформация";
            this.ОснованаяИнформация.Size = new System.Drawing.Size(238, 28);
            this.ОснованаяИнформация.TabIndex = 2;
            this.ОснованаяИнформация.Text = "Основаная информация";
            // 
            // ДатаНачалаПериода
            // 
            this.ДатаНачалаПериода.AutoSize = true;
            this.ДатаНачалаПериода.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ДатаНачалаПериода.Location = new System.Drawing.Point(156, 188);
            this.ДатаНачалаПериода.Name = "ДатаНачалаПериода";
            this.ДатаНачалаПериода.Size = new System.Drawing.Size(163, 21);
            this.ДатаНачалаПериода.TabIndex = 3;
            this.ДатаНачалаПериода.Text = "Дата начала периода";
            // 
            // ДатаОкончанияПериода
            // 
            this.ДатаОкончанияПериода.AutoSize = true;
            this.ДатаОкончанияПериода.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ДатаОкончанияПериода.Location = new System.Drawing.Point(128, 236);
            this.ДатаОкончанияПериода.Name = "ДатаОкончанияПериода";
            this.ДатаОкончанияПериода.Size = new System.Drawing.Size(191, 21);
            this.ДатаОкончанияПериода.TabIndex = 4;
            this.ДатаОкончанияПериода.Text = "Дата окончания периода";
            // 
            // колвоЧеловек
            // 
            this.колвоЧеловек.AutoSize = true;
            this.колвоЧеловек.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.колвоЧеловек.Location = new System.Drawing.Point(164, 334);
            this.колвоЧеловек.Name = "колвоЧеловек";
            this.колвоЧеловек.Size = new System.Drawing.Size(155, 21);
            this.колвоЧеловек.TabIndex = 5;
            this.колвоЧеловек.Text = "Количество человек";
            // 
            // колвоДней
            // 
            this.колвоДней.AutoSize = true;
            this.колвоДней.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.колвоДней.Location = new System.Drawing.Point(187, 289);
            this.колвоДней.Name = "колвоДней";
            this.колвоДней.Size = new System.Drawing.Size(132, 21);
            this.колвоДней.TabIndex = 6;
            this.колвоДней.Text = "Количество дней";
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(355, 186);
            this.dateStart.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.dateStart.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(200, 23);
            this.dateStart.TabIndex = 7;
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(355, 236);
            this.dateEnd.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(200, 23);
            this.dateEnd.TabIndex = 8;
            // 
            // количество_дней
            // 
            this.количество_дней.Location = new System.Drawing.Point(355, 291);
            this.количество_дней.Name = "количество_дней";
            this.количество_дней.Size = new System.Drawing.Size(56, 23);
            this.количество_дней.TabIndex = 9;
            this.количество_дней.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.количество_дней_KeyPress);
            // 
            // количество_человек
            // 
            this.количество_человек.Location = new System.Drawing.Point(355, 334);
            this.количество_человек.Name = "количество_человек";
            this.количество_человек.Size = new System.Drawing.Size(56, 23);
            this.количество_человек.TabIndex = 10;
            // 
            // Дети
            // 
            this.Дети.AutoSize = true;
            this.Дети.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Дети.Location = new System.Drawing.Point(436, 333);
            this.Дети.Name = "Дети";
            this.Дети.Size = new System.Drawing.Size(64, 25);
            this.Дети.TabIndex = 11;
            this.Дети.Text = "Дети";
            this.Дети.UseVisualStyleBackColor = true;
            // 
            // далее
            // 
            this.далее.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.далее.Location = new System.Drawing.Point(404, 400);
            this.далее.Name = "далее";
            this.далее.Size = new System.Drawing.Size(96, 38);
            this.далее.TabIndex = 12;
            this.далее.Text = "Далее";
            this.далее.UseVisualStyleBackColor = true;
            this.далее.Click += new System.EventHandler(this.далее_Click);
            // 
            // пропустить
            // 
            this.пропустить.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.пропустить.Location = new System.Drawing.Point(235, 400);
            this.пропустить.Name = "пропустить";
            this.пропустить.Size = new System.Drawing.Size(111, 38);
            this.пропустить.TabIndex = 13;
            this.пропустить.Text = "Пропустить";
            this.пропустить.UseVisualStyleBackColor = true;
            this.пропустить.Click += new System.EventHandler(this.пропустить_Click);
            // 
            // поиск
            // 
            this.поиск.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.поиск.Location = new System.Drawing.Point(156, 12);
            this.поиск.Name = "поиск";
            this.поиск.Size = new System.Drawing.Size(110, 37);
            this.поиск.TabIndex = 14;
            this.поиск.Text = "Поиск";
            this.поиск.UseVisualStyleBackColor = true;
            this.поиск.Click += new System.EventHandler(this.поиск_Click);
            // 
            // Избранное
            // 
            this.Избранное.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Избранное.Location = new System.Drawing.Point(272, 12);
            this.Избранное.Name = "Избранное";
            this.Избранное.Size = new System.Drawing.Size(110, 37);
            this.Избранное.TabIndex = 15;
            this.Избранное.Text = "Избранное";
            this.Избранное.UseVisualStyleBackColor = true;
            this.Избранное.Click += new System.EventHandler(this.Избранное_Click);
            // 
            // шаг
            // 
            this.шаг.AutoSize = true;
            this.шаг.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.шаг.Font = new System.Drawing.Font("Segoe UI", 18.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.шаг.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.шаг.Location = new System.Drawing.Point(366, 71);
            this.шаг.Name = "шаг";
            this.шаг.Size = new System.Drawing.Size(87, 35);
            this.шаг.TabIndex = 16;
            this.шаг.Text = "ШАГ 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.шаг);
            this.Controls.Add(this.Избранное);
            this.Controls.Add(this.поиск);
            this.Controls.Add(this.пропустить);
            this.Controls.Add(this.далее);
            this.Controls.Add(this.Дети);
            this.Controls.Add(this.количество_человек);
            this.Controls.Add(this.количество_дней);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.колвоДней);
            this.Controls.Add(this.колвоЧеловек);
            this.Controls.Add(this.ДатаОкончанияПериода);
            this.Controls.Add(this.ДатаНачалаПериода);
            this.Controls.Add(this.ОснованаяИнформация);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Туристическое агенство";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label ОснованаяИнформация;
        private System.Windows.Forms.Label ДатаНачалаПериода;
        private System.Windows.Forms.Label ДатаОкончанияПериода;
        private System.Windows.Forms.Label колвоЧеловек;
        private System.Windows.Forms.Label колвоДней;
        private System.Windows.Forms.DateTimePicker ДатаОкончания;
        private System.Windows.Forms.TextBox количество_дней;
        private System.Windows.Forms.TextBox количество_человек;
        private System.Windows.Forms.CheckBox Дети;
        private System.Windows.Forms.Button далее;
        private System.Windows.Forms.Button пропустить;
        private System.Windows.Forms.Button поиск;
        private System.Windows.Forms.Button Избранное;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.Label шаг;
    }
}