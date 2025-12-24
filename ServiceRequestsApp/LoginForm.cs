using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace ServiceRequestsApp
{
    public partial class LoginForm : Form
    {
        private const string connectionString = "Data Source=requests.db";
        public LoginForm()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Length < 3 || txtLogin.Text.Length > 20)
            {
                MessageBox.Show("Логин должен быть от 3 до 20 символов");
                return;
            }
            if (txtPassword.Text.Length < 5 || txtPassword.Text.Length > 20)
            {
                MessageBox.Show("Пароль должен быть от 5 до 20 символов");
                return;
            }
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT FullName, Role FROM Users WHERE Login=@login AND Password=@password";
                SQLiteCommand cmd = new SQLiteCommand(sql, connection);
                cmd.Parameters.AddWithValue("@login", txtLogin.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string fullName = reader["FullName"].ToString();
                    string role = reader["Role"].ToString();

                    MainForm main = new MainForm(fullName, role);
                    main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль");
                }
            }
        }
    }
}
