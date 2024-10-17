using System; 
using System.Data; 
using System.Data.SqlClient; // Подключение имен для работы с SQL Server
using System.Windows.Forms;

namespace Modul_6 
{
    public partial class Issue_Book : Form 
    {
        DataBase database = new DataBase(); // Создание объекта для работы с базой данных
        private DataGridView _dataGridView; // Поле для хранения ссылки на компонент DataGridView
        private Library _libraryForm; // Поле для хранения ссылки на форму библиотеки

        // Конструктор класса Issue_Book, принимающий ссылки на формы и DataGridView
        public Issue_Book(Library libraryForm, DataGridView dataGridView1)
        {
            InitializeComponent();
            this.comboBox_AuthorBook.SelectedIndexChanged += new System.EventHandler(this.comboBox_AuthorBook_SelectedIndexChanged); // Подписка на событие изменения выбранного автора
            this.comboBox_NameBook.TextChanged += new System.EventHandler(this.comboBox_NameBook_TextChanged); // Подписка на событие изменения текста в comboBox с названиями книг
            dateTimePicker_Issue.Value = DateTime.Now; // Установка текущей даты выдачи
            dateTimePicker_Return.Value = DateTime.Now.AddDays(14); // Установка даты возврата через 14 дней
            LoadClients(); // Вызов метода для загрузки клиентов
            LoadAuthors(); // Вызов метода для загрузки авторов
            comboBox_FIO.SelectedIndex = -1; // Сброс выбора в ComboBox ФИО
            comboBox_NameBook.SelectedIndex = -1; // Сброс выбора в ComboBox Название
            comboBox_AuthorBook.SelectedIndex = -1; // Сброс выбора в ComboBox Автор
            _dataGridView = dataGridView1; // Ссылка на переданный DataGridView
            _libraryForm = libraryForm; // Ссылка на переданную форму Library
        }
               
        private void comboBox_AuthorBook_SelectedIndexChanged(object sender, EventArgs e) // Обработчик события изменения выбранного автора в comboBox
        {
            if (comboBox_AuthorBook.SelectedItem != null) // Проверка, что выбранный элемент не равен null
            {
                string selectedAuthor = comboBox_AuthorBook.Text; // Получение имени выбранного автора
                LoadBooksByAuthor(selectedAuthor); // Вызов метода для загрузки книг по выбранному автору
            }
        }
       
        private void comboBox_NameBook_TextChanged(object sender, EventArgs e) // Обработчик события изменения текста в comboBox с названиями книг
        {
            string searchText = comboBox_NameBook.Text; // Получение текста из comboBox
            if (!string.IsNullOrWhiteSpace(searchText) && comboBox_AuthorBook.SelectedItem != null) // Проверка на пустоту текста и наличие выбранного автора
            {
                string selectedAuthor = comboBox_AuthorBook.Text; // Получение имени выбранного автора
                LoadBooksByAuthorAndFilter(selectedAuthor, searchText); // Вызов метода для загрузки книг с фильтром
            }
        }
      
        private void LoadBooksByAuthor(string author) // Метод для загрузки книг по выбранному автору
        {
            try
            {
                database.open(); // Открытие соединения с базой данных
                // Создание адаптера для выполнения SQL-запроса
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT Название FROM Книги WHERE Автор = @Author AND Количество > 0", database.GetConnection());
                adapter.SelectCommand.Parameters.AddWithValue("@Author", author); // Добавление параметра для SQL-запроса

                DataTable books = new DataTable(); // Создание таблицы для хранения данных о книгах
                adapter.Fill(books); // Заполнение таблицы данными из базы                              
                if (books.Rows.Count == 0) // Проверка, есть ли доступные книги
                {
                    comboBox_NameBook.DataSource = null; // Если книг нет, сброс источника данных
                }
                else
                {
                    comboBox_NameBook.DataSource = books; // Установка источника данных для comboBox с названиями книг
                    comboBox_NameBook.DisplayMember = "Название"; // Указание поля для отображения
                    comboBox_NameBook.ValueMember = "Название"; // Указание поля для значений
                }
            }
            catch (Exception) { }
            finally
            {
                database.closed(); // Закрытие соединения с базой данных
            }
        }
       
        private void LoadBooksByAuthorAndFilter(string author, string filter) // Метод для загрузки книг по выбранному автору и фильтрации по введенному тексту
        {
            try
            {
                database.open(); // Открытие соединения с базой данных
                // Создание адаптера для выполнения SQL-запроса с фильтром
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT Название FROM Книги WHERE Автор = @Author AND Название LIKE @Filter AND Количество > 0", database.GetConnection());
                adapter.SelectCommand.Parameters.AddWithValue("@Author", author); // Добавление параметра для автора
                adapter.SelectCommand.Parameters.AddWithValue("@Filter", "%" + filter + "%"); // Добавление параметра для фильтра названия книги
                DataTable books = new DataTable(); // Создание таблицы для хранения данных о книгах
                adapter.Fill(books); // Заполнение таблицы данными из базы                              
                if (books.Rows.Count == 0) // Проверка, есть ли доступные книги
                {
                    comboBox_NameBook.DataSource = null; // Если книг нет, сброс источника данных
                }
                else
                {
                    comboBox_NameBook.DataSource = books; // Установка источника данных для comboBox с названиями книг
                    comboBox_NameBook.DisplayMember = "Название"; // Указание поля для отображения
                    comboBox_NameBook.ValueMember = "Название"; // Указание поля для значений
                }
            }
            catch (Exception) { }
            finally
            {
                database.closed(); // Закрытие соединения с базой данных
            }
        }
       
        private void LoadClients() // Метод для загрузки списка клиентов из базы данных
        {
            try
            {
                database.open(); // Открытие соединения с базой данных
                // Создание адаптера для выполнения SQL-запроса
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT ФИО FROM Клиенты", database.GetConnection());
                DataTable clients = new DataTable(); // Создание таблицы для хранения данных о клиентах
                adapter.Fill(clients); // Заполнение таблицы данными из базы
                comboBox_FIO.DataSource = clients; // Установка источника данных для comboBox с ФИО клиентов
                comboBox_FIO.DisplayMember = "ФИО"; // Указание поля для отображения
            }
            catch (Exception) { }
            finally
            {
                database.closed(); // Закрытие соединения с базой данных
            }
        }
        
        private void LoadAuthors() // Метод для загрузки списка авторов книг из базы данных
        {
            try
            {
                database.open(); // Открытие соединения с базой данных
                // Создание адаптера для выполнения SQL-запроса
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT DISTINCT Автор FROM Книги", database.GetConnection());
                DataTable authors = new DataTable(); // Создание таблицы для хранения данных об авторах
                adapter.Fill(authors); // Заполнение таблицы данными из базы
                comboBox_AuthorBook.DataSource = authors; // Установка источника данных для comboBox с авторами
                comboBox_AuthorBook.DisplayMember = "Автор"; // Указание поля для отображения
            }
            catch (Exception) { }
            finally
            {
                database.closed(); // Закрытие соединения с базой данных
            }
        }

        // Обработчик события нажатия кнопки "Выдать книгу"
        private void button_Issue_Click(object sender, EventArgs e)
        {
            // Проверка, что текстовые поля не пустые
            if (string.IsNullOrWhiteSpace(comboBox_FIO.Text) || // Проверка поля ФИО
                string.IsNullOrWhiteSpace(comboBox_AuthorBook.Text) || // Проверка поля автора
                string.IsNullOrWhiteSpace(comboBox_NameBook.Text)) // Проверка поля названия книги
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Вывод сообщения об ошибке
                return; // Прерывание выполнения метода, если поля не заполнены
            }

            try
            {
                database.open(); // Открытие соединения с базой данных
                // Проверка наличия книги в базе данных
                SqlCommand checkBookCommand = new SqlCommand("SELECT Количество FROM Книги WHERE Название = @Name AND Автор = @Author", database.GetConnection());
                checkBookCommand.Parameters.AddWithValue("@Name", comboBox_NameBook.Text); // Добавление параметра для названия книги
                checkBookCommand.Parameters.AddWithValue("@Author", comboBox_AuthorBook.Text); // Добавление параметра для автора

                int quantity = (int)checkBookCommand.ExecuteScalar(); // Получение количества доступных экземпляров

                if (quantity <= 0) // Проверка наличия доступных экземпляров
                {
                    return; // Прерывание выполнения метода, если книги нет
                }
                // Вставка данных о выдаче книги в таблицу Выдача_Книг
                SqlCommand command = new SqlCommand("INSERT INTO Выдача_Книг (ФИО, Автор, Название, Дата_выдачи, Дата_возврата) VALUES (@FIO, @Author, @Name, @IssueDate, @ReturnDate)", database.GetConnection());
                command.Parameters.AddWithValue("@FIO", comboBox_FIO.Text); // Добавление параметра для ФИО клиента
                command.Parameters.AddWithValue("@Author", comboBox_AuthorBook.Text); // Добавление параметра для автора
                command.Parameters.AddWithValue("@Name", comboBox_NameBook.Text); // Добавление параметра для названия книги
                command.Parameters.AddWithValue("@IssueDate", dateTimePicker_Issue.Value); // Добавление параметра для даты выдачи
                command.Parameters.AddWithValue("@ReturnDate", dateTimePicker_Return.Value); // Добавление параметра для даты возврата

                command.ExecuteNonQuery(); // Выполнение запроса на вставку данных о выдаче книги

                // Обновляем количество книг в таблице Книги
                SqlCommand updateCommand = new SqlCommand("UPDATE Книги SET Количество = Количество - 1 WHERE Название = @Name AND Автор = @Author", database.GetConnection());
                updateCommand.Parameters.AddWithValue("@Name", comboBox_NameBook.Text); // Добавление параметра для названия книги
                updateCommand.Parameters.AddWithValue("@Author", comboBox_AuthorBook.Text); // Добавление параметра для автора
                updateCommand.ExecuteNonQuery(); // Выполнение запроса на обновление количества книг

                MessageBox.Show("Книга успешно выдана!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information); // Сообщение об успешной выдаче книги
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при выдаче книги: " + ex.Message); // Обработка исключений и вывод сообщения об ошибке
            }
            finally
            {
                database.closed(); // Закрытие соединения с базой данных
            }
            _libraryForm.RefreshDataGrid(_dataGridView); // Обновление данных в DataGridView на форме Library
        }
    }
}
