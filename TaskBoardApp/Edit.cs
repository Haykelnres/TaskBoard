using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TaskBoardApp
{
    public partial class Edit : Form
    {
        public void edit()
        {
            string connectionText = @"Server=localhost\SQLEXPRESS;Database=TaskBoardDB;Trusted_Connection=True;TrustServerCertificate=True";
            string requestForWorker = @"select performerID from Performers where performerName = '" + comboBox2.Text + "'";

            using (SqlConnection connection = new SqlConnection(connectionText))
            {
                using (SqlCommand commandBuilder = new SqlCommand())
                {
                    commandBuilder.Connection = connection;
                    connection.Open();
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
                    //изменение состава задачи
                    string createRequest = @"update specificTasks set specificTasksName ='" + textBox1.Text + "',specificTasksWorkerID='" + workerId + "', specificTasksDateOfStart='" + dateTimePicker1.Text + "', specificTasksDateOfEnd='" + dateTimePicker2.Text + "',specificTasksDateOfActualEnd='" + dateTimePicker3.Text + "', specificTasksStatus='" + comboBox3.Text + "', specificTasksWarn='" + richTextBox1.Text + "', specificTasksCommentary='" + richTextBox2.Text + "' where specificTasksID = '" + textBox6.Text + "'";
                    commandBuilder.CommandText = createRequest;
                    commandBuilder.ExecuteNonQuery();
                    connection.Close();
                }
            }

        }
        public void fillCB()// ЗАПОЛНЕНИЕ ИСХОДНЫМИ ДАННЫМИ ИЗ БД ВСЕХ comboBox
        {
            string connectionText = @"Server=localhost\SQLEXPRESS;Database=TaskBoardDB;Trusted_Connection=True;TrustServerCertificate=True";
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

                connection.Close();

            }
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.Items.AddRange(new object[] { "ВЫПОЛНЕНО", "В РАБОТЕ", "В ОЖИДАНИИ", "ПРОСРОЧЕНО" });
        }
        public Edit(string sptaskid, string id, string taskname, string worker, string datestart, string dateend, string status, string comment, string warn, string specificTaskDateOfActualEnd)
        {
            string itid = sptaskid;
            InitializeComponent();
            fillCB();
            textBox2.Text = id;
            textBox1.Text = taskname;
            comboBox2.Text = worker;
            comboBox3.Text = status;
            dateTimePicker1.Text = datestart;
            dateTimePicker2.Text = dateend;
            dateTimePicker3.Text = specificTaskDateOfActualEnd;
            richTextBox1.Text = warn;
            richTextBox2.Text = comment;
            comboBox2.MaxLength = 200;
            textBox6.Visible = false;
            textBox6.Text = sptaskid;

        }

        private void Edit_Load(object sender, EventArgs e)
        {

        }

        private void close_window_button_click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void edit_task_button_click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") { MessageBox.Show("Название подзадачи должно присутствовать"); return; }
            if (comboBox2.Text == "") { MessageBox.Show("ФИО исполнителя должно присутствовать"); return; }
            if (comboBox3.Text == "") { MessageBox.Show("Выберите статус задачи"); return; }
            edit();
            this.Hide();
        }
    }
}
