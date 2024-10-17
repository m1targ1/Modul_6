using System;
using System.Windows.Forms;
using System.Data.SqlClient; // Подключение имен для работы с SQL Server

namespace Modul_6
{
    public partial class всевыданныекниги : Form
    {
        DataBase database = new DataBase(); // Создание объекта базы данных
        public всевыданныекниги()
        {
            InitializeComponent();
        }

        private void всевыданныекниги_Load(object sender, System.EventArgs e)
        {
            CreateColumns();
            LoadIssuedBooks();

        }
        private void CreateColumns() // Метод создания колонок
        {
            dataGridView1.Columns.Add("ФИО", "ФИО"); // на первом месте - название в БД, на втором - отображение на форме
            dataGridView1.Columns.Add("Автор", "Автор"); dataGridView1.Columns.Add("Название", "Название");
            dataGridView1.Columns.Add("Дата_выдачи", "Дата выдачи"); dataGridView1.Columns.Add("Дата_возврата", "Дата возврата");
        }
        private void LoadIssuedBooks()
        {
            string query = "SELECT ФИО, Название, Автор, Дата_выдачи, Дата_возврата FROM Выдача_книг"; // Запрос для получения данных

            SqlCommand command = new SqlCommand(query, database.GetConnection());
            try
            {
                database.open(); // Открытие соединения
                SqlDataReader reader = command.ExecuteReader(); // Выполнение запроса

                // Очистка DataGridView перед заполнением новыми данными
                dataGridView1.Rows.Clear();

                int recordCount = 0; // Счетчик записей
                while (reader.Read())
                {
                    // Чтение данных из таблицы
                    string clientFIO = reader.GetString(0); // ФИО клиента
                    string bookTitle = reader.GetString(1); // Название книги
                    string bookAuthor = reader.GetString(2); // Автор книги
                    string issueDate = reader.GetString(3); // Дата выдачи
                    string returnDate = reader.GetString(4); // Дата возврата

                    // Добавление строки в DataGridView
                    dataGridView1.Rows.Add(clientFIO, bookTitle, bookAuthor, issueDate, returnDate);
                    recordCount++; // Увеличение счетчика
                }

                reader.Close(); // Закрытие SqlDataReader

                // Установка значения label_Count равным количеству записей
                label_Count.Text = $"{recordCount}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}");
            }
            finally
            {
                database.closed(); // Закрытие соединения
            }
        }
    }
}

