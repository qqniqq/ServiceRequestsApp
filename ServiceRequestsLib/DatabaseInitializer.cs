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
    ('user', 'user123', 'Пользователь', 'Сотрудник')";

                    new SQLiteCommand(insertUsers, connection).ExecuteNonQuery();
                }

                string checkRequests = "SELECT COUNT(*) FROM Requests";
                long requestsCount = (long)new SQLiteCommand(checkRequests, connection).ExecuteScalar();

                if (requestsCount == 0)
                {
                    string insertRequests = @"
    INSERT INTO Requests (FullName, Department, Contact, DateCreated, ProblemType, Description, Priority, Specialist, Status)
    VALUES
    ('Иванов И.И.', 'Кардиология', '101-55-12', '2026-03-06 08:10:00', 'ПК врача', 'Не загружается рабочая станция в кабинете 312', 'Высокий', 'Петров А.А.', 'В работе'),
    ('Смирнова Н.П.', 'Лаборатория', '102-11-42', '2026-03-06 09:25:00', 'Принтер', 'Замятие бумаги на HP LaserJet', 'Средний', 'Петров А.А.', 'Новая'),
    ('Кузнецов Д.В.', 'Реанимация', '103-80-09', '2026-03-06 10:45:00', 'Сеть', 'Нет доступа к медицинской информационной системе', 'Высокий', 'Сидоров И.В.', 'Выполнена'),
    ('Орлова Е.С.', 'Терапия', '104-33-17', '2026-03-06 11:20:00', 'ПК врача', 'После обновления медленно работает рабочее место', 'Низкий', 'Петров А.А.', 'В работе'),
    ('Федоров М.А.', 'Хирургия', '105-72-61', '2026-03-06 12:05:00', 'МФУ', 'Сканер не определяется системой', 'Средний', 'Сидоров И.В.', 'Новая'),
    ('Васильева О.Г.', 'Регистратура', '106-44-98', '2026-03-06 12:40:00', 'Телефония', 'Не работает внутренний номер на посту', 'Высокий', 'Петров А.А.', 'Выполнена')";

                    new SQLiteCommand(insertRequests, connection).ExecuteNonQuery();
                }

            }
        }
    }
}
