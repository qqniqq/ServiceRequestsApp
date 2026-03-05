using System;
using System.Data.SQLite;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServiceRequestsLib;
using ServiceRequestsApp;

namespace ServiceRequestsTests
{
    [TestClass]
    public class FunctionalTests
    {
        private const string DbFile = "requests.db";
        private const string ConnectionString = "Data Source=requests.db";

        [TestInitialize]
        public void Init()
        {
            if (File.Exists(DbFile))
            {
                File.Delete(DbFile);
            }

            DatabaseInitializer.Initialize();
        }

        [TestMethod]
        public void TC01_Авторизация_С_Корректными_Данными()
        {
            var ok = AuthService.Authenticate(ConnectionString, "admin", "admin123");
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void TC02_Авторизация_С_Некорректными_Данными()
        {
            var ok = AuthService.Authenticate(ConnectionString, "admin", "wrong-pass");
            Assert.IsFalse(ok);
        }

        [TestMethod]
        public void TC03_Добавление_Новой_Заявки_В_Базу()
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                const string insertSql = @"
INSERT INTO Requests
(FullName, Department, Contact, DateCreated, ProblemType, Description, Priority, Specialist, Status)
VALUES
(@FullName, @Department, @Contact, @DateCreated, @ProblemType, @Description, @Priority, @Specialist, @Status)";

                using (var cmd = new SQLiteCommand(insertSql, connection))
                {
                    cmd.Parameters.AddWithValue("@FullName", "Иванов Иван Иванович");
                    cmd.Parameters.AddWithValue("@Department", "Регистратура");
                    cmd.Parameters.AddWithValue("@Contact", "101");
                    cmd.Parameters.AddWithValue("@DateCreated", DateTime.Now.ToString("s"));
                    cmd.Parameters.AddWithValue("@ProblemType", "ПК");
                    cmd.Parameters.AddWithValue("@Description", "Компьютер не включается после отключения света");
                    cmd.Parameters.AddWithValue("@Priority", "Высокий");
                    cmd.Parameters.AddWithValue("@Specialist", "Администратор");
                    cmd.Parameters.AddWithValue("@Status", "Новая");
                    cmd.ExecuteNonQuery();
                }

                using (var countCmd = new SQLiteCommand("SELECT COUNT(*) FROM Requests", connection))
                {
                    var count = Convert.ToInt32(countCmd.ExecuteScalar());
                    Assert.AreEqual(1, count);
                }
            }
        }

        [TestMethod]
        public void TC04_Валидация_Обязательных_Полей()
        {
            var valid = RequestValidationService.ValidateRequiredFields(
                "",
                "Отделение",
                "102",
                "Принтер",
                "Администратор",
                "Коротко",
                "Средний");

            Assert.IsFalse(valid);
        }

        [TestMethod]
        public void TC05_Изменение_Статуса_Заявки()
        {
            int id;
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                using (var cmd = new SQLiteCommand(@"
INSERT INTO Requests (FullName, Department, Contact, DateCreated, ProblemType, Description, Priority, Specialist, Status)
VALUES ('Петров Петр Петрович', 'Хирургия', '103', @date, 'Сеть', 'Нет доступа к сети в кабинете', 'Средний', 'Администратор', 'Новая');
SELECT last_insert_rowid();", connection))
                {
                    cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString("s"));
                    id = Convert.ToInt32((long)cmd.ExecuteScalar());
                }

                using (var updateCmd = new SQLiteCommand("UPDATE Requests SET Status = @status WHERE Id = @id", connection))
                {
                    updateCmd.Parameters.AddWithValue("@status", "В работе");
                    updateCmd.Parameters.AddWithValue("@id", id);
                    updateCmd.ExecuteNonQuery();
                }

                using (var statusCmd = new SQLiteCommand("SELECT Status FROM Requests WHERE Id = @id", connection))
                {
                    statusCmd.Parameters.AddWithValue("@id", id);
                    var status = Convert.ToString(statusCmd.ExecuteScalar());
                    Assert.AreEqual("В работе", status);
                }
            }
        }

        [TestMethod]
        public void TC06_Разграничение_Прав_Доступа_По_Ролям()
        {
            Assert.IsFalse(RoleAccessService.CanUseAdminFunctions("Сотрудник"));
            Assert.IsTrue(RoleAccessService.CanUseAdminFunctions("Специалист IT"));
        }
    }
}
