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

            comboProblemType.Items.Clear();
            comboProblemType.Items.AddRange(new object[]
            {
                "ПК врача",
                "Принтер",
                "МФУ",
                "Сеть",
                "Телефония",
                "Медицинская информационная система",
                "Программное обеспечение",
                "Другое"
            });

            comboDepartment.SelectedIndex = -1;
            comboPriority.SelectedIndex = -1;
            comboProblemType.SelectedIndex = -1;
            comboSpecialist.SelectedIndex = -1;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
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
            if (comboDepartment.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите подразделение");
                comboDepartment.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtContact.Text))
            {
                MessageBox.Show("Введите контактные данные");
                txtContact.Focus();
                return;
            }
            if (comboProblemType.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите тип неисправности");
                comboProblemType.Focus();
                return;
            }
            if (comboSpecialist.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите ответственного специалиста");
                comboSpecialist.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtDescription.Text))
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
            if (comboPriority.SelectedIndex == -1)
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
    }
}
