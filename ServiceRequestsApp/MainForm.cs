using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
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
            ConfigureTableAppearance();
            dateFrom.Value = DateTime.Today.AddDays(-7);
            dateTo.Value = DateTime.Today;
            dataGridViewRequests.CellDoubleClick += dataGridViewRequests_CellDoubleClick;
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
            }
        }

        private void ConfigureTableAppearance()
        {
            dataGridViewRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRequests.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewRequests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewRequests.MultiSelect = false;
            dataGridViewRequests.RowHeadersVisible = false;
            dataGridViewRequests.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridViewRequests.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewRequests.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            dataGridViewRequests.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(245, 247, 252);
            dataGridViewRequests.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(83, 94, 111);
            dataGridViewRequests.DefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 235, 255);
            dataGridViewRequests.DefaultCellStyle.SelectionForeColor = Color.FromArgb(33, 42, 55);
            dataGridViewRequests.EnableHeadersVisualStyles = false;
            dataGridViewRequests.CellFormatting -= DataGridViewRequests_CellFormatting;
            dataGridViewRequests.CellFormatting += DataGridViewRequests_CellFormatting;
        }

        private void DataGridViewRequests_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewRequests.Columns[e.ColumnIndex].Name != "Status" || e.Value == null)
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

                BindRequestsTable(table);
            }
        }



        private void BindRequestsTable(DataTable table)
        {
            foreach (DataRow row in table.Rows)
            {
                var raw = row["DateCreated"]?.ToString();
                if (DateTime.TryParseExact(raw, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsed))
                {
                    row["DateCreated"] = parsed.ToString("HH:mm");
                }
            }

            dataGridViewRequests.DataSource = table;
            dataGridViewRequests.ReadOnly = true;
            dataGridViewRequests.AllowUserToAddRows = false;

            dataGridViewRequests.Columns["Id"].HeaderText = "№";
            dataGridViewRequests.Columns["Department"].HeaderText = "Отделение";
            dataGridViewRequests.Columns["ProblemType"].HeaderText = "Оборудование";
            dataGridViewRequests.Columns["Status"].HeaderText = "Статус";
            dataGridViewRequests.Columns["DateCreated"].HeaderText = "Время";

            dataGridViewRequests.Columns["FullName"].Visible = false;
            dataGridViewRequests.Columns["Contact"].Visible = false;
            dataGridViewRequests.Columns["Description"].Visible = false;
            dataGridViewRequests.Columns["Priority"].Visible = false;
            dataGridViewRequests.Columns["Specialist"].Visible = false;

            dataGridViewRequests.Columns["Id"].FillWeight = 20;
            dataGridViewRequests.Columns["Department"].FillWeight = 40;
            dataGridViewRequests.Columns["ProblemType"].FillWeight = 45;
            dataGridViewRequests.Columns["Status"].FillWeight = 30;
            dataGridViewRequests.Columns["DateCreated"].FillWeight = 25;

            UpdateStatCards(table);
        }

        private void UpdateStatCards(DataTable table)
        {
            int newCount = 0;
            int inWorkCount = 0;
            int doneCount = 0;

            foreach (DataRow row in table.Rows)
            {
                string status = row["Status"]?.ToString();
                if (status == "Новая")
                    newCount++;
                else if (status == "В работе")
                    inWorkCount++;
                else if (status == "Выполнена")
                    doneCount++;
            }

            lblStatNew.Text = $"Новые: {newCount}";
            lblStatInWork.Text = $"В работе: {inWorkCount}";
            lblStatDone.Text = $"Выполнено: {doneCount}";
        }


        private void dataGridViewRequests_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ShowRequestDetails();
            }
        }

        private void ShowRequestDetails()
        {
            if (dataGridViewRequests.CurrentRow == null)
            {
                MessageBox.Show("Сначала выберите заявку");
                return;
            }

            var row = dataGridViewRequests.CurrentRow;
            string details =
                $"№: {row.Cells["Id"].Value}\n" +
                $"ФИО: {row.Cells["FullName"].Value}\n" +
                $"Подразделение: {row.Cells["Department"].Value}\n" +
                $"Контакт: {row.Cells["Contact"].Value}\n" +
                $"Дата: {row.Cells["DateCreated"].Value}\n" +
                $"Тип: {row.Cells["ProblemType"].Value}\n" +
                $"Описание: {row.Cells["Description"].Value}\n" +
                $"Приоритет: {row.Cells["Priority"].Value}\n" +
                $"Специалист: {row.Cells["Specialist"].Value}\n" +
                $"Статус: {row.Cells["Status"].Value}";

            MessageBox.Show(details, "Детали заявки", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            ShowRequestDetails();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (currentRole != "Специалист IT")
            {
                MessageBox.Show("Недостаточно прав для редактирования заявки");
                return;
            }

            if (dataGridViewRequests.CurrentRow == null)
            {
                MessageBox.Show("Выберите заявку для редактирования");
                return;
            }

            int id = Convert.ToInt32(dataGridViewRequests.CurrentRow.Cells["Id"].Value);
            string currentDescription = dataGridViewRequests.CurrentRow.Cells["Description"].Value?.ToString() ?? "";

            string newDescription = PromptForDescription(currentDescription);

            if (string.IsNullOrWhiteSpace(newDescription))
            {
                return;
            }

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string sql = "UPDATE Requests SET Description = @Description WHERE Id = @Id";
                SQLiteCommand cmd = new SQLiteCommand(sql, connection);
                cmd.Parameters.AddWithValue("@Description", newDescription.Trim());
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }

            LoadRequests();
            MessageBox.Show("Описание заявки обновлено");
        }


        private string PromptForDescription(string currentDescription)
        {
            Form prompt = new Form
            {
                Width = 560,
                Height = 230,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "Редактирование заявки",
                StartPosition = FormStartPosition.CenterParent,
                MaximizeBox = false,
                MinimizeBox = false
            };

            Label textLabel = new Label { Left = 15, Top = 15, Width = 510, Text = "Измените описание заявки:" };
            TextBox inputBox = new TextBox { Left = 15, Top = 45, Width = 510, Height = 60, Multiline = true, Text = currentDescription };
            Button confirmation = new Button { Text = "Сохранить", Left = 335, Width = 90, Top = 120, DialogResult = DialogResult.OK };
            Button cancel = new Button { Text = "Отмена", Left = 435, Width = 90, Top = 120, DialogResult = DialogResult.Cancel };

            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(inputBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(cancel);
            prompt.AcceptButton = confirmation;
            prompt.CancelButton = cancel;

            return prompt.ShowDialog() == DialogResult.OK ? inputBox.Text : string.Empty;
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
                BindRequestsTable(table);
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
        private void btnSearch_Click(object sender, EventArgs e)
        {
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
        }
        private void comboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
