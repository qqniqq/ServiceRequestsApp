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

        private readonly string currentUser;
        private readonly string currentRole;

        public MainForm(string fullName, string role)
        {
            InitializeComponent();

            currentUser = fullName;
            currentRole = role;
            lblUser.Text = $"{currentUser} ({currentRole})";

            // В боковом меню оставляем только реально работающий раздел, чтобы не путать пользователя.
            labelMenuDashboard.Visible = false;
            labelMenuEquipment.Visible = false;
            labelMenuDepartments.Visible = false;
            labelMenuReports.Visible = false;
            labelMenuUsers.Visible = false;

            dateFrom.Value = DateTime.Today.AddDays(-7);
            dateTo.Value = DateTime.Today;

            ApplyRolePermissions();
            ConfigureTable();
            LoadRequests();
        }

        private void ApplyRolePermissions()
        {
            bool isItSpecialist = currentRole == "Специалист IT";

            comboStatus.Visible = isItSpecialist;
            btnUpdateStatus.Visible = isItSpecialist;
            btnReport.Visible = isItSpecialist;
            btnEdit.Visible = isItSpecialist;
            btnDelete.Visible = isItSpecialist;

            // Детали полезны всем ролям.
            btnDetails.Visible = true;
        }

        private void ConfigureTable()
        {
            dataGridViewRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRequests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewRequests.MultiSelect = false;
            dataGridViewRequests.RowHeadersVisible = false;
            dataGridViewRequests.ReadOnly = true;
            dataGridViewRequests.AllowUserToAddRows = false;
            dataGridViewRequests.AllowUserToDeleteRows = false;
            dataGridViewRequests.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridViewRequests.RowTemplate.Height = 30;
            dataGridViewRequests.DefaultCellStyle.WrapMode = DataGridViewTriState.False;

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
            dataGridViewRequests.Columns["DateCreated"].HeaderText = "Дата и время";
            dataGridViewRequests.Columns["Priority"].HeaderText = "Приоритет";
            dataGridViewRequests.Columns["Status"].HeaderText = "Статус";

            // В таблице оставляем только основные поля, полные данные доступны по кнопке "Детали".
            dataGridViewRequests.Columns["Contact"].Visible = false;
            dataGridViewRequests.Columns["ProblemType"].Visible = false;
            dataGridViewRequests.Columns["Description"].Visible = false;
            dataGridViewRequests.Columns["Specialist"].Visible = false;

            dataGridViewRequests.Columns["Id"].FillWeight = 8;
            dataGridViewRequests.Columns["FullName"].FillWeight = 24;
            dataGridViewRequests.Columns["Department"].FillWeight = 20;
            dataGridViewRequests.Columns["DateCreated"].FillWeight = 20;
            dataGridViewRequests.Columns["Priority"].FillWeight = 12;
            dataGridViewRequests.Columns["Status"].FillWeight = 16;

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
            using (AddRequestForm form = new AddRequestForm())
            {
                form.ShowDialog();
            }

            // После закрытия формы перечитываем данные из БД.
            LoadRequests();
        }

        private void SearchRequests(string searchText)
        {
            using (var adapter = new SQLiteDataAdapter(
                "SELECT * FROM Requests WHERE FullName LIKE @text OR Department LIKE @text OR ProblemType LIKE @text OR Description LIKE @text ORDER BY Id DESC",
                connectionString))
            {
                adapter.SelectCommand.Parameters.AddWithValue("@text", "%" + searchText + "%");
                DataTable table = new DataTable();
                adapter.Fill(table);
                BindTable(table);
            }
        }

        private int? GetSelectedRequestId()
        {
            if (dataGridViewRequests.CurrentRow == null)
                return null;

            object idValue = dataGridViewRequests.CurrentRow.Cells["Id"].Value;
            if (idValue == null)
                return null;

            return Convert.ToInt32(idValue);
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (currentRole != "Специалист IT")
            {
                MessageBox.Show("Недостаточно прав для изменения статуса заявки");
                return;
            }

            int? selectedId = GetSelectedRequestId();
            if (!selectedId.HasValue)
            {
                MessageBox.Show("Выберите заявку для изменения статуса");
                return;
            }

            if (string.IsNullOrWhiteSpace(comboStatus.Text))
            {
                MessageBox.Show("Выберите новый статус");
                return;
            }

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string sql = "UPDATE Requests SET Status = @Status WHERE Id = @Id";
                SQLiteCommand cmd = new SQLiteCommand(sql, connection);
                cmd.Parameters.AddWithValue("@Status", comboStatus.Text);
                cmd.Parameters.AddWithValue("@Id", selectedId.Value);
                cmd.ExecuteNonQuery();
            }

            LoadRequests();
            MessageBox.Show("Статус заявки изменён");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (currentRole != "Специалист IT")
            {
                MessageBox.Show("Недостаточно прав для удаления заявки");
                return;
            }

            int? selectedId = GetSelectedRequestId();
            if (!selectedId.HasValue)
            {
                MessageBox.Show("Выберите заявку для удаления");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                $"Удалить заявку №{selectedId.Value}?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
                return;

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand cmd = new SQLiteCommand("DELETE FROM Requests WHERE Id = @Id", connection);
                cmd.Parameters.AddWithValue("@Id", selectedId.Value);
                cmd.ExecuteNonQuery();
            }

            LoadRequests();
            MessageBox.Show("Заявка удалена");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (currentRole != "Специалист IT")
            {
                MessageBox.Show("Недостаточно прав для редактирования заявки");
                return;
            }

            int? selectedId = GetSelectedRequestId();
            if (!selectedId.HasValue)
            {
                MessageBox.Show("Выберите заявку для правки");
                return;
            }

            string currentDescription = dataGridViewRequests.CurrentRow.Cells["Description"].Value?.ToString() ?? string.Empty;
            string newDescription = PromptForText("Правка заявки", "Введите новое описание:", currentDescription);

            if (newDescription == null)
                return;

            if (newDescription.Trim().Length < 10)
            {
                MessageBox.Show("Описание должно содержать не менее 10 символов");
                return;
            }

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand cmd = new SQLiteCommand("UPDATE Requests SET Description = @Description WHERE Id = @Id", connection);
                cmd.Parameters.AddWithValue("@Description", newDescription.Trim());
                cmd.Parameters.AddWithValue("@Id", selectedId.Value);
                cmd.ExecuteNonQuery();
            }

            LoadRequests();
            MessageBox.Show("Описание заявки обновлено");
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (dataGridViewRequests.CurrentRow == null)
            {
                MessageBox.Show("Выберите заявку для просмотра деталей");
                return;
            }

            DataGridViewRow row = dataGridViewRequests.CurrentRow;
            string details =
                $"№: {row.Cells["Id"].Value}\n" +
                $"ФИО: {row.Cells["FullName"].Value}\n" +
                $"Подразделение: {row.Cells["Department"].Value}\n" +
                $"Контакты: {row.Cells["Contact"].Value}\n" +
                $"Дата и время: {row.Cells["DateCreated"].Value}\n" +
                $"Тип неисправности: {row.Cells["ProblemType"].Value}\n" +
                $"Описание: {row.Cells["Description"].Value}\n" +
                $"Приоритет: {row.Cells["Priority"].Value}\n" +
                $"Специалист: {row.Cells["Specialist"].Value}\n" +
                $"Статус: {row.Cells["Status"].Value}";

            MessageBox.Show(details, "Детали заявки", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string PromptForText(string title, string label, string initialValue)
        {
            using (Form prompt = new Form())
            {
                prompt.Text = title;
                prompt.Width = 620;
                prompt.Height = 220;
                prompt.StartPosition = FormStartPosition.CenterParent;
                prompt.FormBorderStyle = FormBorderStyle.FixedDialog;
                prompt.MinimizeBox = false;
                prompt.MaximizeBox = false;

                Label textLabel = new Label
                {
                    Left = 12,
                    Top = 16,
                    Width = 580,
                    Text = label
                };

                TextBox textBox = new TextBox
                {
                    Left = 12,
                    Top = 46,
                    Width = 580,
                    Height = 60,
                    Multiline = true,
                    Text = initialValue
                };

                Button confirmation = new Button
                {
                    Text = "Сохранить",
                    DialogResult = DialogResult.OK,
                    Left = 392,
                    Width = 95,
                    Top = 120
                };

                Button cancel = new Button
                {
                    Text = "Отмена",
                    DialogResult = DialogResult.Cancel,
                    Left = 497,
                    Width = 95,
                    Top = 120
                };

                prompt.Controls.Add(textLabel);
                prompt.Controls.Add(textBox);
                prompt.Controls.Add(confirmation);
                prompt.Controls.Add(cancel);

                prompt.AcceptButton = confirmation;
                prompt.CancelButton = cancel;

                return prompt.ShowDialog(this) == DialogResult.OK ? textBox.Text : null;
            }
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
        private void btnSearch_Click(object sender, EventArgs e) { }
        private void MainForm_Load(object sender, EventArgs e) { }
        private void comboStatus_SelectedIndexChanged(object sender, EventArgs e) { }

        private void comboStatus_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
