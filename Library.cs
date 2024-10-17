using System;
using System.Data;
using System.Data.SqlClient; // Подключение имен для работы с SQL Server
using System.Windows.Forms;

namespace Modul_6
{
    public partial class Library : Form
    {
        DataBase database = new DataBase(); // Создание объекта базы данных
        public Library()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) // Метод загрузки компонента Form1
        {
            CreateColumns(); // Метод создания колонок таблицы
            RefreshDataGrid(dataGridView1); // Заполнение таблицы данными из БД
        }

        private void CreateColumns() // Метод создания колонок
        {
            dataGridView1.Columns.Add("Номер", "Номер"); // на первом месте - название в БД, на втором - отображение на форме
            dataGridView1.Columns.Add("Автор", "Автор"); dataGridView1.Columns.Add("Название", "Название");
            dataGridView1.Columns.Add("Год_издания", "Год издания"); dataGridView1.Columns.Add("Количество", "Количество");
        }

        private void ReadRow(DataGridView drv, IDataRecord record)
        { 
            drv.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetInt32(4));
        }

        public void RefreshDataGrid(DataGridView drv) // Метод обновления таблицы
        { 
            drv.Rows.Clear(); // Очистка строк
            string queryString = $"select * from Книги"; // Выбор таблицы БД для отображения
            SqlCommand command = new SqlCommand(queryString, database.GetConnection()); // SQL запрос на доступ к БД
            database.open(); // Открытие БД
            SqlDataReader reader = command.ExecuteReader(); // Просмотр данных из таблицы в БД
            while (reader.Read()) // Добавление данных в datagridview 
            { 
                ReadRow (drv, reader);
            }
            reader.Close(); // Закрытие просмотра
        }
        private void просмотретьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            всевыданныекниги всевыданныекниги = new всевыданныекниги(); всевыданныекниги.Show();
        }

        private void добавитьКнигуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Delete_Book add_Delete_Book = new Add_Delete_Book(this, dataGridView1);
            add_Delete_Book.Show();
        }

        private void добавитьКлиентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Delete_Client add_Delete_Client = new Add_Delete_Client(); add_Delete_Client.Show();
        }

        private void выдатьКнигуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Issue_Book issue_Book = new Issue_Book(this, dataGridView1); issue_Book.Show();
        }

        private void просмотретьВыданныеКнигиПоОдномуКлиентуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Issued_Book issued_Book = new Issued_Book(this, dataGridView1); issued_Book.button_Return.Visible = false; issued_Book.Show();
        }

        private void вернутьКнигуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Issued_Book issued_Book = new Issued_Book(this, dataGridView1); issued_Book.Show();
        }

        private void просмотретьВсехКлиентовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllClients allclients = new AllClients(); allclients.Show();
        }

        private void SearchBooks() // Метод поиска книг
        {
            string searchValue = textBox_Search.Text.Trim(); // Извлечение значения для поиска
            string queryString;

            if (radioButton_Author.Checked)// Если выбрано по автору
            {
                queryString = $"SELECT * FROM Книги WHERE Автор LIKE @searchValue";
            }
            else if (radioButton_NameBook.Checked) // Если выбрано по названию
            {
                queryString = $"SELECT * FROM Книги WHERE Название LIKE @searchValue";
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите критерий поиска."); // Проверка выбора радио-кнопки
                return;
            }

            SqlCommand command = new SqlCommand(queryString, database.GetConnection());
            command.Parameters.AddWithValue("@searchValue", "%" + searchValue + "%"); // Добавление параметра для поиска
            database.open(); // Открытие БД

            SqlDataReader reader = command.ExecuteReader(); // Выполнение запроса
            dataGridView1.Rows.Clear(); // Очистка предыдущих результатов

            if (reader.HasRows) // Проверка наличия результатов
            {
                while (reader.Read())
                {
                    ReadRow(dataGridView1, reader); // Заполнение DataGridView результатами поиска
                }
            }
            else
            {
                // Обработка отсутствия результатов
                if (radioButton_Author.Checked)
                {
                    MessageBox.Show("Такой автор не найден.");
                }
                else if (radioButton_NameBook.Checked)
                {
                    MessageBox.Show("Книга с таким названием не найдена.");
                }
            }
            reader.Close(); // Закрытие просмотра
        }

        private void Button_Search_Click(object sender, EventArgs e)
        {
            SearchBooks(); // Вызов метода поиска
        }

        private void radioButton_Author_CheckedChanged(object sender, EventArgs e) // Обработчик изменения состояния радио-кнопки
        {
            if (radioButton_Author.Checked)
            {
                label_Search.Text = "Автору"; // Присвоение значения лейблу
            }
        }

        private void radioButton_NameBook_CheckedChanged(object sender, EventArgs e) // Обработчик изменения состояния радио-кнопки
        {
            if (radioButton_NameBook.Checked)
            {
                label_Search.Text = "Названию"; // Присвоение значения лейблу
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox_Search.Clear(); // Очистка текстового поля для поиска
            // Сброс выбора радио-кнопок
            radioButton_Author.Checked = false;
            radioButton_NameBook.Checked = false;
            RefreshDataGrid(dataGridView1); // Возврат всех данные из таблицы Книги
        }
    }
}
