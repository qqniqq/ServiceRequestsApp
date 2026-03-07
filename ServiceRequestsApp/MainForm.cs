using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ServiceRequestsApp
{
    public partial class MainForm : Form
    {
        private const string connectionString = "Data Source=requests.db";

        private readonly string currentUser;
        private readonly string currentRole;

        public MainForm(string fullName, string role)
        {
            InitializeComponent();

            currentUser = fullName;
            currentRole = role;
            lblUser.Text = $"Пользователь: {currentUser} ({currentRole})";

            dateFrom.Value = DateTime.Today.AddDays(-7);
            dateTo.Value = DateTime.Today;

            ApplyRolePermissions();
            ConfigureTable();
            LoadRequests();
        }

        private void ApplyRolePermissions()
        {
            if (currentRole != "Специалист IT")
            {
                comboStatus.Visible = false;
                btnUpdateStatus.Visible = false;
                btnReport.Visible = false;
                btnEdit.Visible = false;
                btnDetails.Visible = false;
            }
        }

        private void ConfigureTable()
        {
            dataGridViewRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRequests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewRequests.MultiSelect = false;
            dataGridViewRequests.RowHeadersVisible = false;
            dataGridViewRequests.ReadOnly = true;
            dataGridViewRequests.AllowUserToAddRows = false;
            dataGridViewRequests.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dataGridViewRequests.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewRequests.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            dataGridViewRequests.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(245, 247, 252);
            dataGridViewRequests.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(83, 94, 111);
            dataGridViewRequests.EnableHeadersVisualStyles = false;

            dataGridViewRequests.CellFormatting -= DataGridViewRequests_CellFormatting;
            dataGridViewRequests.CellFormatting += DataGridViewRequests_CellFormatting;
        }

        private void DataGridViewRequests_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0 || e.Value == null)
                return;

            if (dataGridViewRequests.Columns[e.ColumnIndex].Name != "Status")
                return;

            string status = e.Value.ToString();
            if (status == "Новая")
            {
                e.CellStyle.BackColor = Color.FromArgb(51, 184, 95);
                e.CellStyle.ForeColor = Color.White;
            }
            else if (status == "В работе")
            {
                e.CellStyle.BackColor = Color.FromArgb(255, 193, 7);
                e.CellStyle.ForeColor = Color.FromArgb(70, 54, 0);
            }
            else if (status == "Выполнена")
            {
                e.CellStyle.BackColor = Color.FromArgb(239, 83, 80);
                e.CellStyle.ForeColor = Color.White;
            }
        }

        private void LoadRequests()
        {
            using (var adapter = new SQLiteDataAdapter("SELECT * FROM Requests ORDER BY Id DESC", connectionString))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                BindTable(table);
            }
        }

        private void BindTable(DataTable table)
        {
            foreach (DataRow row in table.Rows)
            {
                string raw = row["DateCreated"]?.ToString();
                if (DateTime.TryParseExact(raw, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsed))
                {
                    row["DateCreated"] = parsed.ToString("dd.MM.yyyy HH:mm");
                }
            }

            dataGridViewRequests.DataSource = table;

            dataGridViewRequests.Columns["Id"].HeaderText = "№";
            dataGridViewRequests.Columns["FullName"].HeaderText = "ФИО";
            dataGridViewRequests.Columns["Department"].HeaderText = "Подразделение";
            dataGridViewRequests.Columns["Contact"].HeaderText = "Контакты";
            dataGridViewRequests.Columns["DateCreated"].HeaderText = "Дата и время";
            dataGridViewRequests.Columns["ProblemType"].HeaderText = "Тип неисправности";
            dataGridViewRequests.Columns["Description"].HeaderText = "Описание";
            dataGridViewRequests.Columns["Priority"].HeaderText = "Приоритет";
            dataGridViewRequests.Columns["Specialist"].HeaderText = "Специалист";
            dataGridViewRequests.Columns["Status"].HeaderText = "Статус";

            dataGridViewRequests.Columns["Id"].FillWeight = 20;
            dataGridViewRequests.Columns["FullName"].FillWeight = 45;
            dataGridViewRequests.Columns["Department"].FillWeight = 45;
            dataGridViewRequests.Columns["Contact"].FillWeight = 35;
            dataGridViewRequests.Columns["DateCreated"].FillWeight = 40;
            dataGridViewRequests.Columns["ProblemType"].FillWeight = 55;
            dataGridViewRequests.Columns["Description"].FillWeight = 85;
            dataGridViewRequests.Columns["Priority"].FillWeight = 28;
            dataGridViewRequests.Columns["Specialist"].FillWeight = 40;
            dataGridViewRequests.Columns["Status"].FillWeight = 28;

            UpdateCards(table);
        }

        private void UpdateCards(DataTable table)
        {
            int newCount = 0;
            int inWorkCount = 0;
            int doneCount = 0;

            foreach (DataRow row in table.Rows)
            {
                string status = row["Status"]?.ToString();
                if (status == "Новая") newCount++;
                else if (status == "В работе") inWorkCount++;
                else if (status == "Выполнена") doneCount++;
            }

            lblStatNew.Text = $"Новые: {newCount}";
            lblStatInWork.Text = $"В работе: {inWorkCount}";
            lblStatDone.Text = $"Выполнено: {doneCount}";
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
                "SELECT * FROM Requests WHERE FullName LIKE @text OR Department LIKE @text OR ProblemType LIKE @text ORDER BY Id DESC",
                connectionString))
            {
                adapter.SelectCommand.Parameters.AddWithValue("@text", "%" + searchText + "%");
                DataTable table = new DataTable();
                adapter.Fill(table);
                BindTable(table);
            }
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (currentRole != "Специалист IT")
            {
                MessageBox.Show("Недостаточно прав для изменения статуса заявки");
                return;
            }

            if (dataGridViewRequests.CurrentRow == null)
            {
                MessageBox.Show("Выберите заявку для изменения статуса");
                return;
            }

            if (string.IsNullOrWhiteSpace(comboStatus.Text))
            {
                MessageBox.Show("Выберите новый статус");
                return;
            }

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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            Hide();
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

                DateTime fromDate = dateFrom.Value.Date;
                DateTime toDate = dateTo.Value.Date.AddDays(1).AddSeconds(-1);

                string sql = @"
SELECT
    COUNT(*) AS Total,
    SUM(CASE WHEN Status = 'Новая' THEN 1 ELSE 0 END) AS NewCount,
    SUM(CASE WHEN Status = 'В работе' THEN 1 ELSE 0 END) AS WorkCount,
    SUM(CASE WHEN Status = 'Выполнена' THEN 1 ELSE 0 END) AS DoneCount
FROM Requests
WHERE DateCreated >= @FromDate AND DateCreated <= @ToDate";

                SQLiteCommand cmd = new SQLiteCommand(sql, connection);
                cmd.Parameters.AddWithValue("@FromDate", fromDate.ToString("yyyy-MM-dd HH:mm:ss"));
                cmd.Parameters.AddWithValue("@ToDate", toDate.ToString("yyyy-MM-dd HH:mm:ss"));
                SQLiteDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string report =
                        $"Период: {fromDate:dd.MM.yyyy} - {toDate:dd.MM.yyyy}\n\n" +
                        $"Всего заявок: {reader["Total"]}\n" +
                        $"Новые: {reader["NewCount"]}\n" +
                        $"В работе: {reader["WorkCount"]}\n" +
                        $"Выполненные: {reader["DoneCount"]}";

                    MessageBox.Show(report, "Отчёт по заявкам");
                }
            }
        }

        // intentionally empty handlers kept for designer compatibility
        private void btnEdit_Click(object sender, EventArgs e) { }
        private void btnDetails_Click(object sender, EventArgs e) { }
        private void btnSearch_Click(object sender, EventArgs e) { }
        private void MainForm_Load(object sender, EventArgs e) { }
        private void comboStatus_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}
