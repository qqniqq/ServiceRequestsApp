using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace ServiceRequestsApp
{
    public partial class MainForm : Form
    {
        private const string connectionString = "Data Source=requests.db";

        public MainForm()
        {
            InitializeComponent();
            CreateDatabase();
            LoadRequests();
        }
        private void CreateDatabase()
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string sql =
                @"CREATE TABLE IF NOT EXISTS Requests (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    FullName TEXT,
                    Department TEXT,
                    Contact TEXT,
                    DateCreated TEXT,
                    ProblemType TEXT,
                    Description TEXT,
                    Priority TEXT,
                    Specialist TEXT,
                    Status TEXT
                )";

                new SQLiteCommand(sql, connection).ExecuteNonQuery();
            }
        }
        private void LoadRequests()
        {
            using (var adapter = new SQLiteDataAdapter("SELECT * FROM Requests", connectionString))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewRequests.DataSource = table;

                dataGridViewRequests.Columns["Id"].HeaderText = "ID";
                dataGridViewRequests.Columns["FullName"].HeaderText = "ФИО сотрудника";
                dataGridViewRequests.Columns["Department"].HeaderText = "Подразделение";
                dataGridViewRequests.Columns["Contact"].HeaderText = "Контакты";
                dataGridViewRequests.Columns["DateCreated"].HeaderText = "Дата заявки";
                dataGridViewRequests.Columns["ProblemType"].HeaderText = "Тип неисправности";
                dataGridViewRequests.Columns["Description"].HeaderText = "Описание проблемы";
                dataGridViewRequests.Columns["Priority"].HeaderText = "Приоритет";
                dataGridViewRequests.Columns["Specialist"].HeaderText = "Ответственный";
                dataGridViewRequests.Columns["Status"].HeaderText = "Статус";
            }
        }

        private void btnAddRequest_Click(object sender, EventArgs e)
        {
            AddRequestForm form = new AddRequestForm();
            form.ShowDialog();
            LoadRequests();
        }
        private void SearchRequests(string searchText)
        {
            using (var adapter = new SQLiteDataAdapter(
                "SELECT * FROM Requests WHERE FullName LIKE @text OR Department LIKE @text",
                connectionString))
            {
                adapter.SelectCommand.Parameters.AddWithValue("@text", "%" + searchText + "%");

                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewRequests.DataSource = table;
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchRequests(txtSearch.Text);
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void comboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (dataGridViewRequests.CurrentRow == null)
                return;

            int id = Convert.ToInt32(dataGridViewRequests.CurrentRow.Cells["Id"].Value);

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string sql = "UPDATE Requests SET Status = @Status WHERE Id = @Id";
                SQLiteCommand cmd = new SQLiteCommand(sql, connection);
                cmd.Parameters.AddWithValue("@Status", comboStatus.Text);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }

            LoadRequests();
            MessageBox.Show("Статус заявки изменён");
        }
    }
}
