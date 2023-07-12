namespace TaskBoardApp
{
    partial class Edit
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
            button2 = new Button();
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            richTextBox2 = new RichTextBox();
            label8 = new Label();
            label9 = new Label();
            textBox6 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker3 = new DateTimePicker();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(349, 415);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 32;
            button2.Text = "Отмена";
            button2.UseVisualStyleBackColor = true;
            button2.Click += close_window_button_click;
            // 
            // button1
            // 
            button1.Location = new Point(140, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 31;
            button1.Text = "Изменить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += edit_task_button_click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(58, 203);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(232, 181);
            richTextBox1.TabIndex = 30;
            richTextBox1.Text = "";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(91, 159);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(178, 23);
            comboBox3.TabIndex = 29;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(91, 115);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(178, 23);
            comboBox2.TabIndex = 26;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(91, 71);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(178, 23);
            textBox1.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(140, 185);
            label7.Name = "label7";
            label7.Size = new Size(78, 15);
            label7.TabIndex = 23;
            label7.Text = "Примечания";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(157, 141);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 22;
            label6.Text = "Статус";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(347, 53);
            label5.Name = "label5";
            label5.Size = new Size(112, 15);
            label5.TabIndex = 21;
            label5.Text = "Контрольный срок";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(361, 9);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 20;
            label4.Text = "Срок начала";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(140, 97);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 19;
            label3.Text = "Исполнитель";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 53);
            label2.Name = "label2";
            label2.Size = new Size(208, 15);
            label2.TabIndex = 18;
            label2.Text = "Подзадача/задача по спецификации";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 9);
            label1.Name = "label1";
            label1.Size = new Size(237, 15);
            label1.TabIndex = 17;
            label1.Text = "Название проекта/Договора/Контрагента";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(91, 27);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(178, 23);
            textBox2.TabIndex = 33;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(296, 203);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(232, 181);
            richTextBox2.TabIndex = 36;
            richTextBox2.Text = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(361, 185);
            label8.Name = "label8";
            label8.Size = new Size(84, 15);
            label8.TabIndex = 37;
            label8.Text = "Комментарий";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(316, 97);
            label9.Name = "label9";
            label9.Size = new Size(171, 15);
            label9.TabIndex = 39;
            label9.Text = "Фактический срок окончания";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(316, 159);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 40;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd.mm.yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(306, 27);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 41;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(306, 68);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 42;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Format = DateTimePickerFormat.Short;
            dateTimePicker3.Location = new Point(306, 115);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(200, 23);
            dateTimePicker3.TabIndex = 43;
            // 
            // Edit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 450);
            Controls.Add(dateTimePicker3);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox6);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(richTextBox2);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Edit";
            Text = "Edit";
            Load += Edit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private RichTextBox richTextBox1;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private RichTextBox richTextBox2;
        private Label label8;
        private Label label9;
        private TextBox textBox6;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker3;
    }
}