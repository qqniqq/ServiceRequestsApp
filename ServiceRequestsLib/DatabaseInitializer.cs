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

                string createLoginAudit = @"
                CREATE TABLE IF NOT EXISTS LoginAudit (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Login TEXT,
                    AttemptDate TEXT,
                    IsSuccess INTEGER,
                    Details TEXT
                )";
                new SQLiteCommand(createLoginAudit, connection).ExecuteNonQuery();

                string checkUsers = "SELECT COUNT(*) FROM Users";
                long count = (long)new SQLiteCommand(checkUsers, connection).ExecuteScalar();

                if (count == 0)
                {
                    string insertUsers = @"
    INSERT INTO Users (Login, Password, FullName, Role)
    VALUES
    ('admin', '240be518fabd2724ddb6f04eeb1da5967448d7e831c08c8fa822809f74c720a9', 'Администратор', 'Специалист IT'),
    ('user', 'e606e38b0d8c19b24cf0ee3808183162ea7cd63ff7912dbb22b5e803286b4446', 'Пользователь', 'Сотрудник')";

                    new SQLiteCommand(insertUsers, connection).ExecuteNonQuery();
                }


                string migratePlainPasswords = @"
    UPDATE Users
    SET Password = CASE
        WHEN Login = 'admin' AND Password = 'admin123' THEN '240be518fabd2724ddb6f04eeb1da5967448d7e831c08c8fa822809f74c720a9'
        WHEN Login = 'user' AND Password = 'user123' THEN 'e606e38b0d8c19b24cf0ee3808183162ea7cd63ff7912dbb22b5e803286b4446'
        ELSE Password
    END";
                new SQLiteCommand(migratePlainPasswords, connection).ExecuteNonQuery();


                string checkRequests = "SELECT COUNT(*) FROM Requests";
                long requestsCount = (long)new SQLiteCommand(checkRequests, connection).ExecuteScalar();

                if (requestsCount == 0)
                {
                    string insertRequests = @"
    INSERT INTO Requests (FullName, Department, Contact, DateCreated, ProblemType, Description, Priority, Specialist, Status)
    VALUES
    ('Иванова Мария Сергеевна', 'администрация', 'вн. 101', '2025-01-12 08:14:00', 'Программное обеспечение', 'Не запускается клиент электронной подписи для отчётов.', 'Средний', 'Каменский К.К.', 'В работе'),
    ('Петров Алексей Викторович', 'приёмное отделение', 'вн. 203', '2025-01-12 10:36:00', 'Рабочее место (ПК/монитор)', 'Монитор периодически гаснет во время оформления пациентов.', 'Высокий', 'Сидоров И.В.', 'Новая'),
    ('Сидорова Елена Павловна', 'хирургическое отделение', 'вн. 318', '2025-01-13 07:55:00', 'Сеть/интернет', 'Нет доступа к сетевой папке с протоколами операций.', 'Высокий', 'Петров А.А.', 'В работе'),
    ('Морозов Дмитрий Андреевич', 'терапевтическое отделение', 'вн. 411', '2025-01-13 12:21:00', 'Медицинская информационная система', 'Ошибка при сохранении осмотра в карте пациента.', 'Высокий', 'Сидоров И.В.', 'Новая'),
    ('Козлова Ирина Николаевна', 'поликлиника', 'вн. 509', '2025-01-14 09:08:00', 'Принтер/МФУ', 'МФУ захватывает несколько листов при печати талонов.', 'Средний', 'Каменский К.К.', 'В работе'),
    ('Фролов Сергей Михайлович', 'бухгалтерия', 'вн. 602', '2025-01-14 14:47:00', '1С/бухгалтерское ПО', 'Не проводится документ начисления зарплаты за январь.', 'Высокий', 'Петров А.А.', 'Новая'),
    ('Романова Анна Игоревна', 'отдел кадров', 'вн. 704', '2025-01-15 09:32:00', 'Доступ/учётная запись', 'Заблокирована учётная запись после смены пароля.', 'Средний', 'Сидоров И.В.', 'Закрыта'),
    ('Егоров Николай Валерьевич', 'IT-отдел', 'it@hospital.local', '2025-01-15 16:05:00', 'Телефония', 'Не работает переадресация на дежурный номер.', 'Низкий', 'Каменский К.К.', 'Новая'),
    ('Васильева Татьяна Олеговна', 'администрация', 'вн. 108', '2025-01-16 08:58:00', 'Доступ/учётная запись', 'Нужно предоставить доступ к папке приказов.', 'Низкий', 'Петров А.А.', 'В работе'),
    ('Громов Артём Константинович', 'приёмное отделение', 'вн. 214', '2025-01-16 11:43:00', 'Сеть/интернет', 'Периодически пропадает интернет на регистратуре №2.', 'Высокий', 'Сидоров И.В.', 'Новая'),
    ('Лебедева Оксана Викторовна', 'хирургическое отделение', 'вн. 326', '2025-01-17 07:41:00', 'Рабочее место (ПК/монитор)', 'Системный блок не включается после ночного дежурства.', 'Высокий', 'Каменский К.К.', 'В работе'),
    ('Данилов Максим Юрьевич', 'терапевтическое отделение', 'вн. 433', '2025-01-17 13:19:00', 'Программное обеспечение', 'После обновления не открывается браузер для ОМС-портала.', 'Средний', 'Петров А.А.', 'Новая'),
    ('Шевцова Наталья Борисовна', 'поликлиника', 'вн. 517', '2025-01-18 10:02:00', 'Телефония', 'На телефоне в кабинете 14 отсутствует гудок.', 'Средний', 'Сидоров И.В.', 'Закрыта'),
    ('Кузьмин Павел Олегович', 'бухгалтерия', 'вн. 615', '2025-01-18 15:26:00', 'Принтер/МФУ', 'Принтер печатает с полосами при подготовке платёжных поручений.', 'Низкий', 'Каменский К.К.', 'Новая'),
    ('Журавлёва Светлана Андреевна', 'отдел кадров', 'вн. 709', '2025-01-19 09:11:00', '1С/бухгалтерское ПО', 'Не отображается карточка сотрудника в кадровом модуле 1С.', 'Средний', 'Петров А.А.', 'В работе'),
    ('Киселёв Роман Евгеньевич', 'IT-отдел', 'it-support@hospital.local', '2025-01-19 18:03:00', 'Другое', 'Требуется замена патч-корда в серверной стойке №2.', 'Низкий', 'Сидоров И.В.', 'Новая'),
    ('Беляева Юлия Анатольевна', 'поликлиника', 'вн. 523', '2025-01-20 08:27:00', 'Медицинская информационная система', 'Не подтягиваются результаты лаборатории в амбулаторную карту.', 'Высокий', 'Каменский К.К.', 'В работе'),
    ('Орлов Степан Геннадьевич', 'приёмное отделение', 'вн. 219', '2025-01-20 17:44:00', 'Тип неисправности', 'Требуется уточнение: устройство не определяется системой после подключения.', 'Низкий', 'Петров А.А.', 'Новая');";

                    new SQLiteCommand(insertRequests, connection).ExecuteNonQuery();
                }

            }
        }
    }
}
