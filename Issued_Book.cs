using System.Data.SqlClient;
using System.Windows.Forms;
using System;
using System.Linq;

namespace Modul_6
{
    public partial class Issued_Book : Form
    {
        private DataGridView _dataGridView; // Поле для хранения ссылки на компонент DataGridView
        private Library _libraryForm; // Поле для хранения ссылки на форму библиотеки
        DataBase database = new DataBase(); // Создание объекта базы данных

        public Issued_Book(Library libraryForm, DataGridView dataGridView1)
        {
            InitializeComponent();
            LoadClientComboBox(); // Загрузка клиентов при инициализации формы
            _dataGridView = dataGridView1; // Ссылка на DataGridView
            _libraryForm = libraryForm; // Ссылка на форму Library
        }

        private void Issued_Book_Load(object sender, EventArgs e)
        {
            CreateColumns();
        }

        private void CreateColumns() // Метод создания колонок
        {
            dataGridView_ClientBookIssue.Columns.Add("ФИО", "ФИО"); // на первом месте - название в БД, на втором - отображение на форме
            dataGridView_ClientBookIssue.Columns.Add("Автор", "Автор"); dataGridView_ClientBookIssue.Columns.Add("Название", "Название");
            dataGridView_ClientBookIssue.Columns.Add("Дата_выдачи", "Дата выдачи"); dataGridView_ClientBookIssue.Columns.Add("Дата_возврата", "Дата возврата");
        }
        private void LoadClientComboBox() // Метод для загрузки клиентов в comboBoxFIOCLient
        {
            string query = "SELECT ФИО FROM Клиенты";
            SqlCommand command = new SqlCommand(query, database.GetConnection());

            try
            {
                database.open(); // Открытие соединения с БД
                SqlDataReader reader = command.ExecuteReader(); // Выполнение запроса
                while (reader.Read())
                {
                    comboBoxFIOCLient.Items.Add(reader.GetString(0)); // Добавление ФИО клиента в comboBox
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки клиентов: {ex.Message}");
            }
            finally
            {
                database.closed(); // Закрытие соединения
            }
        }

        private void button_Checked_Click(object sender, EventArgs e) // Кнопка "Просмотр выданных книг"
        {
            string selectedClient = comboBoxFIOCLient.SelectedItem?.ToString(); // Получение выбранного клиента

            if (string.IsNullOrEmpty(selectedClient))
            {
                MessageBox.Show("Пожалуйста, выберите клиента.");
                return;
            }

            // SQL-запрос для получения выданных книг по клиенту с датами
            string query = $"SELECT Название, Автор, Дата_выдачи, Дата_возврата FROM Выдача_книг WHERE ФИО = @ClientFIO ORDER BY Дата_выдачи DESC";
            SqlCommand command = new SqlCommand(query, database.GetConnection());
            command.Parameters.AddWithValue("@ClientFIO", selectedClient); // Параметр для ФИО клиента

            try
            {
                database.open(); // Открытие соединения с БД
                SqlDataReader reader = command.ExecuteReader(); // Выполнение запроса

                // Очистка DataGridView перед заполнением новыми данными
                dataGridView_ClientBookIssue.Rows.Clear();

                while (reader.Read())
                {
                    // Попробуем считать даты как строки, если тип данных - string
                    string название = reader.GetString(0);
                    string автор = reader.GetString(1);
                    string дата_выдачи = reader.GetString(2); // Чтение как строки
                    string дата_возврата = reader.GetString(3); // Чтение как строки

                    dataGridView_ClientBookIssue.Rows.Add(selectedClient, автор, название, дата_выдачи, дата_возврата);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных о книгах: {ex.Message}");
            }
            finally
            {
                database.closed(); // Закрытие соединения
            }
        }


        private void button_Return_Click(object sender, EventArgs e) // Кнопка "Возврат книги"
        {
            if (dataGridView_ClientBookIssue.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите книгу для возврата.");
                return;
            }
            // Получение выбранной строки
            DataGridViewRow selectedRow = dataGridView_ClientBookIssue.SelectedRows[0];
            string bookTitle = selectedRow.Cells[2].Value.ToString(); // Название книги (2-я ячейка)
            string bookAuthor = selectedRow.Cells[1].Value.ToString(); // Автор книги (1-я ячейка)
            string clientFIO = comboBoxFIOCLient.SelectedItem.ToString(); // ФИО клиента
            // SQL-запрос для возврата книги (например, удаление записи о выдаче)
            string query = "DELETE FROM Выдача_книг WHERE ФИО = @ClientFIO AND Название = @BookTitle";
            SqlCommand command = new SqlCommand(query, database.GetConnection());
            command.Parameters.AddWithValue("@ClientFIO", clientFIO); // Параметр для ФИО клиента
            command.Parameters.AddWithValue("@BookTitle", bookTitle); // Параметр для названия книги

            try
            {
                database.open(); // Открытие соединения
                int deletedRowsCount = command.ExecuteNonQuery(); // Получение количества удаленных строк
                MessageBox.Show("Книга успешно возвращена.");               
                UpdateBookQuantity(bookTitle, bookAuthor, deletedRowsCount); // Обновление количества книг в таблице Книги на основе количества удаленных записей               
                button_Checked_Click(sender, e); // Обновление DataGridView после возврата книги

                // Вызов метода обновления данных в форме библиотеки
                var libraryForm = Application.OpenForms.OfType<Library>().FirstOrDefault();
                if (libraryForm != null)
                {
                    _libraryForm.RefreshDataGrid(_dataGridView); // Обновление данных в DataGridView на форме Library
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при возврате книги: {ex.Message}");
            }
            finally
            {
                database.closed(); // Закрытие соединения
            }
        }

        // Метод для обновления количества книг в таблице Книги
        private void UpdateBookQuantity(string bookTitle, string bookAuthor, int deletedRowsCount)
        {
            // SQL-запрос для увеличения количества книг на количество удаленных записей
            string query = "UPDATE Книги SET Количество = Количество + @DeletedRowsCount WHERE Название = @BookTitle AND Автор = @BookAuthor";
            SqlCommand command = new SqlCommand(query, database.GetConnection());
            command.Parameters.AddWithValue("@DeletedRowsCount", deletedRowsCount); // Параметр для количества удаленных записей
            command.Parameters.AddWithValue("@BookTitle", bookTitle); // Параметр для названия книги
            command.Parameters.AddWithValue("@BookAuthor", bookAuthor); // Параметр для автора книги

            try
            {
                database.open(); // Открытие соединения
                command.ExecuteNonQuery(); // Выполнение команды обновления количества
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обновлении количества книг: {ex.Message}");
            }
            finally
            {
                database.closed(); // Закрытие соединения
            }
        }
    }
}
