using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace ServiceRequestsApp
{
    public partial class MainForm : Form
    {
        private const string connectionString = "Data Source=requests.db";

        private string currentUser;
        private string currentRole;

        public MainForm(string fullName, string role)
        {
            InitializeComponent();

            currentUser = fullName;
            currentRole = role;

            lblUser.Text = $"Пользователь: {currentUser} ({currentRole})";

            ApplyRolePermissions();
            LoadRequests();
        }
        private void ApplyRolePermissions()
        {
            if (currentRole != "Специалист IT")
            {
                comboStatus.Visible = false;
                btnUpdateStatus.Visible = false;
                btnReport.Visible = false;
            }
        }

        private void LoadRequests()
        {
            using (var adapter = new SQLiteDataAdapter("SELECT * FROM Requests", connectionString))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewRequests.DataSource = table;
                dataGridViewRequests.ReadOnly = true;
                dataGridViewRequests.AllowUserToAddRows = false;

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

            if (currentRole != "Специалист IT")
            {
                MessageBox.Show("Недостаточно прав для изменения статуса заявки");
                return;
            }

        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchRequests(txtSearch.Text); 
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string sql = @"
SELECT 
    COUNT(*) AS Total,
    SUM(CASE WHEN Status = 'Новая' THEN 1 ELSE 0 END) AS NewCount,
    SUM(CASE WHEN Status = 'В работе' THEN 1 ELSE 0 END) AS WorkCount,
    SUM(CASE WHEN Status = 'Выполнена' THEN 1 ELSE 0 END) AS DoneCount
FROM Requests";

                SQLiteCommand cmd = new SQLiteCommand(sql, connection);
                SQLiteDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string report =
                        $"Всего заявок: {reader["Total"]}\n" +
                        $"Новые: {reader["NewCount"]}\n" +
                        $"В работе: {reader["WorkCount"]}\n" +
                        $"Выполненные: {reader["DoneCount"]}";

                    MessageBox.Show(report, "Отчёт по заявкам");
                }
            }
        }
    }
}
