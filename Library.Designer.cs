namespace Modul_6
{
    partial class Library
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.книгиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотретьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьКнигуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьКлиентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотретьВсехКлиентовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выдачаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выдатьКнигуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вернутьКнигуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотретьВыданныеКнигиПоОдномуКлиентуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.radioButton_Author = new System.Windows.Forms.RadioButton();
            this.radioButton_NameBook = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.label_Search = new System.Windows.Forms.Label();
            this.Button_Search = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.книгиToolStripMenuItem,
            this.клиентыToolStripMenuItem,
            this.выдачаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // книгиToolStripMenuItem
            // 
            this.книгиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.просмотретьToolStripMenuItem,
            this.добавитьКнигуToolStripMenuItem});
            this.книгиToolStripMenuItem.Name = "книгиToolStripMenuItem";
            this.книгиToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.книгиToolStripMenuItem.Text = "Книги";
            // 
            // просмотретьToolStripMenuItem
            // 
            this.просмотретьToolStripMenuItem.Name = "просмотретьToolStripMenuItem";
            this.просмотретьToolStripMenuItem.Size = new System.Drawing.Size(277, 22);
            this.просмотретьToolStripMenuItem.Text = "Просмотреть список выданных книг";
            this.просмотретьToolStripMenuItem.Click += new System.EventHandler(this.просмотретьToolStripMenuItem_Click);
            // 
            // добавитьКнигуToolStripMenuItem
            // 
            this.добавитьКнигуToolStripMenuItem.Name = "добавитьКнигуToolStripMenuItem";
            this.добавитьКнигуToolStripMenuItem.Size = new System.Drawing.Size(277, 22);
            this.добавитьКнигуToolStripMenuItem.Text = "Добавить(удалить) книгу";
            this.добавитьКнигуToolStripMenuItem.Click += new System.EventHandler(this.добавитьКнигуToolStripMenuItem_Click);
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьКлиентаToolStripMenuItem,
            this.просмотретьВсехКлиентовToolStripMenuItem});
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.клиентыToolStripMenuItem.Text = "Клиенты";
            // 
            // добавитьКлиентаToolStripMenuItem
            // 
            this.добавитьКлиентаToolStripMenuItem.Name = "добавитьКлиентаToolStripMenuItem";
            this.добавитьКлиентаToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.добавитьКлиентаToolStripMenuItem.Text = "Добавить(удалить) клиента";
            this.добавитьКлиентаToolStripMenuItem.Click += new System.EventHandler(this.добавитьКлиентаToolStripMenuItem_Click);
            // 
            // просмотретьВсехКлиентовToolStripMenuItem
            // 
            this.просмотретьВсехКлиентовToolStripMenuItem.Name = "просмотретьВсехКлиентовToolStripMenuItem";
            this.просмотретьВсехКлиентовToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.просмотретьВсехКлиентовToolStripMenuItem.Text = "Просмотреть всех клиентов";
            this.просмотретьВсехКлиентовToolStripMenuItem.Click += new System.EventHandler(this.просмотретьВсехКлиентовToolStripMenuItem_Click);
            // 
            // выдачаToolStripMenuItem
            // 
            this.выдачаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выдатьКнигуToolStripMenuItem,
            this.вернутьКнигуToolStripMenuItem,
            this.просмотретьВыданныеКнигиПоОдномуКлиентуToolStripMenuItem});
            this.выдачаToolStripMenuItem.Name = "выдачаToolStripMenuItem";
            this.выдачаToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.выдачаToolStripMenuItem.Text = "Выдача";
            // 
            // выдатьКнигуToolStripMenuItem
            // 
            this.выдатьКнигуToolStripMenuItem.Name = "выдатьКнигуToolStripMenuItem";
            this.выдатьКнигуToolStripMenuItem.Size = new System.Drawing.Size(351, 22);
            this.выдатьКнигуToolStripMenuItem.Text = "Выдать книгу";
            this.выдатьКнигуToolStripMenuItem.Click += new System.EventHandler(this.выдатьКнигуToolStripMenuItem_Click);
            // 
            // вернутьКнигуToolStripMenuItem
            // 
            this.вернутьКнигуToolStripMenuItem.Name = "вернутьКнигуToolStripMenuItem";
            this.вернутьКнигуToolStripMenuItem.Size = new System.Drawing.Size(351, 22);
            this.вернутьКнигуToolStripMenuItem.Text = "Вернуть книгу";
            this.вернутьКнигуToolStripMenuItem.Click += new System.EventHandler(this.вернутьКнигуToolStripMenuItem_Click);
            // 
            // просмотретьВыданныеКнигиПоОдномуКлиентуToolStripMenuItem
            // 
            this.просмотретьВыданныеКнигиПоОдномуКлиентуToolStripMenuItem.Name = "просмотретьВыданныеКнигиПоОдномуКлиентуToolStripMenuItem";
            this.просмотретьВыданныеКнигиПоОдномуКлиентуToolStripMenuItem.Size = new System.Drawing.Size(351, 22);
            this.просмотретьВыданныеКнигиПоОдномуКлиентуToolStripMenuItem.Text = "Просмотреть выданные книги по одному клиенту";
            this.просмотретьВыданныеКнигиПоОдномуКлиентуToolStripMenuItem.Click += new System.EventHandler(this.просмотретьВыданныеКнигиПоОдномуКлиентуToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 392);
            this.dataGridView1.TabIndex = 1;
            // 
            // radioButton_Author
            // 
            this.radioButton_Author.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButton_Author.AutoSize = true;
            this.radioButton_Author.Location = new System.Drawing.Point(3, 3);
            this.radioButton_Author.Name = "radioButton_Author";
            this.radioButton_Author.Size = new System.Drawing.Size(55, 17);
            this.radioButton_Author.TabIndex = 2;
            this.radioButton_Author.TabStop = true;
            this.radioButton_Author.Text = "Автор";
            this.radioButton_Author.UseVisualStyleBackColor = true;
            this.radioButton_Author.CheckedChanged += new System.EventHandler(this.radioButton_Author_CheckedChanged);
            // 
            // radioButton_NameBook
            // 
            this.radioButton_NameBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButton_NameBook.AutoSize = true;
            this.radioButton_NameBook.Location = new System.Drawing.Point(2, 26);
            this.radioButton_NameBook.Name = "radioButton_NameBook";
            this.radioButton_NameBook.Size = new System.Drawing.Size(75, 17);
            this.radioButton_NameBook.TabIndex = 3;
            this.radioButton_NameBook.TabStop = true;
            this.radioButton_NameBook.Text = "Название";
            this.radioButton_NameBook.UseVisualStyleBackColor = true;
            this.radioButton_NameBook.CheckedChanged += new System.EventHandler(this.radioButton_NameBook_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.radioButton_Author);
            this.panel1.Controls.Add(this.radioButton_NameBook);
            this.panel1.Location = new System.Drawing.Point(12, 425);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(90, 50);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(108, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Поиск по";
            // 
            // textBox_Search
            // 
            this.textBox_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Search.Location = new System.Drawing.Point(112, 446);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(323, 29);
            this.textBox_Search.TabIndex = 6;
            // 
            // label_Search
            // 
            this.label_Search.AutoSize = true;
            this.label_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Search.Location = new System.Drawing.Point(191, 422);
            this.label_Search.Name = "label_Search";
            this.label_Search.Size = new System.Drawing.Size(0, 20);
            this.label_Search.TabIndex = 7;
            // 
            // Button_Search
            // 
            this.Button_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Search.Location = new System.Drawing.Point(441, 428);
            this.Button_Search.Name = "Button_Search";
            this.Button_Search.Size = new System.Drawing.Size(108, 47);
            this.Button_Search.TabIndex = 8;
            this.Button_Search.Text = "Поиск";
            this.Button_Search.UseVisualStyleBackColor = true;
            this.Button_Search.Click += new System.EventHandler(this.Button_Search_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(555, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 47);
            this.button1.TabIndex = 9;
            this.button1.Text = "Сброс поиска";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Button_Search);
            this.Controls.Add(this.label_Search);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Library";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Библиотека";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem книгиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотретьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьКнигуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьКлиентаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выдачаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выдатьКнигуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вернутьКнигуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотретьВыданныеКнигиПоОдномуКлиентуToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem просмотретьВсехКлиентовToolStripMenuItem;
        private System.Windows.Forms.RadioButton radioButton_Author;
        private System.Windows.Forms.RadioButton radioButton_NameBook;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Label label_Search;
        private System.Windows.Forms.Button Button_Search;
        private System.Windows.Forms.Button button1;
    }
}

