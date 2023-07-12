using Azure.Core;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using System.Data;
using System.Data.Common;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TaskBoardApp
{

    public partial class TaskBoard : Form
    {
        public void dgcolor()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[8].Value.ToString() == "ВЫПОЛНЕНО")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                }
                else if (dataGridView1.Rows[i].Cells[8].Value.ToString() == "В РАБОТЕ")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
                else if (dataGridView1.Rows[i].Cells[8].Value.ToString() == "ПРОСРОЧЕНО")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.IndianRed;
                }
                else if (dataGridView1.Rows[i].Cells[8].Value.ToString() == "В ОЖИДАНИИ")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LightYellow;
                }
            }
        }
        public void rowDelete()
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells[0].Value);
                string taskIDValue = Convert.ToString(selectedRow.Cells[1].Value);
                string deleteTask = @"delete from specificTasks where specificTasksID = '" + cellValue + "'";
                string taskIDVal = "select count(specificTasksID) from specificTasks where specificTasks.taskID = '" + taskIDValue + "'";
                string taskDelete = "delete from taskData where taskID ='" + taskIDValue + "'";
                using (SqlConnection connection = new SqlConnection(connectionText))
                {
                    SqlCommand command = new SqlCommand(deleteTask, connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                    SQLconnect(fulldatarequest);

                    SqlCommand dat = new SqlCommand(taskIDVal, connection);//Удаление проекта при отсутствии задач
                    SqlDataReader DR = dat.ExecuteReader();
                    DR.Read();
                    if (Convert.ToInt32(DR[0]) == 0)
                    {
                        DR.Close();
                        SqlCommand command2 = new SqlCommand(taskDelete, connection);
                        command2.ExecuteNonQuery();
                    }
                    connection.Close();
                }
                dgcolor();
            }
        }

        public void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)//выбор id задачи при клике по ряду
        {
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            string cellValue = Convert.ToString(selectedRow.Cells[0].Value);
            dgcolor();
        }

        public void SQLconnect(string task)//метод, заполненяющий данными dataGridView1
        {
            using (SqlConnection connection = new SqlConnection(connectionText))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(task, connection);
                var commandBuilder = new SqlCommandBuilder(adapter);
                DataSet FullTaskBoard = new DataSet();
                adapter.Fill(FullTaskBoard);

                dataGridView1.DataSource = FullTaskBoard.Tables[0];
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.Columns[1].HeaderText = "Номер проекта";
                dataGridView1.Columns[2].HeaderText = "Название проекта";
                dataGridView1.Columns[3].HeaderText = "Подзадачи";
                dataGridView1.Columns[4].HeaderText = "Исполнитель";
                dataGridView1.Columns[5].HeaderText = "Срок начала";
                dataGridView1.Columns[6].HeaderText = "Фактический срок окончания";
                dataGridView1.Columns[7].HeaderText = "Срок окончания контрольный";
                dataGridView1.Columns[8].HeaderText = "Статус";
                dataGridView1.Columns[9].HeaderText = "Комментарий что сделано";
                dataGridView1.Columns[10].HeaderText = "Примечания";
                dataGridView1.Columns[1].Width = 50;
                dataGridView1.Columns[5].Width = 90;
                dataGridView1.Columns[6].Width = 90;
                dataGridView1.Columns[7].Width = 90;
                dataGridView1.Columns[8].Width = 100;
                dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                connection.Close();
            };
        }
        string connectionText = @"Server=localhost\SQLEXPRESS;Database=TaskBoardDB;Trusted_Connection=True;TrustServerCertificate=True";
        string fulldatarequest = "select specificTasks.specificTasksID,taskData.taskID,taskData.taskName,specificTasks.specificTasksName," +
            "Performers.performerName,specificTasks.specificTasksDateOfStart,specificTasks.specificTasksDateOfActualEnd," +
            "specificTasks.specificTasksDateOfEnd,specificTasks.specificTasksStatus,specificTasks.specificTasksCommentary," +
            "specificTasks.specificTasksWarn\r\nfrom taskData join specificTasks on taskData.taskID=specificTasks.taskID join Performers " +
            "on specificTasks.specificTasksWorkerID=Performers.performerID ";
        public TaskBoard()
        {
            InitializeComponent();
            dataGridView1.ReadOnly = true;
            dgcolor();
        }

        private void TaskBoard_Load(object sender, EventArgs e)
        {

            SQLconnect(fulldatarequest);
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            dataGridView1.Columns[0].Visible = false;
            dgcolor();


        }

        private void search_button_click(object sender, EventArgs e)//ПОИСК ПО ЗАПРОСУ ИЗ textBox1
        {
            var searchText = textBox1.Text;
            string searchrequest = "select specificTasks.specificTasksID,taskData.taskID,taskData.taskName,specificTasks.specificTasksName," +
            "Performers.performerName,specificTasks.specificTasksDateOfStart,specificTasks.specificTasksDateOfActualEnd," +
            "specificTasks.specificTasksDateOfEnd,specificTasks.specificTasksStatus,specificTasks.specificTasksCommentary," +
            "specificTasks.specificTasksWarn\r\nfrom taskData join specificTasks on taskData.taskID=specificTasks.taskID join Performers " +
            "on specificTasks.specificTasksWorkerID=Performers.performerID " +
            "where taskData.taskID like ('%'+ '" + searchText + "' +'%') or taskData.taskName like ('%'+ '" + searchText + "' +'%') or specificTasks.specificTasksName like ('%'+ '" + searchText + "' +'%') or " +
            "Performers.performerName like ('%'+ '" + searchText + "' +'%') or specificTasks.specificTasksDateOfStart like ('%'+ '" + searchText + "' +'%') \r\nor " +
            "specificTasks.specificTasksDateOfActualEnd like ('%'+ '" + searchText + "' +'%') or specificTasks.specificTasksDateOfEnd like ('%'+ '" + searchText + "' +'%') or " +
            "specificTasks.specificTasksStatus like ('%'+ '" + searchText + "' +'%') or specificTasks.specificTasksCommentary like ('%'+ '" + searchText + "' +'%') or " +
            "specificTasks.specificTasksWarn like ('%'+ '" + searchText + "' +'%')\r\n";
            SQLconnect(searchrequest);
            dgcolor();
        }
        private void open_create_window_click(object sender, EventArgs e)//ПЕРЕХОД К ОКНУ СОЗДАНИЯ ЗАДАЧ
        {
            Create create = new Create();
            create.ShowDialog();
            this.SQLconnect(fulldatarequest);
            dgcolor();
        }

        private void open_edit_window_click(object sender, EventArgs e)//ПЕРЕХОД К ОКНУ ИЗМЕНЕНИЯ ЗАДАЧ
        {
            try
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                string taskid = Convert.ToString(selectedRow.Cells[0].Value);
                string specificTaskId = Convert.ToString(selectedRow.Cells[2].Value);
                string specificTaskName = Convert.ToString(selectedRow.Cells[3].Value);
                string specificTaskWorker = Convert.ToString(selectedRow.Cells[4].Value);
                string specificTaskDateOfStart = Convert.ToString(selectedRow.Cells[5].Value);
                string specificTaskDateOfEnd = Convert.ToString(selectedRow.Cells[6].Value);
                string specificTaskStatus = Convert.ToString(selectedRow.Cells[8].Value);
                string specificTaskComment = Convert.ToString(selectedRow.Cells[9].Value);
                string specificTaskWarn = Convert.ToString(selectedRow.Cells[10].Value);
                string specificTaskDateOfActualEnd = Convert.ToString(selectedRow.Cells[7].Value);

                Edit edit = new Edit(taskid, specificTaskId, specificTaskName, specificTaskWorker, specificTaskDateOfStart, specificTaskDateOfEnd, specificTaskStatus, specificTaskComment, specificTaskWarn, specificTaskDateOfActualEnd);
                edit.ShowDialog();
                this.SQLconnect(fulldatarequest);
                dgcolor();
            }
            catch (Exception) { MessageBox.Show("Выберите задачу, которую хотите изменить"); }
        }



        private void delete_row_button_click(object sender, EventArgs e)//удаление выбранной строки с задачей
        {
            rowDelete();
        }

        private void clear_search_task_button_Click(object sender, EventArgs e)
        {
            SQLconnect(fulldatarequest);
            textBox1.Text = string.Empty;
            dgcolor();
        }
    }
}