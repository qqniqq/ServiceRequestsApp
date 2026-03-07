using System;
using System.Data.SQLite;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ServiceRequestsApp
{
    public partial class LoginForm : Form
    {
        private const string connectionString = "Data Source=requests.db";
        public LoginForm()
        {
            InitializeComponent();
            this.AcceptButton = btnLogin;
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
                string sql = "SELECT FullName, Role, Password FROM Users WHERE Login=@login";
                SQLiteCommand cmd = new SQLiteCommand(sql, connection);
                cmd.Parameters.AddWithValue("@login", txtLogin.Text);
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string storedPassword = reader["Password"].ToString();
                    string inputHash = ComputeSha256(txtPassword.Text);
                    bool isPasswordValid = storedPassword == inputHash || storedPassword == txtPassword.Text;

                    if (isPasswordValid)
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
                else
                {
                    MessageBox.Show("Неверный логин или пароль");
                }
            }
        }
        private static string ComputeSha256(string value)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(value));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in bytes)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
