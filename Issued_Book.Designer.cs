namespace Modul_6
{
    partial class Issued_Book
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_ClientBookIssue = new System.Windows.Forms.DataGridView();
            this.button_Return = new System.Windows.Forms.Button();
            this.comboBoxFIOCLient = new System.Windows.Forms.ComboBox();
            this.button_Checked = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ClientBookIssue)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО Клиента:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Выданные книги:";
            // 
            // dataGridView_ClientBookIssue
            // 
            this.dataGridView_ClientBookIssue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_ClientBookIssue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ClientBookIssue.Location = new System.Drawing.Point(12, 88);
            this.dataGridView_ClientBookIssue.Name = "dataGridView_ClientBookIssue";
            this.dataGridView_ClientBookIssue.Size = new System.Drawing.Size(776, 310);
            this.dataGridView_ClientBookIssue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_ClientBookIssue.TabIndex = 3;
            // 
            // button_Return
            // 
            this.button_Return.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Return.Font = new System.Drawing.Font("PMingLiU-ExtB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Return.Location = new System.Drawing.Point(12, 404);
            this.button_Return.Name = "button_Return";
            this.button_Return.Size = new System.Drawing.Size(141, 34);
            this.button_Return.TabIndex = 20;
            this.button_Return.Text = "Вернуть книгу";
            this.button_Return.UseVisualStyleBackColor = true;
            this.button_Return.Click += new System.EventHandler(this.button_Return_Click);
            // 
            // comboBoxFIOCLient
            // 
            this.comboBoxFIOCLient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.comboBoxFIOCLient.FormattingEnabled = true;
            this.comboBoxFIOCLient.Location = new System.Drawing.Point(177, 10);
            this.comboBoxFIOCLient.Name = "comboBoxFIOCLient";
            this.comboBoxFIOCLient.Size = new System.Drawing.Size(611, 33);
            this.comboBoxFIOCLient.TabIndex = 21;
            // 
            // button_Checked
            // 
            this.button_Checked.Font = new System.Drawing.Font("PMingLiU-ExtB", 15.75F);
            this.button_Checked.Location = new System.Drawing.Point(652, 46);
            this.button_Checked.Name = "button_Checked";
            this.button_Checked.Size = new System.Drawing.Size(136, 36);
            this.button_Checked.TabIndex = 22;
            this.button_Checked.Text = "Просмотр";
            this.button_Checked.UseVisualStyleBackColor = true;
            this.button_Checked.Click += new System.EventHandler(this.button_Checked_Click);
            // 
            // Issued_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Checked);
            this.Controls.Add(this.comboBoxFIOCLient);
            this.Controls.Add(this.button_Return);
            this.Controls.Add(this.dataGridView_ClientBookIssue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Issued_Book";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выданные книги";
            this.Load += new System.EventHandler(this.Issued_Book_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ClientBookIssue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_ClientBookIssue;
        public System.Windows.Forms.Button button_Return;
        private System.Windows.Forms.ComboBox comboBoxFIOCLient;
        private System.Windows.Forms.Button button_Checked;
    }
}