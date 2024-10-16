using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Modul_6
{
    public partial class Issue_Book : Form
    {       
        SqlConnection connections = new SqlConnection(@"Data Source = M1TARG1\M1TARG1SQL; Initial Catalog = Library; Integrated Security = True"); // Создание подключения к базе данных
        private DataGridView _dataGridView; // Поле для хранения ссылки на компонент DataGridView
        private Library _libraryForm; // Поле для хранения ссылки на форму библиотеки

        public Issue_Book(Library libraryForm, DataGridView dataGridView1)
        {
            InitializeComponent();
            this.comboBox_AuthorBook.SelectedIndexChanged += new System.EventHandler(this.comboBox_AuthorBook_SelectedIndexChanged); // Подписка на событие изменения выбранного автора
            this.comboBox_NameBook.TextChanged += new System.EventHandler(this.comboBox_NameBook_TextChanged); // Подписка на событие изменения текста в comboBox_NameBook
            dateTimePicker_Issue.Value = DateTime.Now; // Установка текущей даты выдачи книги
            dateTimePicker_Return.Value = DateTime.Now.AddDays(14); // Установка даты возврата книги через две недели

            // Загрузка списка клиентов и авторов книг
            LoadClients();
            LoadAuthors();

            comboBox_FIO.SelectedIndex = -1; // Сброс выбора в ComboBox ФИО
            comboBox_NameBook.SelectedIndex = -1; // Сброс выбора в ComboBox Название
            comboBox_AuthorBook.SelectedIndex = -1; // Сброс выбора в ComboBox Автор
            _dataGridView = dataGridView1; // Ссылка на DataGridView
            _libraryForm = libraryForm; // Ссылка на форму Library
        }
               
        private void LoadClients() // Метод для загрузки списка клиентов из базы данных
        {
            try
            {
                connections.Open(); // Соединение с базой данных
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT ФИО FROM Клиенты", connections); // Запрос для получения ФИО клиентов
                DataTable clients = new DataTable(); // Создание таблицы для хранения данных
                adapter.Fill(clients); // Заполнение таблицы данными из базы
                comboBox_FIO.DataSource = clients; // Установка источника данных для comboBox
                comboBox_FIO.DisplayMember = "ФИО"; // Какое поле отображать
            }
            catch (Exception ex)
            {               
                MessageBox.Show("Ошибка при загрузке клиентов: " + ex.Message); // Обработка исключений
            }
            finally
            {
                connections.Close(); // Закрыть соединение
            }
        }
               
        private void LoadAuthors() // Метод для загрузки списка авторов книг из базы данных
        {
            try
            {
                connections.Open(); // Соединение с базой данных
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT DISTINCT Автор FROM Книги", connections); // Запрос для получения уникальных авторов
                DataTable authors = new DataTable(); // Создание таблицы для хранения данных
                adapter.Fill(authors); // Заполнение таблицы данными из базы
                comboBox_AuthorBook.DataSource = authors; // Устанавка источника данных для comboBox
                comboBox_AuthorBook.DisplayMember = "Автор"; // Какое поле отображать
            }
            catch (Exception ex)
            {              
                MessageBox.Show("Ошибка при загрузке авторов: " + ex.Message); // Обработка исключений
            }
            finally
            {
                connections.Close(); // Закрыть соединения
            }
        }
              
        private void comboBox_AuthorBook_SelectedIndexChanged(object sender, EventArgs e) // Обработчик события изменения выбранного автора
        {
            // Проверка, выбран ли автор
            if (comboBox_AuthorBook.SelectedItem != null)
            {
                string selectedAuthor = comboBox_AuthorBook.Text; // Получение имя выбранного автора
                LoadBooksByAuthor(selectedAuthor); // Загрузка книг, связанных с выбранным автором
            }
            else
            {
                MessageBox.Show("Автор не выбран."); // Сообщение, что автор не выбран
            }
        }
               
        private void LoadBooksByAuthor(string author) // Метод для загрузки книг по выбранному автору
        {
            try
            {
                connections.Open(); // Соединение с базой данных
                // Запрос для получения названий книг выбранного автора, у которых есть доступные экземпляры
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT Название FROM Книги WHERE Автор = @Author AND Количество > 0", connections);
                adapter.SelectCommand.Parameters.AddWithValue("@Author", author); // Добавление параметра для запроса

                DataTable books = new DataTable(); // Создание таблицы для хранения данных о книгах
                adapter.Fill(books); // Заполнение таблицы данными из базы

                // Проверка, есть ли доступные книги
                if (books.Rows.Count == 0)
                {
                    MessageBox.Show("Данной книги сейчас нет", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    comboBox_NameBook.DataSource = null; // Если книг нет, сброс источника данных
                }
                else
                {
                    comboBox_NameBook.DataSource = books; // Установка источника данных для comboBox с названиями книг
                    comboBox_NameBook.DisplayMember = "Название"; // Какое поле отображать
                    comboBox_NameBook.ValueMember = "Название"; // Какое поле использовать как значение
                }
            }
            catch (Exception)
            {
                // Пустая конструкция для корректной работы
            }
            finally
            {
                connections.Close(); // Закрыть соединение
            }
        }
               
        private void comboBox_NameBook_TextChanged(object sender, EventArgs e) // Обработчик события изменения текста в comboBox_NameBook
        {
           
            string searchText = comboBox_NameBook.Text; // Получение текста, введенного пользователем

            // Фильтр книг по введенному тексту
            if (!string.IsNullOrWhiteSpace(searchText) && comboBox_AuthorBook.SelectedItem != null)
            {
                string selectedAuthor = comboBox_AuthorBook.Text;
                LoadBooksByAuthorAndFilter(selectedAuthor, searchText);
            }
        }
               
        private void LoadBooksByAuthorAndFilter(string author, string filter) // Метод для загрузки книг по выбранному автору и фильтрации по введенному тексту
        {
            try
            {
                connections.Open(); // Соединение с базой данных
                // Запрос для получения названий книг выбранного автора, у которых есть доступные экземпляры и соответствующих фильтру
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT Название FROM Книги WHERE Автор = @Author AND Название LIKE @Filter AND Количество > 0", connections);
                adapter.SelectCommand.Parameters.AddWithValue("@Author", author); // Добавление параметра для запроса
                adapter.SelectCommand.Parameters.AddWithValue("@Filter", "%" + filter + "%"); // Добавление фильтра для названия книги

                DataTable books = new DataTable(); // Создание таблицы для хранения данных о книгах
                adapter.Fill(books); // Заполнение таблицы данными из базы

                // Проверка, есть ли доступные книги
                if (books.Rows.Count == 0)
                {
                    MessageBox.Show("Данной книги сейчас нет", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    comboBox_NameBook.DataSource = null; // Если книг нет, сброс источник данных
                }
                else
                {
                    comboBox_NameBook.DataSource = books; // Установка источника данных для comboBox с названиями книг
                    comboBox_NameBook.DisplayMember = "Название"; // Какое поле отображать
                    comboBox_NameBook.ValueMember = "Название"; // Какое поле использовать как значение
                }
            }
            catch (Exception)
            {
                // Пустая конструкция для корректной работы
            }
            finally
            {
                connections.Close(); // Закрыть соединение
            }
        }
               
        private void button_Issue_Click(object sender, EventArgs e) // Обработчик события нажатия кнопки "Выдать книгу"
        {
            // Проверка, что текстовые поля не пустые
            if (string.IsNullOrWhiteSpace(comboBox_FIO.Text) ||
                string.IsNullOrWhiteSpace(comboBox_AuthorBook.Text) ||
                string.IsNullOrWhiteSpace(comboBox_NameBook.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Прерывание выполнения метода, если поля не заполнены
            }
            try
            {
                connections.Open(); // Соединение с базой данных

                // Проверка наличие книги в базе данных
                SqlCommand checkBookCommand = new SqlCommand("SELECT Количество FROM Книги WHERE Название = @Name AND Автор = @Author", connections);
                checkBookCommand.Parameters.AddWithValue("@Name", comboBox_NameBook.Text);
                checkBookCommand.Parameters.AddWithValue("@Author", comboBox_AuthorBook.Text);

                int quantity = (int)checkBookCommand.ExecuteScalar(); // Получение количества доступных экземпляров

                if (quantity <= 0)
                {
                    MessageBox.Show("Книга недоступна для выдачи.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Прерывание выполнения метода, если книги нет
                }

                // Вставка данных о выдаче книги в таблицу Выдача_Книг
                SqlCommand command = new SqlCommand("INSERT INTO Выдача_Книг (ФИО, Автор, Название, Дата_выдачи, Дата_возврата) VALUES (@FIO, @Author, @Name, @IssueDate, @ReturnDate)", connections);
                command.Parameters.AddWithValue("@FIO", comboBox_FIO.Text); // Добавление ФИО
                command.Parameters.AddWithValue("@Author", comboBox_AuthorBook.Text); // Добавление автора
                command.Parameters.AddWithValue("@Name", comboBox_NameBook.Text); // Добавление названия книги
                command.Parameters.AddWithValue("@IssueDate", dateTimePicker_Issue.Value); // Добавление дату выдачи
                command.Parameters.AddWithValue("@ReturnDate", dateTimePicker_Return.Value); // Добавление дату возврата

                command.ExecuteNonQuery(); // Выполнение запроса на вставку

                // Обновляем количество книг в таблице Книги
                SqlCommand updateCommand = new SqlCommand("UPDATE Книги SET Количество = Количество - 1 WHERE Название = @Name AND Автор = @Author", connections);
                updateCommand.Parameters.AddWithValue("@Name", comboBox_NameBook.Text);
                updateCommand.Parameters.AddWithValue("@Author", comboBox_AuthorBook.Text); 
                updateCommand.ExecuteNonQuery(); // Выполняем запрос на обновление

                MessageBox.Show("Книга успешно выдана!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information); // Сообщение об успешной выдаче книги
            }
            catch (Exception ex)
            {               
                MessageBox.Show("Ошибка при выдаче книги: " + ex.Message); // Обработка исключений
            }
            finally
            {
                connections.Close(); // Закрыть соединение
            }
            _libraryForm.RefreshDataGrid(_dataGridView); // Обновление данных в DataGridView на форме Library
        }
    }
}
