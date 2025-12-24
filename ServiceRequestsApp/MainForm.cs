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
            }
        }

        private void btnAddRequest_Click(object sender, EventArgs e)
        {
            AddRequestForm form = new AddRequestForm();
            form.ShowDialog();
            LoadRequests();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
