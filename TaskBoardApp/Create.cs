using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace TaskBoardApp
{
    public partial class Create : Form
    {
        string connectionText = @"Server=localhost\SQLEXPRESS;Database=TaskBoardDB;Trusted_Connection=True;TrustServerCertificate=True";
        public void fillCB()// заполнение исходными данными из бд comboBox
        {
            
            using (SqlConnection connection = new SqlConnection(connectionText))
            {
                string performers = "select performerName from Performers";
                string projects = "select taskName from taskData";
                connection.Open();
                SqlCommand dat = new SqlCommand(performers, connection);
                SqlDataReader DR = dat.ExecuteReader();
                while (DR.Read())
                {
                    comboBox2.Items.Add(DR[0]);
                }
                DR.Close();
                SqlCommand dat2 = new SqlCommand(projects, connection);
                SqlDataReader DR2 = dat2.ExecuteReader();
                while (DR2.Read())
                {
                    comboBox1.Items.Add(DR2[0]);
                }
                connection.Close();
                DR2.Close();
            }
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.Items.AddRange(new object[] { "ВЫПОЛНЕНО", "В РАБОТЕ", "В ОЖИДАНИИ", "ПРОСРОЧЕНО" });
        }
        public void createTask()// метод для создания новой задачи
        {
            string requestForId = @"select taskID from taskData where taskName = '" + comboBox1.Text + "'";
            string requestForWorker = @"select performerID from Performers where performerName = '" + comboBox2.Text + "'";
            using (SqlConnection connection = new SqlConnection(connectionText))
            {
                using (SqlCommand commandBuilder = new SqlCommand())
                {
                    commandBuilder.Connection = connection;
                    connection.Open();
                    commandBuilder.CommandText = requestForId;
                    int taskId = Convert.ToInt32(commandBuilder.ExecuteScalar());//проверка на наличие проекта с заданным именем
                    if (taskId == 0)
                    {
                        string createTaskrn = @"insert into taskData(taskName) values ('" + comboBox1.Text + "')";//добавление нового проекта с заданным именем в бд
                        commandBuilder.CommandText = createTaskrn;
                        commandBuilder.ExecuteNonQuery();
                        commandBuilder.CommandText = requestForId;
                        taskId = (int)commandBuilder.ExecuteScalar();
                    }
                    commandBuilder.CommandText = requestForWorker;
                    int workerId = Convert.ToInt32(commandBuilder.ExecuteScalar());//проверка на наличие работника с заданным именем
                    if (workerId == 0)
                    {
                        string createTaskrn = @"insert into Performers(performerName) values ('" + comboBox2.Text + "')";//добавление нового работника с заданным именем в бд
                        commandBuilder.CommandText = createTaskrn;
                        commandBuilder.ExecuteNonQuery();
                        commandBuilder.CommandText = requestForWorker;
                        workerId = (int)commandBuilder.ExecuteScalar();
                    }
                    //Создание задачи
                    string createRequest = @"insert into specificTasks(specificTasksName,specificTasksWorkerID, specificTasksDateOfStart,specificTasksDateOfEnd,specificTasksStatus,specificTasksWarn, taskID) values ('" + textBox1.Text + "','" + workerId + "', '" + monthCalendar1.SelectionRange.Start + "', '" + monthCalendar2.SelectionRange.Start + "', '" + comboBox3.Text + "', '" + richTextBox1.Text + "', '" + taskId + "')";
                    commandBuilder.CommandText = createRequest;
                    commandBuilder.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
        public Create()
        {
            InitializeComponent();
            fillCB();
            textBox1.MaxLength = 200;
            comboBox2.MaxLength = 200;
            comboBox1.MaxLength = 200;
            richTextBox1.MaxLength = 500;
        }

        private void close_window_button_click(object sender, EventArgs e)//Выход из окна
        {
            this.Hide();
        }

        private void create_new_task_button_click(object sender, EventArgs e)//обработчик клика создания новой задачи
        {      
            if (comboBox1.Text == "") { MessageBox.Show("Название проекта должно присутствовать"); return; }
            if (textBox1.Text == "") { MessageBox.Show("Название подзадачи должно присутствовать"); return; }
            if (comboBox2.Text == "") { MessageBox.Show("ФИО исполнителя должно присутствовать"); return; }
            if (comboBox3.Text == "") { MessageBox.Show("Выберите статус задачи"); return; }
            createTask();
            this.Hide();
        }
    }
}
