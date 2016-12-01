namespace BankRetail
{
    partial class NewCredit
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
            this.OpenNewCredit_button = new System.Windows.Forms.Button();
            this.DebetorsDetails_groupBox = new System.Windows.Forms.GroupBox();
            this.MessageCreditAmount_label = new System.Windows.Forms.Label();
            this.CreditBalance_label = new System.Windows.Forms.Label();
            this.CreditBalance_textBox = new System.Windows.Forms.TextBox();
            this.Date_label = new System.Windows.Forms.Label();
            this.CreditOpenDate_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DebitorName_listBox = new System.Windows.Forms.ListBox();
            this.DebitorID_listBox = new System.Windows.Forms.ListBox();
            this.Amount_label = new System.Windows.Forms.Label();
            this.Debetor_label = new System.Windows.Forms.Label();
            this.CreditID_label = new System.Windows.Forms.Label();
            this.CreditAmount_textBox = new System.Windows.Forms.TextBox();
            this.CreditID_textBox = new System.Windows.Forms.TextBox();
            this.DebetorsDetails_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenNewCredit_button
            // 
            this.OpenNewCredit_button.Location = new System.Drawing.Point(340, 239);
            this.OpenNewCredit_button.Name = "OpenNewCredit_button";
            this.OpenNewCredit_button.Size = new System.Drawing.Size(108, 34);
            this.OpenNewCredit_button.TabIndex = 5;
            this.OpenNewCredit_button.Text = "Open New Credit";
            this.OpenNewCredit_button.UseVisualStyleBackColor = true;
            this.OpenNewCredit_button.Click += new System.EventHandler(this.OpenNewCredit_button_Click);
            // 
            // DebetorsDetails_groupBox
            // 
            this.DebetorsDetails_groupBox.Controls.Add(this.MessageCreditAmount_label);
            this.DebetorsDetails_groupBox.Controls.Add(this.CreditBalance_label);
            this.DebetorsDetails_groupBox.Controls.Add(this.CreditBalance_textBox);
            this.DebetorsDetails_groupBox.Controls.Add(this.Date_label);
            this.DebetorsDetails_groupBox.Controls.Add(this.CreditOpenDate_dateTimePicker);
            this.DebetorsDetails_groupBox.Controls.Add(this.DebitorName_listBox);
            this.DebetorsDetails_groupBox.Controls.Add(this.OpenNewCredit_button);
            this.DebetorsDetails_groupBox.Controls.Add(this.DebitorID_listBox);
            this.DebetorsDetails_groupBox.Controls.Add(this.Amount_label);
            this.DebetorsDetails_groupBox.Controls.Add(this.Debetor_label);
            this.DebetorsDetails_groupBox.Controls.Add(this.CreditID_label);
            this.DebetorsDetails_groupBox.Controls.Add(this.CreditAmount_textBox);
            this.DebetorsDetails_groupBox.Controls.Add(this.CreditID_textBox);
            this.DebetorsDetails_groupBox.Location = new System.Drawing.Point(28, 22);
            this.DebetorsDetails_groupBox.Name = "DebetorsDetails_groupBox";
            this.DebetorsDetails_groupBox.Size = new System.Drawing.Size(798, 289);
            this.DebetorsDetails_groupBox.TabIndex = 4;
            this.DebetorsDetails_groupBox.TabStop = false;
            this.DebetorsDetails_groupBox.Text = "Debetor Details";
            // 
            // MessageCreditAmount_label
            // 
            this.MessageCreditAmount_label.AutoSize = true;
            this.MessageCreditAmount_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MessageCreditAmount_label.Location = new System.Drawing.Point(497, 139);
            this.MessageCreditAmount_label.Name = "MessageCreditAmount_label";
            this.MessageCreditAmount_label.Size = new System.Drawing.Size(0, 17);
            this.MessageCreditAmount_label.TabIndex = 13;
            // 
            // CreditBalance_label
            // 
            this.CreditBalance_label.AutoSize = true;
            this.CreditBalance_label.Location = new System.Drawing.Point(67, 206);
            this.CreditBalance_label.Name = "CreditBalance_label";
            this.CreditBalance_label.Size = new System.Drawing.Size(76, 13);
            this.CreditBalance_label.TabIndex = 12;
            this.CreditBalance_label.Text = "Credit Balance";
            // 
            // CreditBalance_textBox
            // 
            this.CreditBalance_textBox.BackColor = System.Drawing.SystemColors.Info;
            this.CreditBalance_textBox.Location = new System.Drawing.Point(214, 206);
            this.CreditBalance_textBox.Name = "CreditBalance_textBox";
            this.CreditBalance_textBox.ReadOnly = true;
            this.CreditBalance_textBox.Size = new System.Drawing.Size(541, 20);
            this.CreditBalance_textBox.TabIndex = 11;
            this.CreditBalance_textBox.TextChanged += new System.EventHandler(this.CreditBalance_textBox_TextChanged);
            // 
            // Date_label
            // 
            this.Date_label.AutoSize = true;
            this.Date_label.Location = new System.Drawing.Point(67, 172);
            this.Date_label.Name = "Date_label";
            this.Date_label.Size = new System.Drawing.Size(30, 13);
            this.Date_label.TabIndex = 10;
            this.Date_label.Text = "Date";
            // 
            // CreditOpenDate_dateTimePicker
            // 
            this.CreditOpenDate_dateTimePicker.CustomFormat = "yyyy--MM--dd";
            this.CreditOpenDate_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CreditOpenDate_dateTimePicker.Location = new System.Drawing.Point(214, 172);
            this.CreditOpenDate_dateTimePicker.Name = "CreditOpenDate_dateTimePicker";
            this.CreditOpenDate_dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.CreditOpenDate_dateTimePicker.TabIndex = 6;
            // 
            // DebitorName_listBox
            // 
            this.DebitorName_listBox.DisplayMember = "Name";
            this.DebitorName_listBox.FormattingEnabled = true;
            this.DebitorName_listBox.Location = new System.Drawing.Point(500, 46);
            this.DebitorName_listBox.Name = "DebitorName_listBox";
            this.DebitorName_listBox.Size = new System.Drawing.Size(255, 82);
            this.DebitorName_listBox.TabIndex = 9;
            this.DebitorName_listBox.ValueMember = "ID";
            // 
            // DebitorID_listBox
            // 
            this.DebitorID_listBox.DisplayMember = "ID";
            this.DebitorID_listBox.FormattingEnabled = true;
            this.DebitorID_listBox.Location = new System.Drawing.Point(214, 46);
            this.DebitorID_listBox.Name = "DebitorID_listBox";
            this.DebitorID_listBox.Size = new System.Drawing.Size(234, 82);
            this.DebitorID_listBox.TabIndex = 8;
            this.DebitorID_listBox.ValueMember = "ID";
            // 
            // Amount_label
            // 
            this.Amount_label.AutoSize = true;
            this.Amount_label.Location = new System.Drawing.Point(67, 138);
            this.Amount_label.Name = "Amount_label";
            this.Amount_label.Size = new System.Drawing.Size(73, 13);
            this.Amount_label.TabIndex = 6;
            this.Amount_label.Text = "Credit Amount";
            // 
            // Debetor_label
            // 
            this.Debetor_label.AutoSize = true;
            this.Debetor_label.Location = new System.Drawing.Point(67, 58);
            this.Debetor_label.Name = "Debetor_label";
            this.Debetor_label.Size = new System.Drawing.Size(45, 13);
            this.Debetor_label.TabIndex = 5;
            this.Debetor_label.Text = "Debetor";
            // 
            // CreditID_label
            // 
            this.CreditID_label.AutoSize = true;
            this.CreditID_label.Location = new System.Drawing.Point(67, 22);
            this.CreditID_label.Name = "CreditID_label";
            this.CreditID_label.Size = new System.Drawing.Size(45, 13);
            this.CreditID_label.TabIndex = 4;
            this.CreditID_label.Text = "CreditID";
            // 
            // CreditAmount_textBox
            // 
            this.CreditAmount_textBox.BackColor = System.Drawing.SystemColors.Info;
            this.CreditAmount_textBox.Location = new System.Drawing.Point(214, 138);
            this.CreditAmount_textBox.MaxLength = 8;
            this.CreditAmount_textBox.Name = "CreditAmount_textBox";
            this.CreditAmount_textBox.Size = new System.Drawing.Size(259, 20);
            this.CreditAmount_textBox.TabIndex = 2;
            this.CreditAmount_textBox.TextChanged += new System.EventHandler(this.CreditAmount_textBox_TextChanged);
            this.CreditAmount_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CreditAmount_textBox_KeyPress);
            this.CreditAmount_textBox.Leave += new System.EventHandler(this.CreditAmount_textBox_Leave);
            // 
            // CreditID_textBox
            // 
            this.CreditID_textBox.BackColor = System.Drawing.SystemColors.Info;
            this.CreditID_textBox.Location = new System.Drawing.Point(214, 19);
            this.CreditID_textBox.Name = "CreditID_textBox";
            this.CreditID_textBox.Size = new System.Drawing.Size(541, 20);
            this.CreditID_textBox.TabIndex = 0;
            this.CreditID_textBox.TextChanged += new System.EventHandler(this.CreditID_textBox_TextChanged);
            // 
            // NewCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 323);
            this.Controls.Add(this.DebetorsDetails_groupBox);
            this.Name = "NewCredit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewCredit";
            this.DebetorsDetails_groupBox.ResumeLayout(false);
            this.DebetorsDetails_groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OpenNewCredit_button;
        private System.Windows.Forms.GroupBox DebetorsDetails_groupBox;
        private System.Windows.Forms.ListBox DebitorID_listBox;
        private System.Windows.Forms.Label Amount_label;
        private System.Windows.Forms.Label Debetor_label;
        private System.Windows.Forms.Label CreditID_label;
        private System.Windows.Forms.TextBox CreditAmount_textBox;
        private System.Windows.Forms.TextBox CreditID_textBox;
        private System.Windows.Forms.ListBox DebitorName_listBox;
        private System.Windows.Forms.Label Date_label;
        private System.Windows.Forms.DateTimePicker CreditOpenDate_dateTimePicker;
        private System.Windows.Forms.Label CreditBalance_label;
        private System.Windows.Forms.TextBox CreditBalance_textBox;
        private System.Windows.Forms.Label MessageCreditAmount_label;
    }
}