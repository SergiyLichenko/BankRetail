namespace BankRetail
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Debetors_groupBox = new System.Windows.Forms.GroupBox();
            this.Debetors_dataGridView = new System.Windows.Forms.DataGridView();
            this.DebetorsDetails_groupBox = new System.Windows.Forms.GroupBox();
            this.DebetorPhoneNumber_label = new System.Windows.Forms.Label();
            this.DebetorPostNumber_label = new System.Windows.Forms.Label();
            this.DebetorName_label = new System.Windows.Forms.Label();
            this.DebetorID_label = new System.Windows.Forms.Label();
            this.DebetorPhoneNumber_textBox = new System.Windows.Forms.TextBox();
            this.DebetorPostNumber_textBox = new System.Windows.Forms.TextBox();
            this.DebetorName_textBox = new System.Windows.Forms.TextBox();
            this.DebetorID_textBox = new System.Windows.Forms.TextBox();
            this.Credits_groupBox = new System.Windows.Forms.GroupBox();
            this.Credits_dataGridView = new System.Windows.Forms.DataGridView();
            this.Payments_groupBox = new System.Windows.Forms.GroupBox();
            this.Payments_dataGridView = new System.Windows.Forms.DataGridView();
            this.Search_groupBox = new System.Windows.Forms.GroupBox();
            this.DebetorPhoneNumberSearched_label = new System.Windows.Forms.Label();
            this.DebetorPostNumberSearched_label = new System.Windows.Forms.Label();
            this.DebetorNameSearched_label = new System.Windows.Forms.Label();
            this.NextRow_button = new System.Windows.Forms.Button();
            this.Search_button = new System.Windows.Forms.Button();
            this.DebetorPhoneNumberSearched_textBox = new System.Windows.Forms.TextBox();
            this.DebetorPostNumberSearched_textBox = new System.Windows.Forms.TextBox();
            this.DebetorNameSearched_textBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDataToSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debetorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewDebetorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openNewCreditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passNewPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DataBase_checkBox = new System.Windows.Forms.CheckBox();
            this.SearchInDatabase_label = new System.Windows.Forms.Label();
            this.Debetors_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Debetors_dataGridView)).BeginInit();
            this.DebetorsDetails_groupBox.SuspendLayout();
            this.Credits_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Credits_dataGridView)).BeginInit();
            this.Payments_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Payments_dataGridView)).BeginInit();
            this.Search_groupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Debetors_groupBox
            // 
            this.Debetors_groupBox.Controls.Add(this.Debetors_dataGridView);
            this.Debetors_groupBox.Location = new System.Drawing.Point(43, 155);
            this.Debetors_groupBox.Name = "Debetors_groupBox";
            this.Debetors_groupBox.Size = new System.Drawing.Size(334, 162);
            this.Debetors_groupBox.TabIndex = 0;
            this.Debetors_groupBox.TabStop = false;
            this.Debetors_groupBox.Text = "Debetors";
            // 
            // Debetors_dataGridView
            // 
            this.Debetors_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Debetors_dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Debetors_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Debetors_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Debetors_dataGridView.Location = new System.Drawing.Point(3, 16);
            this.Debetors_dataGridView.Name = "Debetors_dataGridView";
            this.Debetors_dataGridView.Size = new System.Drawing.Size(328, 143);
            this.Debetors_dataGridView.TabIndex = 0;
            this.Debetors_dataGridView.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.RowPrePaint);
            // 
            // DebetorsDetails_groupBox
            // 
            this.DebetorsDetails_groupBox.Controls.Add(this.DebetorPhoneNumber_label);
            this.DebetorsDetails_groupBox.Controls.Add(this.DebetorPostNumber_label);
            this.DebetorsDetails_groupBox.Controls.Add(this.DebetorName_label);
            this.DebetorsDetails_groupBox.Controls.Add(this.DebetorID_label);
            this.DebetorsDetails_groupBox.Controls.Add(this.DebetorPhoneNumber_textBox);
            this.DebetorsDetails_groupBox.Controls.Add(this.DebetorPostNumber_textBox);
            this.DebetorsDetails_groupBox.Controls.Add(this.DebetorName_textBox);
            this.DebetorsDetails_groupBox.Controls.Add(this.DebetorID_textBox);
            this.DebetorsDetails_groupBox.Location = new System.Drawing.Point(406, 155);
            this.DebetorsDetails_groupBox.Name = "DebetorsDetails_groupBox";
            this.DebetorsDetails_groupBox.Size = new System.Drawing.Size(798, 162);
            this.DebetorsDetails_groupBox.TabIndex = 1;
            this.DebetorsDetails_groupBox.TabStop = false;
            this.DebetorsDetails_groupBox.Text = "Debetor Details";
            // 
            // DebetorPhoneNumber_label
            // 
            this.DebetorPhoneNumber_label.AutoSize = true;
            this.DebetorPhoneNumber_label.Location = new System.Drawing.Point(57, 128);
            this.DebetorPhoneNumber_label.Name = "DebetorPhoneNumber_label";
            this.DebetorPhoneNumber_label.Size = new System.Drawing.Size(119, 13);
            this.DebetorPhoneNumber_label.TabIndex = 7;
            this.DebetorPhoneNumber_label.Text = "Debetor Phone Number";
            // 
            // DebetorPostNumber_label
            // 
            this.DebetorPostNumber_label.AutoSize = true;
            this.DebetorPostNumber_label.Location = new System.Drawing.Point(57, 94);
            this.DebetorPostNumber_label.Name = "DebetorPostNumber_label";
            this.DebetorPostNumber_label.Size = new System.Drawing.Size(109, 13);
            this.DebetorPostNumber_label.TabIndex = 6;
            this.DebetorPostNumber_label.Text = "Debetor Post Number";
            // 
            // DebetorName_label
            // 
            this.DebetorName_label.AutoSize = true;
            this.DebetorName_label.Location = new System.Drawing.Point(57, 58);
            this.DebetorName_label.Name = "DebetorName_label";
            this.DebetorName_label.Size = new System.Drawing.Size(76, 13);
            this.DebetorName_label.TabIndex = 5;
            this.DebetorName_label.Text = "Debetor Name";
            // 
            // DebetorID_label
            // 
            this.DebetorID_label.AutoSize = true;
            this.DebetorID_label.Location = new System.Drawing.Point(57, 22);
            this.DebetorID_label.Name = "DebetorID_label";
            this.DebetorID_label.Size = new System.Drawing.Size(56, 13);
            this.DebetorID_label.TabIndex = 4;
            this.DebetorID_label.Text = "DebetorID";
            // 
            // DebetorPhoneNumber_textBox
            // 
            this.DebetorPhoneNumber_textBox.BackColor = System.Drawing.SystemColors.Info;
            this.DebetorPhoneNumber_textBox.Location = new System.Drawing.Point(214, 128);
            this.DebetorPhoneNumber_textBox.Name = "DebetorPhoneNumber_textBox";
            this.DebetorPhoneNumber_textBox.ReadOnly = true;
            this.DebetorPhoneNumber_textBox.Size = new System.Drawing.Size(541, 20);
            this.DebetorPhoneNumber_textBox.TabIndex = 3;
            // 
            // DebetorPostNumber_textBox
            // 
            this.DebetorPostNumber_textBox.BackColor = System.Drawing.SystemColors.Info;
            this.DebetorPostNumber_textBox.Location = new System.Drawing.Point(214, 94);
            this.DebetorPostNumber_textBox.Name = "DebetorPostNumber_textBox";
            this.DebetorPostNumber_textBox.ReadOnly = true;
            this.DebetorPostNumber_textBox.Size = new System.Drawing.Size(541, 20);
            this.DebetorPostNumber_textBox.TabIndex = 2;
            // 
            // DebetorName_textBox
            // 
            this.DebetorName_textBox.BackColor = System.Drawing.SystemColors.Info;
            this.DebetorName_textBox.Location = new System.Drawing.Point(214, 55);
            this.DebetorName_textBox.Name = "DebetorName_textBox";
            this.DebetorName_textBox.ReadOnly = true;
            this.DebetorName_textBox.Size = new System.Drawing.Size(541, 20);
            this.DebetorName_textBox.TabIndex = 1;
            // 
            // DebetorID_textBox
            // 
            this.DebetorID_textBox.BackColor = System.Drawing.SystemColors.Info;
            this.DebetorID_textBox.Location = new System.Drawing.Point(214, 19);
            this.DebetorID_textBox.Name = "DebetorID_textBox";
            this.DebetorID_textBox.ReadOnly = true;
            this.DebetorID_textBox.Size = new System.Drawing.Size(541, 20);
            this.DebetorID_textBox.TabIndex = 0;
            // 
            // Credits_groupBox
            // 
            this.Credits_groupBox.Controls.Add(this.Credits_dataGridView);
            this.Credits_groupBox.Location = new System.Drawing.Point(43, 335);
            this.Credits_groupBox.Name = "Credits_groupBox";
            this.Credits_groupBox.Size = new System.Drawing.Size(1212, 180);
            this.Credits_groupBox.TabIndex = 1;
            this.Credits_groupBox.TabStop = false;
            this.Credits_groupBox.Text = "Credits";
            // 
            // Credits_dataGridView
            // 
            this.Credits_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Credits_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Credits_dataGridView.Location = new System.Drawing.Point(3, 16);
            this.Credits_dataGridView.Name = "Credits_dataGridView";
            this.Credits_dataGridView.Size = new System.Drawing.Size(1206, 161);
            this.Credits_dataGridView.TabIndex = 0;
            this.Credits_dataGridView.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.RowPrePaint);
            // 
            // Payments_groupBox
            // 
            this.Payments_groupBox.Controls.Add(this.Payments_dataGridView);
            this.Payments_groupBox.Location = new System.Drawing.Point(43, 532);
            this.Payments_groupBox.Name = "Payments_groupBox";
            this.Payments_groupBox.Size = new System.Drawing.Size(1212, 176);
            this.Payments_groupBox.TabIndex = 1;
            this.Payments_groupBox.TabStop = false;
            this.Payments_groupBox.Text = "Payments";
            // 
            // Payments_dataGridView
            // 
            this.Payments_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Payments_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Payments_dataGridView.Location = new System.Drawing.Point(3, 16);
            this.Payments_dataGridView.Name = "Payments_dataGridView";
            this.Payments_dataGridView.Size = new System.Drawing.Size(1206, 157);
            this.Payments_dataGridView.TabIndex = 0;
            this.Payments_dataGridView.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.RowPrePaint);
            // 
            // Search_groupBox
            // 
            this.Search_groupBox.Controls.Add(this.SearchInDatabase_label);
            this.Search_groupBox.Controls.Add(this.DataBase_checkBox);
            this.Search_groupBox.Controls.Add(this.DebetorPhoneNumberSearched_label);
            this.Search_groupBox.Controls.Add(this.DebetorPostNumberSearched_label);
            this.Search_groupBox.Controls.Add(this.DebetorNameSearched_label);
            this.Search_groupBox.Controls.Add(this.NextRow_button);
            this.Search_groupBox.Controls.Add(this.Search_button);
            this.Search_groupBox.Controls.Add(this.DebetorPhoneNumberSearched_textBox);
            this.Search_groupBox.Controls.Add(this.DebetorPostNumberSearched_textBox);
            this.Search_groupBox.Controls.Add(this.DebetorNameSearched_textBox);
            this.Search_groupBox.Location = new System.Drawing.Point(43, 27);
            this.Search_groupBox.Name = "Search_groupBox";
            this.Search_groupBox.Size = new System.Drawing.Size(743, 122);
            this.Search_groupBox.TabIndex = 3;
            this.Search_groupBox.TabStop = false;
            this.Search_groupBox.Text = "Search";
            // 
            // DebetorPhoneNumberSearched_label
            // 
            this.DebetorPhoneNumberSearched_label.AutoSize = true;
            this.DebetorPhoneNumberSearched_label.Location = new System.Drawing.Point(324, 33);
            this.DebetorPhoneNumberSearched_label.Name = "DebetorPhoneNumberSearched_label";
            this.DebetorPhoneNumberSearched_label.Size = new System.Drawing.Size(78, 13);
            this.DebetorPhoneNumberSearched_label.TabIndex = 7;
            this.DebetorPhoneNumberSearched_label.Text = "Phone Number";
            // 
            // DebetorPostNumberSearched_label
            // 
            this.DebetorPostNumberSearched_label.AutoSize = true;
            this.DebetorPostNumberSearched_label.Location = new System.Drawing.Point(179, 33);
            this.DebetorPostNumberSearched_label.Name = "DebetorPostNumberSearched_label";
            this.DebetorPostNumberSearched_label.Size = new System.Drawing.Size(68, 13);
            this.DebetorPostNumberSearched_label.TabIndex = 6;
            this.DebetorPostNumberSearched_label.Text = "Post Number";
            // 
            // DebetorNameSearched_label
            // 
            this.DebetorNameSearched_label.AutoSize = true;
            this.DebetorNameSearched_label.Location = new System.Drawing.Point(28, 33);
            this.DebetorNameSearched_label.Name = "DebetorNameSearched_label";
            this.DebetorNameSearched_label.Size = new System.Drawing.Size(73, 13);
            this.DebetorNameSearched_label.TabIndex = 5;
            this.DebetorNameSearched_label.Text = "DebetorName";
            // 
            // NextRow_button
            // 
            this.NextRow_button.Location = new System.Drawing.Point(643, 82);
            this.NextRow_button.Name = "NextRow_button";
            this.NextRow_button.Size = new System.Drawing.Size(75, 23);
            this.NextRow_button.TabIndex = 4;
            this.NextRow_button.Text = "Next";
            this.NextRow_button.UseVisualStyleBackColor = true;
            this.NextRow_button.Click += new System.EventHandler(this.NextRow_button_Click);
            // 
            // Search_button
            // 
            this.Search_button.Location = new System.Drawing.Point(562, 82);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(75, 23);
            this.Search_button.TabIndex = 3;
            this.Search_button.Text = "Search";
            this.Search_button.UseVisualStyleBackColor = true;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // DebetorPhoneNumberSearched_textBox
            // 
            this.DebetorPhoneNumberSearched_textBox.Location = new System.Drawing.Point(327, 59);
            this.DebetorPhoneNumberSearched_textBox.Name = "DebetorPhoneNumberSearched_textBox";
            this.DebetorPhoneNumberSearched_textBox.Size = new System.Drawing.Size(129, 20);
            this.DebetorPhoneNumberSearched_textBox.TabIndex = 2;
            // 
            // DebetorPostNumberSearched_textBox
            // 
            this.DebetorPostNumberSearched_textBox.Location = new System.Drawing.Point(177, 59);
            this.DebetorPostNumberSearched_textBox.Name = "DebetorPostNumberSearched_textBox";
            this.DebetorPostNumberSearched_textBox.Size = new System.Drawing.Size(135, 20);
            this.DebetorPostNumberSearched_textBox.TabIndex = 1;
            // 
            // DebetorNameSearched_textBox
            // 
            this.DebetorNameSearched_textBox.Location = new System.Drawing.Point(31, 59);
            this.DebetorNameSearched_textBox.Name = "DebetorNameSearched_textBox";
            this.DebetorNameSearched_textBox.Size = new System.Drawing.Size(125, 20);
            this.DebetorNameSearched_textBox.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.debetorToolStripMenuItem,
            this.creditToolStripMenuItem,
            this.paymentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1292, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveDataToSToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // saveDataToSToolStripMenuItem
            // 
            this.saveDataToSToolStripMenuItem.Name = "saveDataToSToolStripMenuItem";
            this.saveDataToSToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.saveDataToSToolStripMenuItem.Text = "&Save data to CSV";
            this.saveDataToSToolStripMenuItem.Click += new System.EventHandler(this.saveDataToSToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // debetorToolStripMenuItem
            // 
            this.debetorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewDebetorToolStripMenuItem});
            this.debetorToolStripMenuItem.Name = "debetorToolStripMenuItem";
            this.debetorToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.debetorToolStripMenuItem.Text = "&Debetor";
            // 
            // addNewDebetorToolStripMenuItem
            // 
            this.addNewDebetorToolStripMenuItem.Name = "addNewDebetorToolStripMenuItem";
            this.addNewDebetorToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.addNewDebetorToolStripMenuItem.Text = "&Add new debetor";
            this.addNewDebetorToolStripMenuItem.Click += new System.EventHandler(this.addNewDebetorToolStripMenuItem_Click);
            // 
            // creditToolStripMenuItem
            // 
            this.creditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openNewCreditToolStripMenuItem});
            this.creditToolStripMenuItem.Name = "creditToolStripMenuItem";
            this.creditToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.creditToolStripMenuItem.Text = "&Credit";
            // 
            // openNewCreditToolStripMenuItem
            // 
            this.openNewCreditToolStripMenuItem.Name = "openNewCreditToolStripMenuItem";
            this.openNewCreditToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.openNewCreditToolStripMenuItem.Text = "&Open new credit";
            this.openNewCreditToolStripMenuItem.Click += new System.EventHandler(this.openNewCreditToolStripMenuItem_Click);
            // 
            // paymentToolStripMenuItem
            // 
            this.paymentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.passNewPaymentToolStripMenuItem});
            this.paymentToolStripMenuItem.Name = "paymentToolStripMenuItem";
            this.paymentToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.paymentToolStripMenuItem.Text = "&Payment";
            // 
            // passNewPaymentToolStripMenuItem
            // 
            this.passNewPaymentToolStripMenuItem.Name = "passNewPaymentToolStripMenuItem";
            this.passNewPaymentToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.passNewPaymentToolStripMenuItem.Text = "&Pass new payment";
            this.passNewPaymentToolStripMenuItem.Click += new System.EventHandler(this.passNewPaymentToolStripMenuItem_Click);
            // 
            // DataBase_checkBox
            // 
            this.DataBase_checkBox.AutoSize = true;
            this.DataBase_checkBox.Location = new System.Drawing.Point(479, 62);
            this.DataBase_checkBox.Name = "DataBase_checkBox";
            this.DataBase_checkBox.Size = new System.Drawing.Size(15, 14);
            this.DataBase_checkBox.TabIndex = 8;
            this.DataBase_checkBox.UseVisualStyleBackColor = true;
            // 
            // SearchInDatabase_label
            // 
            this.SearchInDatabase_label.AutoSize = true;
            this.SearchInDatabase_label.Location = new System.Drawing.Point(459, 33);
            this.SearchInDatabase_label.Name = "SearchInDatabase_label";
            this.SearchInDatabase_label.Size = new System.Drawing.Size(101, 13);
            this.SearchInDatabase_label.TabIndex = 9;
            this.SearchInDatabase_label.Text = "Search in Database";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 733);
            this.Controls.Add(this.Search_groupBox);
            this.Controls.Add(this.Credits_groupBox);
            this.Controls.Add(this.Payments_groupBox);
            this.Controls.Add(this.DebetorsDetails_groupBox);
            this.Controls.Add(this.Debetors_groupBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Debetors_groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Debetors_dataGridView)).EndInit();
            this.DebetorsDetails_groupBox.ResumeLayout(false);
            this.DebetorsDetails_groupBox.PerformLayout();
            this.Credits_groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Credits_dataGridView)).EndInit();
            this.Payments_groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Payments_dataGridView)).EndInit();
            this.Search_groupBox.ResumeLayout(false);
            this.Search_groupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Debetors_groupBox;
        private System.Windows.Forms.GroupBox DebetorsDetails_groupBox;
        private System.Windows.Forms.GroupBox Credits_groupBox;
        private System.Windows.Forms.GroupBox Payments_groupBox;
        private System.Windows.Forms.DataGridView Debetors_dataGridView;
        private System.Windows.Forms.Label DebetorPhoneNumber_label;
        private System.Windows.Forms.Label DebetorPostNumber_label;
        private System.Windows.Forms.Label DebetorName_label;
        private System.Windows.Forms.Label DebetorID_label;
        private System.Windows.Forms.TextBox DebetorPhoneNumber_textBox;
        private System.Windows.Forms.TextBox DebetorPostNumber_textBox;
        private System.Windows.Forms.TextBox DebetorName_textBox;
        private System.Windows.Forms.TextBox DebetorID_textBox;
        private System.Windows.Forms.DataGridView Credits_dataGridView;
        private System.Windows.Forms.DataGridView Payments_dataGridView;
        private System.Windows.Forms.GroupBox Search_groupBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDataToSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debetorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewDebetorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openNewCreditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passNewPaymentToolStripMenuItem;
        private System.Windows.Forms.Label DebetorPhoneNumberSearched_label;
        private System.Windows.Forms.Label DebetorPostNumberSearched_label;
        private System.Windows.Forms.Label DebetorNameSearched_label;
        private System.Windows.Forms.Button NextRow_button;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.TextBox DebetorPhoneNumberSearched_textBox;
        private System.Windows.Forms.TextBox DebetorPostNumberSearched_textBox;
        private System.Windows.Forms.TextBox DebetorNameSearched_textBox;
        private System.Windows.Forms.Label SearchInDatabase_label;
        private System.Windows.Forms.CheckBox DataBase_checkBox;
    }
}

