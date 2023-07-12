namespace TaskBoardApp
{
    partial class Create
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            comboBox2 = new ComboBox();
            monthCalendar1 = new MonthCalendar();
            monthCalendar2 = new MonthCalendar();
            comboBox3 = new ComboBox();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 6);
            label1.Name = "label1";
            label1.Size = new Size(237, 15);
            label1.TabIndex = 0;
            label1.Text = "Название проекта/Договора/Контрагента";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 50);
            label2.Name = "label2";
            label2.Size = new Size(208, 15);
            label2.TabIndex = 1;
            label2.Text = "Подзадача/задача по спецификации";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(144, 94);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 2;
            label3.Text = "Исполнитель";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(351, 6);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 3;
            label4.Text = "Срок начала";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(337, 195);
            label5.Name = "label5";
            label5.Size = new Size(112, 15);
            label5.TabIndex = 4;
            label5.Text = "Контрольный срок";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(161, 138);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 5;
            label6.Text = "Статус";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(144, 182);
            label7.Name = "label7";
            label7.Size = new Size(78, 15);
            label7.TabIndex = 6;
            label7.Text = "Примечания";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(95, 24);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(178, 23);
            comboBox1.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(95, 68);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(178, 23);
            textBox1.TabIndex = 8;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(95, 112);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(178, 23);
            comboBox2.TabIndex = 9;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(309, 24);
            monthCalendar1.MaxSelectionCount = 1;
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 10;
            // 
            // monthCalendar2
            // 
            monthCalendar2.Location = new Point(309, 219);
            monthCalendar2.MaxSelectionCount = 1;
            monthCalendar2.Name = "monthCalendar2";
            monthCalendar2.TabIndex = 11;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(95, 156);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(178, 23);
            comboBox3.TabIndex = 12;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(95, 200);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(178, 181);
            richTextBox1.TabIndex = 14;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(144, 412);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 15;
            button1.Text = "Создать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += create_new_task_button_click;
            // 
            // button2
            // 
            button2.Location = new Point(353, 412);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 16;
            button2.Text = "Отмена";
            button2.UseVisualStyleBackColor = true;
            button2.Click += close_window_button_click;
            // 
            // Create
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(comboBox3);
            Controls.Add(monthCalendar2);
            Controls.Add(monthCalendar1);
            Controls.Add(comboBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Create";
            Text = "Create";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private ComboBox comboBox2;
        private MonthCalendar monthCalendar1;
        private MonthCalendar monthCalendar2;
        private ComboBox comboBox3;
        private RichTextBox richTextBox1;
        private Button button1;
        private Button button2;
    }
}