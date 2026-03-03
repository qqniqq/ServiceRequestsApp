using System;
using System.Data.SQLite;

namespace ServiceRequestsLib
{
    public static class AuthService
    {
        public static bool IsLoginLengthValid(string login)
        {
            if (login == null) return false;
            return login.Length >= 3 && login.Length <= 20;
        }

        public static bool IsPasswordLengthValid(string password)
        {
            if (password == null) return false;
            return password.Length >= 5 && password.Length <= 20;
        }

        public static bool Authenticate(string connectionString, string login, string password)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                const string sql = "SELECT COUNT(1) FROM Users WHERE Login=@login AND Password=@password";
                using (var cmd = new SQLiteCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@password", password);
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
        }
    }

    public static class RequestValidationService
    {
        public static bool ValidateRequiredFields(
            string fullName,
            string department,
            string contact,
            string problemType,
            string specialist,
            string description,
            string priority)
        {
            return !string.IsNullOrWhiteSpace(fullName)
                   && !string.IsNullOrWhiteSpace(department)
                   && !string.IsNullOrWhiteSpace(contact)
                   && !string.IsNullOrWhiteSpace(problemType)
                   && !string.IsNullOrWhiteSpace(specialist)
                   && !string.IsNullOrWhiteSpace(description)
                   && !string.IsNullOrWhiteSpace(priority)
                   && fullName.Trim().Length >= 5
                   && fullName.Trim().Length <= 100
                   && description.Trim().Length >= 10
                   && description.Trim().Length <= 500;
        }
    }

    public static class RoleAccessService
    {
        public static bool CanUseAdminFunctions(string role)
        {
            return string.Equals(role, "Специалист IT", StringComparison.Ordinal);
        }
    }
}
