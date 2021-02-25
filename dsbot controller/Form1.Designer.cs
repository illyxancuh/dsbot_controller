namespace dsbot_controller
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.BanKickTB = new System.Windows.Forms.TextBox();
            this.Banbutton = new System.Windows.Forms.Button();
            this.Kickbutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Activitylabel = new System.Windows.Forms.Label();
            this.BStatuslabel = new System.Windows.Forms.Label();
            this.SCountlabel = new System.Windows.Forms.Label();
            this.Botname = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Activitybutton = new System.Windows.Forms.Button();
            this.ActivityTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Mentionlabel = new System.Windows.Forms.LinkLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Msgupd = new System.Windows.Forms.NumericUpDown();
            this.BanCB = new System.Windows.Forms.CheckBox();
            this.findTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.findButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.listBox4 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Msgupd)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(335, 20);
            this.textBox1.TabIndex = 0;
            this.toolTip1.SetToolTip(this.textBox1, "Сюда происходит ввод токена вашего бота");
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(-2, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите свой токен бота к которому хотите подключиться";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(1, 63);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(182, 160);
            this.listBox1.TabIndex = 3;
            this.toolTip1.SetToolTip(this.listBox1, "Здесь выводяться сервера к которым подключен бот");
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(1, 229);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(182, 342);
            this.listBox2.TabIndex = 4;
            this.toolTip1.SetToolTip(this.listBox2, "Текстовые каналы на выбраном сервере");
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(342, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Найти бота";
            this.toolTip1.SetToolTip(this.button1, "Кнопка которая запускает процес подключения к боту");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(189, 63);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(234, 131);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            this.toolTip1.SetToolTip(this.richTextBox1, "Поле для отправки сообщения");
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(189, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(234, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Отправить сообщение";
            this.toolTip1.SetToolTip(this.button2, "Кнопка отправки сообщения");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(429, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(521, 212);
            this.dataGridView1.TabIndex = 9;
            this.toolTip1.SetToolTip(this.dataGridView1, "Сообщения в выбраном канале");
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ник пользователя";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 115;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Сообщение";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 90;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(189, 229);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(147, 342);
            this.listBox3.TabIndex = 10;
            this.toolTip1.SetToolTip(this.listBox3, "Пользвователи в выбраном канале");
            this.listBox3.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(875, 229);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Обновить";
            this.toolTip1.SetToolTip(this.button3, "Обновить список сообщений в выбраном канале");
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BanKickTB
            // 
            this.BanKickTB.Location = new System.Drawing.Point(342, 232);
            this.BanKickTB.Name = "BanKickTB";
            this.BanKickTB.Size = new System.Drawing.Size(167, 20);
            this.BanKickTB.TabIndex = 12;
            this.BanKickTB.Text = "Причина бана/кика";
            // 
            // Banbutton
            // 
            this.Banbutton.Location = new System.Drawing.Point(342, 258);
            this.Banbutton.Name = "Banbutton";
            this.Banbutton.Size = new System.Drawing.Size(81, 23);
            this.Banbutton.TabIndex = 13;
            this.Banbutton.Text = "Бан";
            this.toolTip1.SetToolTip(this.Banbutton, "Забанить указаного человека с причиной введеной  поле выше");
            this.Banbutton.UseVisualStyleBackColor = true;
            this.Banbutton.Click += new System.EventHandler(this.Banbutton_Click);
            // 
            // Kickbutton
            // 
            this.Kickbutton.Location = new System.Drawing.Point(429, 258);
            this.Kickbutton.Name = "Kickbutton";
            this.Kickbutton.Size = new System.Drawing.Size(80, 23);
            this.Kickbutton.TabIndex = 14;
            this.Kickbutton.Text = "Кик";
            this.toolTip1.SetToolTip(this.Kickbutton, "Кикнуть указаного человека с причиной введеной  поле выше");
            this.Kickbutton.UseVisualStyleBackColor = true;
            this.Kickbutton.Click += new System.EventHandler(this.Kickbutton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Activitylabel);
            this.panel1.Controls.Add(this.BStatuslabel);
            this.panel1.Controls.Add(this.SCountlabel);
            this.panel1.Controls.Add(this.Botname);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(688, 403);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 168);
            this.panel1.TabIndex = 15;
            // 
            // Activitylabel
            // 
            this.Activitylabel.Location = new System.Drawing.Point(3, 47);
            this.Activitylabel.Name = "Activitylabel";
            this.Activitylabel.Size = new System.Drawing.Size(123, 43);
            this.Activitylabel.TabIndex = 17;
            this.Activitylabel.Text = "Активность: ";
            // 
            // BStatuslabel
            // 
            this.BStatuslabel.AutoSize = true;
            this.BStatuslabel.Location = new System.Drawing.Point(3, 25);
            this.BStatuslabel.Name = "BStatuslabel";
            this.BStatuslabel.Size = new System.Drawing.Size(44, 13);
            this.BStatuslabel.TabIndex = 16;
            this.BStatuslabel.Text = "Статус:";
            // 
            // SCountlabel
            // 
            this.SCountlabel.AutoSize = true;
            this.SCountlabel.Location = new System.Drawing.Point(3, 3);
            this.SCountlabel.Name = "SCountlabel";
            this.SCountlabel.Size = new System.Drawing.Size(53, 13);
            this.SCountlabel.TabIndex = 2;
            this.SCountlabel.Text = "Сервера:";
            // 
            // Botname
            // 
            this.Botname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Botname.Location = new System.Drawing.Point(129, 133);
            this.Botname.Name = "Botname";
            this.Botname.Size = new System.Drawing.Size(122, 30);
            this.Botname.TabIndex = 1;
            this.Botname.Text = "Name";
            this.Botname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(132, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Activitybutton
            // 
            this.Activitybutton.Location = new System.Drawing.Point(688, 374);
            this.Activitybutton.Name = "Activitybutton";
            this.Activitybutton.Size = new System.Drawing.Size(262, 23);
            this.Activitybutton.TabIndex = 16;
            this.Activitybutton.Text = "Задать активность";
            this.toolTip1.SetToolTip(this.Activitybutton, "Задать активность введеную в поле выше");
            this.Activitybutton.UseVisualStyleBackColor = true;
            this.Activitybutton.Click += new System.EventHandler(this.Activitybutton_Click);
            // 
            // ActivityTB
            // 
            this.ActivityTB.Location = new System.Drawing.Point(688, 346);
            this.ActivityTB.Name = "ActivityTB";
            this.ActivityTB.Size = new System.Drawing.Size(262, 20);
            this.ActivityTB.TabIndex = 17;
            this.toolTip1.SetToolTip(this.ActivityTB, "Поле для ввода активности бота");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Упоминание пользователя";
            // 
            // Mentionlabel
            // 
            this.Mentionlabel.AutoSize = true;
            this.Mentionlabel.LinkColor = System.Drawing.Color.Black;
            this.Mentionlabel.Location = new System.Drawing.Point(343, 310);
            this.Mentionlabel.Name = "Mentionlabel";
            this.Mentionlabel.Size = new System.Drawing.Size(67, 13);
            this.Mentionlabel.TabIndex = 19;
            this.Mentionlabel.TabStop = true;
            this.Mentionlabel.Text = "Mentionlabel";
            this.toolTip1.SetToolTip(this.Mentionlabel, "Поле для упоминания выбраного пользователя");
            this.Mentionlabel.Click += new System.EventHandler(this.Mentionlabel_Click);
            // 
            // Msgupd
            // 
            this.Msgupd.Location = new System.Drawing.Point(822, 229);
            this.Msgupd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Msgupd.Name = "Msgupd";
            this.Msgupd.Size = new System.Drawing.Size(47, 20);
            this.Msgupd.TabIndex = 20;
            this.toolTip1.SetToolTip(this.Msgupd, "Количество выводимых сообщений в таблицу выше(минимум 1, максимум 100)");
            this.Msgupd.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // BanCB
            // 
            this.BanCB.AutoSize = true;
            this.BanCB.Location = new System.Drawing.Point(515, 235);
            this.BanCB.Name = "BanCB";
            this.BanCB.Size = new System.Drawing.Size(113, 17);
            this.BanCB.TabIndex = 21;
            this.BanCB.Text = "Подтвердить бан";
            this.BanCB.UseVisualStyleBackColor = true;
            // 
            // findTB
            // 
            this.findTB.Location = new System.Drawing.Point(12, 25);
            this.findTB.Name = "findTB";
            this.findTB.Size = new System.Drawing.Size(100, 20);
            this.findTB.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Поиск";
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(118, 25);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(75, 20);
            this.findButton.TabIndex = 28;
            this.findButton.Text = "Найти";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.radioButton3);
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Controls.Add(this.findTB);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.findButton);
            this.panel2.Location = new System.Drawing.Point(342, 346);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 125);
            this.panel2.TabIndex = 32;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(12, 97);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(98, 17);
            this.radioButton3.TabIndex = 35;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Пользователь";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(12, 74);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(56, 17);
            this.radioButton2.TabIndex = 34;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Канал";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 51);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(62, 17);
            this.radioButton1.TabIndex = 33;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Сервер";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(548, 346);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(134, 225);
            this.listBox4.TabIndex = 33;
            this.listBox4.SelectedIndexChanged += new System.EventHandler(this.listBox4_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 576);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BanCB);
            this.Controls.Add(this.Msgupd);
            this.Controls.Add(this.Mentionlabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ActivityTB);
            this.Controls.Add(this.Activitybutton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Kickbutton);
            this.Controls.Add(this.Banbutton);
            this.Controls.Add(this.BanKickTB);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DBC app";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Msgupd)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox BanKickTB;
        private System.Windows.Forms.Button Banbutton;
        private System.Windows.Forms.Button Kickbutton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Botname;
        private System.Windows.Forms.Label BStatuslabel;
        private System.Windows.Forms.Label SCountlabel;
        private System.Windows.Forms.Label Activitylabel;
        private System.Windows.Forms.Button Activitybutton;
        private System.Windows.Forms.TextBox ActivityTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel Mentionlabel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NumericUpDown Msgupd;
        private System.Windows.Forms.CheckBox BanCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.TextBox findTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ListBox listBox4;
    }
}

