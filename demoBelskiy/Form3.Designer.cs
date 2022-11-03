
namespace demoBelskiy
{
    partial class Form3
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Условия = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.max = new System.Windows.Forms.TextBox();
            this.min = new System.Windows.Forms.TextBox();
            this.category = new System.Windows.Forms.ComboBox();
            this.maxCost = new System.Windows.Forms.TrackBar();
            this.misCost = new System.Windows.Forms.TrackBar();
            this.СтоимостьТура = new System.Windows.Forms.Label();
            this.ДополнительныеУслуги = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Трансфер = new System.Windows.Forms.CheckBox();
            this.Кондиционер = new System.Windows.Forms.CheckBox();
            this.WIFI = new System.Windows.Forms.CheckBox();
            this.Эксклюзив = new System.Windows.Forms.CheckBox();
            this.VIP = new System.Windows.Forms.CheckBox();
            this.Свадьба = new System.Windows.Forms.CheckBox();
            this.FIT = new System.Windows.Forms.CheckBox();
            this.Sport = new System.Windows.Forms.CheckBox();
            this.SPA = new System.Windows.Forms.CheckBox();
            this.type = new System.Windows.Forms.ComboBox();
            this.Питание = new System.Windows.Forms.Label();
            this.Категория = new System.Windows.Forms.Label();
            this.пропустить = new System.Windows.Forms.Button();
            this.далее = new System.Windows.Forms.Button();
            this.шаг = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.misCost)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Избранное
            // 
            this.Избранное.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Избранное.Location = new System.Drawing.Point(282, 12);
            this.Избранное.Name = "Избранное";
            this.Избранное.Size = new System.Drawing.Size(110, 37);
            this.Избранное.TabIndex = 19;
            this.Избранное.Text = "Избранное";
            this.Избранное.UseVisualStyleBackColor = true;
            this.Избранное.Click += new System.EventHandler(this.Избранное_Click);
            // 
            // поиск
            // 
            this.поиск.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.поиск.Location = new System.Drawing.Point(166, 12);
            this.поиск.Name = "поиск";
            this.поиск.Size = new System.Drawing.Size(110, 37);
            this.поиск.TabIndex = 18;
            this.поиск.Text = "Поиск";
            this.поиск.UseVisualStyleBackColor = true;
            this.поиск.Click += new System.EventHandler(this.поиск_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.CadetBlue;
            this.progressBar1.Location = new System.Drawing.Point(12, 74);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(776, 34);
            this.progressBar1.TabIndex = 17;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Посик",
            "Избранное"});
            this.comboBox1.Location = new System.Drawing.Point(14, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 16;
            // 
            // Условия
            // 
            this.Условия.AutoSize = true;
            this.Условия.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Условия.Location = new System.Drawing.Point(301, 124);
            this.Условия.Name = "Условия";
            this.Условия.Size = new System.Drawing.Size(144, 28);
            this.Условия.TabIndex = 20;
            this.Условия.Text = "Условия отеля";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.max);
            this.panel1.Controls.Add(this.min);
            this.panel1.Controls.Add(this.category);
            this.panel1.Controls.Add(this.maxCost);
            this.panel1.Controls.Add(this.misCost);
            this.panel1.Controls.Add(this.СтоимостьТура);
            this.panel1.Controls.Add(this.ДополнительныеУслуги);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.type);
            this.panel1.Controls.Add(this.Питание);
            this.panel1.Controls.Add(this.Категория);
            this.panel1.Location = new System.Drawing.Point(55, 182);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 356);
            this.panel1.TabIndex = 21;
            // 
            // max
            // 
            this.max.Location = new System.Drawing.Point(392, 323);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(86, 23);
            this.max.TabIndex = 10;
            // 
            // min
            // 
            this.min.Location = new System.Drawing.Point(193, 323);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(86, 23);
            this.min.TabIndex = 9;
            // 
            // category
            // 
            this.category.FormattingEnabled = true;
            this.category.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.category.Location = new System.Drawing.Point(281, 17);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(121, 23);
            this.category.TabIndex = 8;
            // 
            // maxCost
            // 
            this.maxCost.Location = new System.Drawing.Point(365, 290);
            this.maxCost.Maximum = 100000;
            this.maxCost.Minimum = 50000;
            this.maxCost.Name = "maxCost";
            this.maxCost.Size = new System.Drawing.Size(154, 45);
            this.maxCost.TabIndex = 7;
            this.maxCost.Value = 50000;
            this.maxCost.Scroll += new System.EventHandler(this.maxCost_Scroll);
            // 
            // misCost
            // 
            this.misCost.Location = new System.Drawing.Point(166, 290);
            this.misCost.Maximum = 50000;
            this.misCost.Name = "misCost";
            this.misCost.Size = new System.Drawing.Size(154, 45);
            this.misCost.TabIndex = 6;
            this.misCost.Scroll += new System.EventHandler(this.Стоимость_Scroll);
            // 
            // СтоимостьТура
            // 
            this.СтоимостьТура.AutoSize = true;
            this.СтоимостьТура.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.СтоимостьТура.Location = new System.Drawing.Point(267, 257);
            this.СтоимостьТура.Name = "СтоимостьТура";
            this.СтоимостьТура.Size = new System.Drawing.Size(123, 21);
            this.СтоимостьТура.TabIndex = 5;
            this.СтоимостьТура.Text = "Стоимость тура";
            // 
            // ДополнительныеУслуги
            // 
            this.ДополнительныеУслуги.AutoSize = true;
            this.ДополнительныеУслуги.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ДополнительныеУслуги.Location = new System.Drawing.Point(138, 115);
            this.ДополнительныеУслуги.Name = "ДополнительныеУслуги";
            this.ДополнительныеУслуги.Size = new System.Drawing.Size(184, 21);
            this.ДополнительныеУслуги.TabIndex = 4;
            this.ДополнительныеУслуги.Text = "Дополнительные Услуги";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Трансфер);
            this.panel2.Controls.Add(this.Кондиционер);
            this.panel2.Controls.Add(this.WIFI);
            this.panel2.Controls.Add(this.Эксклюзив);
            this.panel2.Controls.Add(this.VIP);
            this.panel2.Controls.Add(this.Свадьба);
            this.panel2.Controls.Add(this.FIT);
            this.panel2.Controls.Add(this.Sport);
            this.panel2.Controls.Add(this.SPA);
            this.panel2.Location = new System.Drawing.Point(138, 139);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(409, 100);
            this.panel2.TabIndex = 3;
            // 
            // Трансфер
            // 
            this.Трансфер.AutoSize = true;
            this.Трансфер.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Трансфер.Location = new System.Drawing.Point(274, 65);
            this.Трансфер.Name = "Трансфер";
            this.Трансфер.Size = new System.Drawing.Size(98, 25);
            this.Трансфер.TabIndex = 8;
            this.Трансфер.Text = "Трансфер";
            this.Трансфер.UseVisualStyleBackColor = true;
            // 
            // Кондиционер
            // 
            this.Кондиционер.AutoSize = true;
            this.Кондиционер.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Кондиционер.Location = new System.Drawing.Point(274, 40);
            this.Кондиционер.Name = "Кондиционер";
            this.Кондиционер.Size = new System.Drawing.Size(128, 25);
            this.Кондиционер.TabIndex = 7;
            this.Кондиционер.Text = "Кондиционер";
            this.Кондиционер.UseVisualStyleBackColor = true;
            // 
            // WIFI
            // 
            this.WIFI.AutoSize = true;
            this.WIFI.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WIFI.Location = new System.Drawing.Point(274, 15);
            this.WIFI.Name = "WIFI";
            this.WIFI.Size = new System.Drawing.Size(66, 25);
            this.WIFI.TabIndex = 6;
            this.WIFI.Text = "Wi-Fi";
            this.WIFI.UseVisualStyleBackColor = true;
            // 
            // Эксклюзив
            // 
            this.Эксклюзив.AutoSize = true;
            this.Эксклюзив.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Эксклюзив.Location = new System.Drawing.Point(154, 65);
            this.Эксклюзив.Name = "Эксклюзив";
            this.Эксклюзив.Size = new System.Drawing.Size(107, 25);
            this.Эксклюзив.TabIndex = 5;
            this.Эксклюзив.Text = "Эксклюзив";
            this.Эксклюзив.UseVisualStyleBackColor = true;
            // 
            // VIP
            // 
            this.VIP.AutoSize = true;
            this.VIP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VIP.Location = new System.Drawing.Point(154, 40);
            this.VIP.Name = "VIP";
            this.VIP.Size = new System.Drawing.Size(52, 25);
            this.VIP.TabIndex = 4;
            this.VIP.Text = "VIP";
            this.VIP.UseVisualStyleBackColor = true;
            // 
            // Свадьба
            // 
            this.Свадьба.AutoSize = true;
            this.Свадьба.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Свадьба.Location = new System.Drawing.Point(154, 15);
            this.Свадьба.Name = "Свадьба";
            this.Свадьба.Size = new System.Drawing.Size(89, 25);
            this.Свадьба.TabIndex = 3;
            this.Свадьба.Text = "Свадьба";
            this.Свадьба.UseVisualStyleBackColor = true;
            // 
            // FIT
            // 
            this.FIT.AutoSize = true;
            this.FIT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FIT.Location = new System.Drawing.Point(28, 65);
            this.FIT.Name = "FIT";
            this.FIT.Size = new System.Drawing.Size(49, 25);
            this.FIT.TabIndex = 2;
            this.FIT.Text = "FIT";
            this.FIT.UseVisualStyleBackColor = true;
            // 
            // Sport
            // 
            this.Sport.AutoSize = true;
            this.Sport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Sport.Location = new System.Drawing.Point(28, 40);
            this.Sport.Name = "Sport";
            this.Sport.Size = new System.Drawing.Size(67, 25);
            this.Sport.TabIndex = 1;
            this.Sport.Text = "Sport";
            this.Sport.UseVisualStyleBackColor = true;
            // 
            // SPA
            // 
            this.SPA.AutoSize = true;
            this.SPA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SPA.Location = new System.Drawing.Point(28, 15);
            this.SPA.Name = "SPA";
            this.SPA.Size = new System.Drawing.Size(56, 25);
            this.SPA.TabIndex = 0;
            this.SPA.Text = "SPA";
            this.SPA.UseVisualStyleBackColor = true;
            // 
            // type
            // 
            this.type.FormattingEnabled = true;
            this.type.Items.AddRange(new object[] {
            "Не имеет значения"});
            this.type.Location = new System.Drawing.Point(281, 60);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(152, 23);
            this.type.TabIndex = 2;
            // 
            // Питание
            // 
            this.Питание.AutoSize = true;
            this.Питание.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Питание.Location = new System.Drawing.Point(166, 58);
            this.Питание.Name = "Питание";
            this.Питание.Size = new System.Drawing.Size(99, 21);
            this.Питание.TabIndex = 1;
            this.Питание.Text = "Тип питания";
            // 
            // Категория
            // 
            this.Категория.AutoSize = true;
            this.Категория.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Категория.Location = new System.Drawing.Point(138, 17);
            this.Категория.Name = "Категория";
            this.Категория.Size = new System.Drawing.Size(127, 21);
            this.Категория.TabIndex = 0;
            this.Категория.Text = "Категория отеля";
            // 
            // пропустить
            // 
            this.пропустить.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.пропустить.Location = new System.Drawing.Point(223, 555);
            this.пропустить.Name = "пропустить";
            this.пропустить.Size = new System.Drawing.Size(111, 38);
            this.пропустить.TabIndex = 23;
            this.пропустить.Text = "Пропустить";
            this.пропустить.UseVisualStyleBackColor = true;
            this.пропустить.Click += new System.EventHandler(this.пропустить_Click);
            // 
            // далее
            // 
            this.далее.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.далее.Location = new System.Drawing.Point(392, 555);
            this.далее.Name = "далее";
            this.далее.Size = new System.Drawing.Size(96, 38);
            this.далее.TabIndex = 22;
            this.далее.Text = "Далее";
            this.далее.UseVisualStyleBackColor = true;
            this.далее.Click += new System.EventHandler(this.далее_Click);
            // 
            // шаг
            // 
            this.шаг.AutoSize = true;
            this.шаг.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.шаг.Font = new System.Drawing.Font("Segoe UI", 18.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.шаг.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.шаг.Location = new System.Drawing.Point(358, 74);
            this.шаг.Name = "шаг";
            this.шаг.Size = new System.Drawing.Size(87, 35);
            this.шаг.TabIndex = 24;
            this.шаг.Text = "ШАГ 3";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.checkBox1);
            this.panel3.Controls.Add(this.checkBox2);
            this.panel3.Controls.Add(this.checkBox3);
            this.panel3.Controls.Add(this.checkBox4);
            this.panel3.Controls.Add(this.checkBox5);
            this.panel3.Controls.Add(this.checkBox6);
            this.panel3.Controls.Add(this.checkBox7);
            this.panel3.Controls.Add(this.checkBox8);
            this.panel3.Controls.Add(this.checkBox9);
            this.panel3.Location = new System.Drawing.Point(193, 217);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(409, 100);
            this.panel3.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.Location = new System.Drawing.Point(274, 65);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 25);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Трансфер";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox2.Location = new System.Drawing.Point(274, 40);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(128, 25);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "Кондиционер";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox3.Location = new System.Drawing.Point(274, 15);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(66, 25);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.Text = "Wi-Fi";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox4.Location = new System.Drawing.Point(154, 65);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(107, 25);
            this.checkBox4.TabIndex = 5;
            this.checkBox4.Text = "Эксклюзив";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox5.Location = new System.Drawing.Point(154, 40);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(52, 25);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "VIP";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox6.Location = new System.Drawing.Point(154, 15);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(89, 25);
            this.checkBox6.TabIndex = 3;
            this.checkBox6.Text = "Свадьба";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox7.Location = new System.Drawing.Point(28, 65);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(49, 25);
            this.checkBox7.TabIndex = 2;
            this.checkBox7.Text = "FIT";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox8.Location = new System.Drawing.Point(28, 40);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(67, 25);
            this.checkBox8.TabIndex = 1;
            this.checkBox8.Text = "Sport";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox9.Location = new System.Drawing.Point(28, 15);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(56, 25);
            this.checkBox9.TabIndex = 0;
            this.checkBox9.Text = "SPA";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(336, 245);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(86, 23);
            this.textBox3.TabIndex = 10;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 605);
            this.Controls.Add(this.шаг);
            this.Controls.Add(this.пропустить);
            this.Controls.Add(this.далее);
            this.Controls.Add(this.Условия);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Избранное);
            this.Controls.Add(this.поиск);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.misCost)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Избранное;
        private System.Windows.Forms.Button поиск;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Условия;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Категория;
        private System.Windows.Forms.Button пропустить;
        private System.Windows.Forms.Button далее;
        private System.Windows.Forms.ComboBox типПитания;
        private System.Windows.Forms.Label Питание;
        private System.Windows.Forms.TrackBar misCost;
        private System.Windows.Forms.Label СтоимостьТура;
        private System.Windows.Forms.Label ДополнительныеУслуги;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox Трансфер;
        private System.Windows.Forms.CheckBox Кондиционер;
        private System.Windows.Forms.CheckBox WIFI;
        private System.Windows.Forms.CheckBox Эксклюзив;
        private System.Windows.Forms.CheckBox VIP;
        private System.Windows.Forms.CheckBox Свадьба;
        private System.Windows.Forms.CheckBox FIT;
        private System.Windows.Forms.CheckBox Sport;
        private System.Windows.Forms.CheckBox SPA;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ComboBox категорияОтеля;
        private System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.Label шаг;
        private System.Windows.Forms.TextBox max;
        private System.Windows.Forms.TextBox min;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TrackBar maxCost;
        private System.Windows.Forms.ComboBox категорияОтеля;
    }
}