namespace Modul_6
{
    partial class Issue_Book
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_Issue = new System.Windows.Forms.Button();
            this.comboBox_FIO = new System.Windows.Forms.ComboBox();
            this.comboBox_NameBook = new System.Windows.Forms.ComboBox();
            this.comboBox_AuthorBook = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_Issue = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Return = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 203);
            this.label4.Margin = new System.Windows.Forms.Padding(20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Дата выдачи";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Автор";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Название";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "ФИО";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 261);
            this.label5.Margin = new System.Windows.Forms.Padding(20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 18);
            this.label5.TabIndex = 17;
            this.label5.Text = "Дата возврата";
            // 
            // button_Issue
            // 
            this.button_Issue.Font = new System.Drawing.Font("PMingLiU-ExtB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Issue.Location = new System.Drawing.Point(32, 303);
            this.button_Issue.Name = "button_Issue";
            this.button_Issue.Size = new System.Drawing.Size(500, 36);
            this.button_Issue.TabIndex = 19;
            this.button_Issue.Text = "Выдать";
            this.button_Issue.UseVisualStyleBackColor = true;
            this.button_Issue.Click += new System.EventHandler(this.button_Issue_Click);
            // 
            // comboBox_FIO
            // 
            this.comboBox_FIO.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.comboBox_FIO.FormattingEnabled = true;
            this.comboBox_FIO.Location = new System.Drawing.Point(158, 24);
            this.comboBox_FIO.Name = "comboBox_FIO";
            this.comboBox_FIO.Size = new System.Drawing.Size(374, 29);
            this.comboBox_FIO.TabIndex = 20;
            // 
            // comboBox_NameBook
            // 
            this.comboBox_NameBook.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.comboBox_NameBook.FormattingEnabled = true;
            this.comboBox_NameBook.Location = new System.Drawing.Point(158, 82);
            this.comboBox_NameBook.Name = "comboBox_NameBook";
            this.comboBox_NameBook.Size = new System.Drawing.Size(374, 29);
            this.comboBox_NameBook.TabIndex = 21;
            // 
            // comboBox_AuthorBook
            // 
            this.comboBox_AuthorBook.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.comboBox_AuthorBook.FormattingEnabled = true;
            this.comboBox_AuthorBook.Location = new System.Drawing.Point(158, 140);
            this.comboBox_AuthorBook.Name = "comboBox_AuthorBook";
            this.comboBox_AuthorBook.Size = new System.Drawing.Size(374, 29);
            this.comboBox_AuthorBook.TabIndex = 22;
            // 
            // dateTimePicker_Issue
            // 
            this.dateTimePicker_Issue.CalendarFont = new System.Drawing.Font("Nirmala UI", 12F);
            this.dateTimePicker_Issue.Location = new System.Drawing.Point(158, 201);
            this.dateTimePicker_Issue.Name = "dateTimePicker_Issue";
            this.dateTimePicker_Issue.Size = new System.Drawing.Size(374, 20);
            this.dateTimePicker_Issue.TabIndex = 23;
            // 
            // dateTimePicker_Return
            // 
            this.dateTimePicker_Return.CalendarFont = new System.Drawing.Font("Nirmala UI", 12F);
            this.dateTimePicker_Return.Location = new System.Drawing.Point(158, 261);
            this.dateTimePicker_Return.Name = "dateTimePicker_Return";
            this.dateTimePicker_Return.Size = new System.Drawing.Size(374, 20);
            this.dateTimePicker_Return.TabIndex = 24;
            // 
            // Issue_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 351);
            this.Controls.Add(this.dateTimePicker_Return);
            this.Controls.Add(this.dateTimePicker_Issue);
            this.Controls.Add(this.comboBox_AuthorBook);
            this.Controls.Add(this.comboBox_NameBook);
            this.Controls.Add(this.comboBox_FIO);
            this.Controls.Add(this.button_Issue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Issue_Book";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выдача книги";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_Issue;
        private System.Windows.Forms.ComboBox comboBox_FIO;
        private System.Windows.Forms.ComboBox comboBox_NameBook;
        private System.Windows.Forms.ComboBox comboBox_AuthorBook;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Issue;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Return;
    }
}