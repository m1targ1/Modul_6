using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient; // Подключение имен для работы с SQL Server

namespace Modul_6
{
    public partial class AllClients : Form
    {
        DataBase database = new DataBase(); // Создание объекта базы данных

        public AllClients()
        {
            InitializeComponent();
        }

        private void AllClients_Load(object sender, EventArgs e)
        {
            CreateColumns(); // Создание колонок
            RefreshDataGrid(dataGridView_Clients); // Заполнение таблицы данными
        }

        private void CreateColumns() // Метод создания колонок
        {
            dataGridView_Clients.Columns.Add("ФИО", "ФИО"); // Колонка для ФИО
            dataGridView_Clients.Columns.Add("Адрес", "Адрес"); // Колонка для Адреса
            dataGridView_Clients.Columns.Add("Дата_рождения", "Дата рождения"); // Колонка для даты рождения
            dataGridView_Clients.Columns.Add("Номер_телефона", "Номер телефона"); // Колонка для номера телефона
        }

        private void ReadRow(DataGridView dataGridView_Clients, IDataRecord record) // Метод для добавления строки в DataGridView
        {
            string fio = record.GetString(0); // Чтение ФИО
            string address = record.GetString(1); // Чтение адреса
            string birthDate = record.GetString(2); // Чтение даты рождения
            string phone = record.GetString(3); // Чтение номера телефона
            dataGridView_Clients.Rows.Add(fio, address, birthDate, phone); // Добавление данных в DataGridView
        }

        public void RefreshDataGrid(DataGridView dataGridView_Clients) // Метод для обновления таблицы
        {
            dataGridView_Clients.Rows.Clear(); // Очистка старых данных
            string queryString = "SELECT ФИО, Адрес, Дата_рождения, Номер_телефона FROM Клиенты"; // SQL-запрос
            SqlCommand command = new SqlCommand(queryString, database.GetConnection()); // Команда SQL
            database.open(); // Открытие соединения
            try
            {
                SqlDataReader reader = command.ExecuteReader(); // Выполнение запроса и чтение данных
                while (reader.Read()) // Пока есть данные
                {
                    ReadRow(dataGridView_Clients, reader); // Добавление строки в DataGridView
                }
                reader.Close(); // Закрытие ридера
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}"); // Обработка ошибок
            }
            finally
            {
                database.closed(); // Закрытие соединения с БД
            }
        }
    }
}
