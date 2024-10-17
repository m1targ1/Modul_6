using System;
using System.Windows.Forms;
using System.Data.SqlClient; // Подключение имен для работы с SQL Server

namespace Modul_6
{
    public partial class Add_Delete_Book : Form
    {
        DataBase database = new DataBase(); // Создание объекта базы данных
        private DataGridView _dataGridView; // Поле для хранения ссылки на компонент DataGridView
        private Library _libraryForm; // Поле для хранения ссылки на форму библиотеки

        public Add_Delete_Book(Library libraryForm, DataGridView dataGridView1) // Конструктор класса, принимает форму библиотеки и DataGridView в качестве параметров
        {
            InitializeComponent();
            _dataGridView = dataGridView1; // Ссылка на DataGridView
            _libraryForm = libraryForm; // Ссылка на форму Library
        }

        private void button_AddBook_Click(object sender, EventArgs e)
        {
            // Получение значений из текстовых полей
            string author = textBox_Author.Text; // Автора
            string title = textBox_NameB.Text; // Название
            int year = int.Parse(textBox_Year.Text); // Год (преобразование в int)
            int quantity = int.Parse(textBox_Count.Text); // ЧКолиество книг (преобразование в int)

            database.open(); // Открытие соединения с БД

            // SQL-запрос для проверки существования книги с таким же автором и названием
            string checkQuery = "SELECT COUNT(*) FROM Книги WHERE Автор = @Author AND Название = @Title";
            SqlCommand checkCmd = new SqlCommand(checkQuery, database.GetConnection()); // Команду для выполнения запроса
            checkCmd.Parameters.AddWithValue("@Author", author); // Добавление параметра для автора
            checkCmd.Parameters.AddWithValue("@Title", title); // Добавление параметра для названия

            int count = (int)checkCmd.ExecuteScalar(); // Выполнение запроса и получение количество найденных записей

            // Если книга существует, обновляем количество
            if (count > 0)
            {
                // SQL-запрос для увеличения количества книг
                string updateQuery = "UPDATE Книги SET Количество = Количество + @Quantity WHERE Автор = @Author AND Название = @Title";
                SqlCommand updateCmd = new SqlCommand(updateQuery, database.GetConnection()); // Команда для обновления
                updateCmd.Parameters.AddWithValue("@Quantity", quantity); // Параметр для количества
                updateCmd.Parameters.AddWithValue("@Author", author); // Параметр для автора
                updateCmd.Parameters.AddWithValue("@Title", title); // Параметр для названия
                updateCmd.ExecuteNonQuery(); // Выполнение команды обновления
            }
            else // Если книга не существует, добавляем новую
            {
                // SQL-запрос для вставки новой книги
                string insertQuery = "INSERT INTO Книги (Автор, Название, Год_издания, Количество) VALUES (@Author, @Title, @Year, @Quantity)";
                SqlCommand insertCmd = new SqlCommand(insertQuery, database.GetConnection()); // Команду для вставки
                insertCmd.Parameters.AddWithValue("@Author", author); // араметр для автора
                insertCmd.Parameters.AddWithValue("@Title", title); // Параметр для названия
                insertCmd.Parameters.AddWithValue("@Year", year); // Параметр для года
                insertCmd.Parameters.AddWithValue("@Quantity", quantity); // Параметр для количества
                insertCmd.ExecuteNonQuery(); // Выполнение команды вставки
            }
            database.closed(); // Закрытие соединение с БД                       
            _libraryForm.RefreshDataGrid(_dataGridView); // Обновление данных в DataGridView на форме Library
        }

        private void button_DelBook_Click(object sender, EventArgs e)
        {
            // Получениеданных из тестовых полей
            string author = textBox_Author.Text; // Автора 
            string title = textBox_NameB.Text; // Название

            database.open(); // Открытие соединения с БД
            // SQL-запрос для удаления книги по автору и названию
            string deleteQuery = "DELETE FROM Книги WHERE Автор = @Author AND Название = @Title";
            SqlCommand deleteCmd = new SqlCommand(deleteQuery, database.GetConnection()); // Создание команды для удаления
            deleteCmd.Parameters.AddWithValue("@Author", author); // Параметр для автора
            deleteCmd.Parameters.AddWithValue("@Title", title); // Параметр для названия
            deleteCmd.ExecuteNonQuery(); // Выполнение команды удаления
            database.closed(); // Закрытие соединения с БЛ       
            _libraryForm.RefreshDataGrid(_dataGridView); // Обновление данных в DataGridView на форме Library
        }
    }
}
