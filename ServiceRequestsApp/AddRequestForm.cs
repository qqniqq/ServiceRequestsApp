using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace ServiceRequestsApp
{
    public partial class AddRequestForm : Form
    {
        private const string connectionString = "Data Source=requests.db";
        public AddRequestForm()
        {
            InitializeComponent();

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;

            SetupPlaceholderTextBox(txtFullName, "ФИО сотрудника");
            SetupPlaceholderTextBox(txtContact, "Контактные данные");
            SetupPlaceholderTextBox(txtDescription, "Описание проблемы");

            comboProblemType.Items.Clear();
            comboProblemType.Items.AddRange(new object[]
            {
                "Тип неисправности",
                "ПК врача",
                "Принтер",
                "МФУ",
                "Сеть",
                "Телефония",
                "Медицинская информационная система",
                "Программное обеспечение",
                "Другое"
            });

            SetupPlaceholderComboBox(comboDepartment, "Подразделение");
            SetupPlaceholderComboBox(comboPriority, "Приоритет заявки");
            SetupPlaceholderComboBox(comboProblemType, "Тип неисправности");
            SetupPlaceholderComboBox(comboSpecialist, "Ответственный специалист");
        }

        private void SetupPlaceholderTextBox(TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = System.Drawing.Color.Gray;

            textBox.Enter += (s, e) =>
            {
                if (textBox.ForeColor == System.Drawing.Color.Gray && textBox.Text == placeholder)
                {
                    textBox.Text = string.Empty;
                    textBox.ForeColor = System.Drawing.Color.Black;
                }
            };

            textBox.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = System.Drawing.Color.Gray;
                }
            };
        }

        private void SetupPlaceholderComboBox(ComboBox comboBox, string placeholder)
        {
            comboBox.Items.Remove(placeholder);
            comboBox.Items.Insert(0, placeholder);
            comboBox.SelectedIndex = 0;
        }

        private bool IsPlaceholderText(TextBox textBox)
        {
            return textBox.ForeColor == System.Drawing.Color.Gray;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsPlaceholderText(txtFullName) || string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Введите ФИО сотрудника");
                txtFullName.Focus();
                return;
            }
            if (txtFullName.Text.Trim().Length < 5 || txtFullName.Text.Trim().Length > 100)
            {
                MessageBox.Show("ФИО должно быть от 5 до 100 символов");
                txtFullName.Focus();
                return;
            }
            if (comboDepartment.SelectedIndex <= 0)
            {
                MessageBox.Show("Выберите подразделение");
                comboDepartment.Focus();
                return;
            }
            if (IsPlaceholderText(txtContact) || string.IsNullOrWhiteSpace(txtContact.Text))
            {
                MessageBox.Show("Введите контактные данные");
                txtContact.Focus();
                return;
            }
            if (comboProblemType.SelectedIndex <= 0)
            {
                MessageBox.Show("Выберите тип неисправности");
                comboProblemType.Focus();
                return;
            }
            if (comboSpecialist.SelectedIndex <= 0)
            {
                MessageBox.Show("Выберите ответственного специалиста");
                comboSpecialist.Focus();
                return;
            }
            if (IsPlaceholderText(txtDescription) || string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Введите описание проблемы");
                txtDescription.Focus();
                return;
            }
            if (txtDescription.Text.Trim().Length < 10)
            {
                MessageBox.Show("Описание проблемы должно быть не менее 10 символов");
                txtDescription.Focus();
                return;
            }
            if (comboPriority.SelectedIndex <= 0)
            {
                MessageBox.Show("Выберите приоритет заявки");
                comboPriority.Focus();
                return;
            }
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string sql =
                @"INSERT INTO Requests 
                (FullName, Department, Contact, DateCreated, ProblemType, Description, Priority, Specialist, Status)
                VALUES 
                (@FullName, @Department, @Contact, @DateCreated, @ProblemType, @Description, @Priority, @Specialist, @Status)";

                SQLiteCommand cmd = new SQLiteCommand(sql, connection);

                cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);
                cmd.Parameters.AddWithValue("@Department", comboDepartment.Text);
                cmd.Parameters.AddWithValue("@Contact", txtContact.Text);
                cmd.Parameters.AddWithValue("@DateCreated", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                cmd.Parameters.AddWithValue("@ProblemType", comboProblemType.Text);
                cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
                cmd.Parameters.AddWithValue("@Priority", comboPriority.Text);
                cmd.Parameters.AddWithValue("@Specialist", comboSpecialist.Text);
                cmd.Parameters.AddWithValue("@Status", "Новая");

                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Заявка успешно добавлена");
            Close();
        }
        private void comboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddRequestForm_Load(object sender, EventArgs e)
        {

        }

        private void comboProblemType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
