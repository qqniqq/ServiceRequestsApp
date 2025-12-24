using System.Data.SQLite;

namespace ServiceRequestsApp
{
    public static class DatabaseInitializer
    {
        private const string connectionString = "Data Source=requests.db";

        public static void Initialize()
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (var pragmaCmd = new SQLiteCommand("PRAGMA journal_mode=WAL;", connection))
                {
                    pragmaCmd.ExecuteNonQuery();
                }

                using (var pragmaCmd = new SQLiteCommand("PRAGMA synchronous=NORMAL;", connection))
                {
                    pragmaCmd.ExecuteNonQuery();
                }


                string createRequests = @"
                CREATE TABLE IF NOT EXISTS Requests (
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
                new SQLiteCommand(createRequests, connection).ExecuteNonQuery();

                string createUsers = @"
                CREATE TABLE IF NOT EXISTS Users (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Login TEXT NOT NULL UNIQUE,
                    Password TEXT NOT NULL,
                    FullName TEXT NOT NULL,
                    Role TEXT NOT NULL
                )";
                new SQLiteCommand(createUsers, connection).ExecuteNonQuery();

                string checkUsers = "SELECT COUNT(*) FROM Users";
                long count = (long)new SQLiteCommand(checkUsers, connection).ExecuteScalar();

                if (count == 0)
                {
                    string insertUsers = @"
    INSERT INTO Users (Login, Password, FullName, Role)
    VALUES
    ('admin', 'admin123', 'Администратор', 'Специалист IT'),
    ('user', 'user123', 'Обычный сотрудник', 'Сотрудник')";

                    new SQLiteCommand(insertUsers, connection).ExecuteNonQuery();
                }

            }
        }
    }
}
