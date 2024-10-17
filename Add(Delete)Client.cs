using System;
using System.Windows.Forms;
using System.Data.SqlClient; // Подключение имен для работы с SQL Server

namespace Modul_6
{
    public partial class Add_Delete_Client : Form
    {
        DataBase database = new DataBase(); // Создание объекта базы данных
        public Add_Delete_Client()
        {
            InitializeComponent();
        }

        private void button_AddClient_Click(object sender, EventArgs e)
        {
            // Получение значений из текстовых полей
            string name = textBox_FIO.Text; // Фамилия
            string Adress = textBox_Adress.Text; // Адресс
            string Birth = textBox_Birth.Text; // Дата рождения
            string phone = textBox_Number.Text; // Номер телефона
            database.open(); // Открытие соединения с БД
            // SQL-запрос для вставки нового клиента
            string insertQuery = "INSERT INTO Клиенты (ФИО, Адрес, Дата_рождения, Номер_телефона) VALUES (@FIO, @Adress, @Birth, @Phone)";
            SqlCommand insertCmd = new SqlCommand(insertQuery, database.GetConnection()); // Команда для вставки
            insertCmd.Parameters.AddWithValue("@FIO", name); // Параметр для ФИО
            insertCmd.Parameters.AddWithValue("@Adress", Adress); // Параметр для алреса
            insertCmd.Parameters.AddWithValue("@Birth", Birth); // Параметр для даты рождения
            insertCmd.Parameters.AddWithValue("@Phone", phone); // Параметр для номера
            insertCmd.ExecuteNonQuery(); // Выполнение команды вставки
            database.closed(); // Закрытие соединение с БД
            MessageBox.Show("Клиент добавлен!"); // Вывод сообщения

            // Очистка текстовых полей
            textBox_Adress.Text = ""; textBox_Birth.Text = ""; textBox_FIO.Text = ""; textBox_Number.Text = "";
        }

        private void button_DelClient_Click(object sender, EventArgs e)
        {
            // Получение значений из текстовых полей
            string name = textBox_FIO.Text; // ФИО
            string phone = textBox_Number.Text; //Номер телефона
            database.open(); // Открытие соединения с БД
            // SQL-запрос для удаления клиента
            string deleteQuery = "DELETE FROM Клиенты WHERE ФИО = @FIO AND Номер_телефона = @Phone";
            SqlCommand deleteCmd = new SqlCommand(deleteQuery, database.GetConnection()); // Команда для удаления
            deleteCmd.Parameters.AddWithValue("@FIO", name); // Параметр для ФИО
            deleteCmd.Parameters.AddWithValue("@Phone", phone); // Параметр для номера телефона
            deleteCmd.ExecuteNonQuery(); // Выполнение команды вставки
            database.closed(); // Закрытие соединение с БД
            MessageBox.Show("Клиент удалён!"); // Вывод сообщения
            // Очистка текстовых полей
            textBox_Adress.Text = ""; textBox_Birth.Text = ""; textBox_FIO.Text = ""; textBox_Number.Text = "";
        }
    }
}
