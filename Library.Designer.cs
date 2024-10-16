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
            this.выдачаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выдатьКнигуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вернутьКнигуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотретьВыданныеКнигиПоОдномуКлиентуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.просмотретьВсехКлиентовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.добавитьКлиентаToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.добавитьКлиентаToolStripMenuItem.Text = "Добавить(удалить) клиента";
            this.добавитьКлиентаToolStripMenuItem.Click += new System.EventHandler(this.добавитьКлиентаToolStripMenuItem_Click);
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
            this.dataGridView1.Size = new System.Drawing.Size(776, 411);
            this.dataGridView1.TabIndex = 1;
            // 
            // просмотретьВсехКлиентовToolStripMenuItem
            // 
            this.просмотретьВсехКлиентовToolStripMenuItem.Name = "просмотретьВсехКлиентовToolStripMenuItem";
            this.просмотретьВсехКлиентовToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.просмотретьВсехКлиентовToolStripMenuItem.Text = "Просмотреть всех клиентов";
            this.просмотретьВсехКлиентовToolStripMenuItem.Click += new System.EventHandler(this.просмотретьВсехКлиентовToolStripMenuItem_Click);
            // 
            // Library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

