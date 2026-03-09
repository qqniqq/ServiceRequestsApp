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

            label1.Visible = false;
            label2.Visible = false;

            SetupPlaceholder(txtLogin, "Логин");
            SetupPlaceholder(txtPassword, "Пароль", true);
        }

        private void SetupPlaceholder(TextBox textBox, string placeholder, bool isPassword = false)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = System.Drawing.Color.Gray;
            textBox.UseSystemPasswordChar = false;

            textBox.Enter += (s, e) =>
            {
                if (textBox.ForeColor == System.Drawing.Color.Gray && textBox.Text == placeholder)
                {
                    textBox.Text = string.Empty;
                    textBox.ForeColor = System.Drawing.Color.Black;
                    if (isPassword)
                    {
                        textBox.UseSystemPasswordChar = true;
                    }
                }
            };

            textBox.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.UseSystemPasswordChar = false;
                    textBox.Text = placeholder;
                    textBox.ForeColor = System.Drawing.Color.Gray;
                }
            };
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = txtLogin.ForeColor == System.Drawing.Color.Gray ? string.Empty : txtLogin.Text.Trim();
            string password = txtPassword.ForeColor == System.Drawing.Color.Gray ? string.Empty : txtPassword.Text;

            if (login.Length < 3 || login.Length > 20)
            {
                MessageBox.Show("Логин должен быть от 3 до 20 символов");
                return;
            }
            if (password.Length < 5 || password.Length > 20)
            {
                MessageBox.Show("Пароль должен быть от 5 до 20 символов");
                return;
            }
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT FullName, Role, Password FROM Users WHERE Login=@login";
                SQLiteCommand cmd = new SQLiteCommand(sql, connection);
                cmd.Parameters.AddWithValue("@login", login);
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string storedPassword = reader["Password"].ToString();
                    string inputHash = ComputeSha256(password);
                    bool isPasswordValid = storedPassword == inputHash || storedPassword == password;

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
