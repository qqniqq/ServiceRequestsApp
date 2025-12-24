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
            comboPriority.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
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
                cmd.Parameters.AddWithValue("@DateCreated", DateTime.Now.ToString());
                cmd.Parameters.AddWithValue("@ProblemType", txtProblemType.Text);
                cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
                cmd.Parameters.AddWithValue("@Priority", comboPriority.Text);
                cmd.Parameters.AddWithValue("@Specialist", txtSpecialist.Text);
                cmd.Parameters.AddWithValue("@Status", "Новая");

                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Заявка успешно добавлена");
            Close();

            if (txtFullName.Text.Length < 5 || txtFullName.Text.Length > 100)
            {
                MessageBox.Show("ФИО должно быть от 5 до 100 символов");
                return;
            }

            if (txtDescription.Text.Length < 10 || txtDescription.Text.Length > 500)
            {
                MessageBox.Show("Описание должно быть от 10 до 500 символов");
                return;
            }
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
