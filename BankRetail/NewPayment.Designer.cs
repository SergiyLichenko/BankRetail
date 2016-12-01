namespace BankRetail
{
    partial class NewPayment
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
            this.DebetorsDetails_groupBox = new System.Windows.Forms.GroupBox();
            this.Refresh_button = new System.Windows.Forms.Button();
            this.DName_label = new System.Windows.Forms.Label();
            this.DebetorName_label = new System.Windows.Forms.Label();
            this.CIAmount_label = new System.Windows.Forms.Label();
            this.CIBalance_label = new System.Windows.Forms.Label();
            this.CI_label = new System.Windows.Forms.Label();
            this.State_label = new System.Windows.Forms.Label();
            this.CreditBalance_listBox = new System.Windows.Forms.ListBox();
            this.CreditAmount_listBox = new System.Windows.Forms.ListBox();
            this.CreditID_listBox = new System.Windows.Forms.ListBox();
            this.Credit_label = new System.Windows.Forms.Label();
            this.MessageCreditAmount_label = new System.Windows.Forms.Label();
            this.Date_label = new System.Windows.Forms.Label();
            this.PaymentDate_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DebitorName_listBox = new System.Windows.Forms.ListBox();
            this.SaveNewPayment_button = new System.Windows.Forms.Button();
            this.DebitorID_listBox = new System.Windows.Forms.ListBox();
            this.Amount_label = new System.Windows.Forms.Label();
            this.Debetor_label = new System.Windows.Forms.Label();
            this.CreditID_label = new System.Windows.Forms.Label();
            this.PaymentAmount_textBox = new System.Windows.Forms.TextBox();
            this.CreditID_textBox = new System.Windows.Forms.TextBox();
            this.DebetorsDetails_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // DebetorsDetails_groupBox
            // 
            this.DebetorsDetails_groupBox.Controls.Add(this.Refresh_button);
            this.DebetorsDetails_groupBox.Controls.Add(this.DName_label);
            this.DebetorsDetails_groupBox.Controls.Add(this.DebetorName_label);
            this.DebetorsDetails_groupBox.Controls.Add(this.CIAmount_label);
            this.DebetorsDetails_groupBox.Controls.Add(this.CIBalance_label);
            this.DebetorsDetails_groupBox.Controls.Add(this.CI_label);
            this.DebetorsDetails_groupBox.Controls.Add(this.State_label);
            this.DebetorsDetails_groupBox.Controls.Add(this.CreditBalance_listBox);
            this.DebetorsDetails_groupBox.Controls.Add(this.CreditAmount_listBox);
            this.DebetorsDetails_groupBox.Controls.Add(this.CreditID_listBox);
            this.DebetorsDetails_groupBox.Controls.Add(this.Credit_label);
            this.DebetorsDetails_groupBox.Controls.Add(this.MessageCreditAmount_label);
            this.DebetorsDetails_groupBox.Controls.Add(this.Date_label);
            this.DebetorsDetails_groupBox.Controls.Add(this.PaymentDate_dateTimePicker);
            this.DebetorsDetails_groupBox.Controls.Add(this.DebitorName_listBox);
            this.DebetorsDetails_groupBox.Controls.Add(this.SaveNewPayment_button);
            this.DebetorsDetails_groupBox.Controls.Add(this.DebitorID_listBox);
            this.DebetorsDetails_groupBox.Controls.Add(this.Amount_label);
            this.DebetorsDetails_groupBox.Controls.Add(this.Debetor_label);
            this.DebetorsDetails_groupBox.Controls.Add(this.CreditID_label);
            this.DebetorsDetails_groupBox.Controls.Add(this.PaymentAmount_textBox);
            this.DebetorsDetails_groupBox.Controls.Add(this.CreditID_textBox);
            this.DebetorsDetails_groupBox.Location = new System.Drawing.Point(12, 22);
            this.DebetorsDetails_groupBox.Name = "DebetorsDetails_groupBox";
            this.DebetorsDetails_groupBox.Size = new System.Drawing.Size(767, 436);
            this.DebetorsDetails_groupBox.TabIndex = 5;
            this.DebetorsDetails_groupBox.TabStop = false;
            this.DebetorsDetails_groupBox.Text = "Debetor Details";
            // 
            // Refresh_button
            // 
            this.Refresh_button.Location = new System.Drawing.Point(451, 284);
            this.Refresh_button.Name = "Refresh_button";
            this.Refresh_button.Size = new System.Drawing.Size(75, 23);
            this.Refresh_button.TabIndex = 24;
            this.Refresh_button.Text = "Refresh";
            this.Refresh_button.UseVisualStyleBackColor = true;
            this.Refresh_button.Click += new System.EventHandler(this.Refresh_button_Click);
            // 
            // DName_label
            // 
            this.DName_label.AutoSize = true;
            this.DName_label.Location = new System.Drawing.Point(455, 50);
            this.DName_label.Name = "DName_label";
            this.DName_label.Size = new System.Drawing.Size(35, 13);
            this.DName_label.TabIndex = 23;
            this.DName_label.Text = "Name";
            // 
            // DebetorName_label
            // 
            this.DebetorName_label.AutoSize = true;
            this.DebetorName_label.Location = new System.Drawing.Point(169, 50);
            this.DebetorName_label.Name = "DebetorName_label";
            this.DebetorName_label.Size = new System.Drawing.Size(18, 13);
            this.DebetorName_label.TabIndex = 22;
            this.DebetorName_label.Text = "ID";
            // 
            // CIAmount_label
            // 
            this.CIAmount_label.AutoSize = true;
            this.CIAmount_label.Location = new System.Drawing.Point(357, 161);
            this.CIAmount_label.Name = "CIAmount_label";
            this.CIAmount_label.Size = new System.Drawing.Size(52, 13);
            this.CIAmount_label.TabIndex = 21;
            this.CIAmount_label.Text = "Amount $";
            // 
            // CIBalance_label
            // 
            this.CIBalance_label.AutoSize = true;
            this.CIBalance_label.Location = new System.Drawing.Point(558, 161);
            this.CIBalance_label.Name = "CIBalance_label";
            this.CIBalance_label.Size = new System.Drawing.Size(55, 13);
            this.CIBalance_label.TabIndex = 20;
            this.CIBalance_label.Text = "Balance $";
            // 
            // CI_label
            // 
            this.CI_label.AutoSize = true;
            this.CI_label.Location = new System.Drawing.Point(169, 161);
            this.CI_label.Name = "CI_label";
            this.CI_label.Size = new System.Drawing.Size(45, 13);
            this.CI_label.TabIndex = 19;
            this.CI_label.Text = "CreditID";
            // 
            // State_label
            // 
            this.State_label.AutoSize = true;
            this.State_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.State_label.ForeColor = System.Drawing.Color.Teal;
            this.State_label.Location = new System.Drawing.Point(549, 288);
            this.State_label.Name = "State_label";
            this.State_label.Size = new System.Drawing.Size(106, 17);
            this.State_label.TabIndex = 18;
            this.State_label.Text = "Введите сумму";
            // 
            // CreditBalance_listBox
            // 
            this.CreditBalance_listBox.DisplayMember = "Balance";
            this.CreditBalance_listBox.FormattingEnabled = true;
            this.CreditBalance_listBox.Location = new System.Drawing.Point(561, 177);
            this.CreditBalance_listBox.Name = "CreditBalance_listBox";
            this.CreditBalance_listBox.Size = new System.Drawing.Size(152, 82);
            this.CreditBalance_listBox.TabIndex = 17;
            this.CreditBalance_listBox.ValueMember = "Balance";
            // 
            // CreditAmount_listBox
            // 
            this.CreditAmount_listBox.DisplayMember = "Amount";
            this.CreditAmount_listBox.FormattingEnabled = true;
            this.CreditAmount_listBox.Location = new System.Drawing.Point(360, 177);
            this.CreditAmount_listBox.Name = "CreditAmount_listBox";
            this.CreditAmount_listBox.Size = new System.Drawing.Size(152, 82);
            this.CreditAmount_listBox.TabIndex = 16;
            this.CreditAmount_listBox.ValueMember = "ID";
            // 
            // CreditID_listBox
            // 
            this.CreditID_listBox.DisplayMember = "ID";
            this.CreditID_listBox.FormattingEnabled = true;
            this.CreditID_listBox.Location = new System.Drawing.Point(171, 177);
            this.CreditID_listBox.Name = "CreditID_listBox";
            this.CreditID_listBox.Size = new System.Drawing.Size(141, 82);
            this.CreditID_listBox.TabIndex = 15;
            this.CreditID_listBox.ValueMember = "ID";
            // 
            // Credit_label
            // 
            this.Credit_label.AutoSize = true;
            this.Credit_label.Location = new System.Drawing.Point(24, 189);
            this.Credit_label.Name = "Credit_label";
            this.Credit_label.Size = new System.Drawing.Size(34, 13);
            this.Credit_label.TabIndex = 14;
            this.Credit_label.Text = "Credit";
            // 
            // MessageCreditAmount_label
            // 
            this.MessageCreditAmount_label.AutoSize = true;
            this.MessageCreditAmount_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MessageCreditAmount_label.Location = new System.Drawing.Point(455, 299);
            this.MessageCreditAmount_label.Name = "MessageCreditAmount_label";
            this.MessageCreditAmount_label.Size = new System.Drawing.Size(0, 17);
            this.MessageCreditAmount_label.TabIndex = 13;
            // 
            // Date_label
            // 
            this.Date_label.AutoSize = true;
            this.Date_label.Location = new System.Drawing.Point(25, 321);
            this.Date_label.Name = "Date_label";
            this.Date_label.Size = new System.Drawing.Size(30, 13);
            this.Date_label.TabIndex = 10;
            this.Date_label.Text = "Date";
            // 
            // PaymentDate_dateTimePicker
            // 
            this.PaymentDate_dateTimePicker.CustomFormat = "yyyy--MM--dd";
            this.PaymentDate_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.PaymentDate_dateTimePicker.Location = new System.Drawing.Point(172, 321);
            this.PaymentDate_dateTimePicker.Name = "PaymentDate_dateTimePicker";
            this.PaymentDate_dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.PaymentDate_dateTimePicker.TabIndex = 6;
            // 
            // DebitorName_listBox
            // 
            this.DebitorName_listBox.DisplayMember = "Name";
            this.DebitorName_listBox.FormattingEnabled = true;
            this.DebitorName_listBox.Location = new System.Drawing.Point(458, 66);
            this.DebitorName_listBox.Name = "DebitorName_listBox";
            this.DebitorName_listBox.Size = new System.Drawing.Size(255, 82);
            this.DebitorName_listBox.TabIndex = 9;
            this.DebitorName_listBox.ValueMember = "ID";
            // 
            // SaveNewPayment_button
            // 
            this.SaveNewPayment_button.Location = new System.Drawing.Point(294, 376);
            this.SaveNewPayment_button.Name = "SaveNewPayment_button";
            this.SaveNewPayment_button.Size = new System.Drawing.Size(121, 41);
            this.SaveNewPayment_button.TabIndex = 5;
            this.SaveNewPayment_button.Text = "Save New Payment";
            this.SaveNewPayment_button.UseVisualStyleBackColor = true;
            this.SaveNewPayment_button.Click += new System.EventHandler(this.SaveNewPayment_button_Click);
            // 
            // DebitorID_listBox
            // 
            this.DebitorID_listBox.DisplayMember = "ID";
            this.DebitorID_listBox.FormattingEnabled = true;
            this.DebitorID_listBox.Location = new System.Drawing.Point(172, 66);
            this.DebitorID_listBox.Name = "DebitorID_listBox";
            this.DebitorID_listBox.Size = new System.Drawing.Size(234, 82);
            this.DebitorID_listBox.TabIndex = 8;
            this.DebitorID_listBox.ValueMember = "ID";
            this.DebitorID_listBox.SelectedIndexChanged += new System.EventHandler(this.DebitorID_listBox_SelectedIndexChanged);
            // 
            // Amount_label
            // 
            this.Amount_label.AutoSize = true;
            this.Amount_label.Location = new System.Drawing.Point(25, 286);
            this.Amount_label.Name = "Amount_label";
            this.Amount_label.Size = new System.Drawing.Size(87, 13);
            this.Amount_label.TabIndex = 6;
            this.Amount_label.Text = "Payment Amount";
            // 
            // Debetor_label
            // 
            this.Debetor_label.AutoSize = true;
            this.Debetor_label.Location = new System.Drawing.Point(25, 78);
            this.Debetor_label.Name = "Debetor_label";
            this.Debetor_label.Size = new System.Drawing.Size(45, 13);
            this.Debetor_label.TabIndex = 5;
            this.Debetor_label.Text = "Debetor";
            // 
            // CreditID_label
            // 
            this.CreditID_label.AutoSize = true;
            this.CreditID_label.Location = new System.Drawing.Point(25, 25);
            this.CreditID_label.Name = "CreditID_label";
            this.CreditID_label.Size = new System.Drawing.Size(59, 13);
            this.CreditID_label.TabIndex = 4;
            this.CreditID_label.Text = "PaymentID";
            // 
            // PaymentAmount_textBox
            // 
            this.PaymentAmount_textBox.BackColor = System.Drawing.SystemColors.Info;
            this.PaymentAmount_textBox.Location = new System.Drawing.Point(172, 286);
            this.PaymentAmount_textBox.MaxLength = 12;
            this.PaymentAmount_textBox.Name = "PaymentAmount_textBox";
            this.PaymentAmount_textBox.Size = new System.Drawing.Size(259, 20);
            this.PaymentAmount_textBox.TabIndex = 2;
            this.PaymentAmount_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PaymentAmount_textBox_KeyPress);
            this.PaymentAmount_textBox.Leave += new System.EventHandler(this.PaymentAmount_textBox_Leave);
            // 
            // CreditID_textBox
            // 
            this.CreditID_textBox.BackColor = System.Drawing.SystemColors.Info;
            this.CreditID_textBox.Location = new System.Drawing.Point(172, 22);
            this.CreditID_textBox.Name = "CreditID_textBox";
            this.CreditID_textBox.Size = new System.Drawing.Size(541, 20);
            this.CreditID_textBox.TabIndex = 0;
            // 
            // NewPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 479);
            this.Controls.Add(this.DebetorsDetails_groupBox);
            this.Name = "NewPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewPayment";
            this.DebetorsDetails_groupBox.ResumeLayout(false);
            this.DebetorsDetails_groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox DebetorsDetails_groupBox;
        private System.Windows.Forms.Label State_label;
        private System.Windows.Forms.ListBox CreditBalance_listBox;
        private System.Windows.Forms.ListBox CreditAmount_listBox;
        private System.Windows.Forms.ListBox CreditID_listBox;
        private System.Windows.Forms.Label Credit_label;
        private System.Windows.Forms.Label MessageCreditAmount_label;
        private System.Windows.Forms.Label Date_label;
        private System.Windows.Forms.DateTimePicker PaymentDate_dateTimePicker;
        private System.Windows.Forms.ListBox DebitorName_listBox;
        private System.Windows.Forms.Button SaveNewPayment_button;
        private System.Windows.Forms.ListBox DebitorID_listBox;
        private System.Windows.Forms.Label Amount_label;
        private System.Windows.Forms.Label Debetor_label;
        private System.Windows.Forms.Label CreditID_label;
        private System.Windows.Forms.TextBox PaymentAmount_textBox;
        private System.Windows.Forms.TextBox CreditID_textBox;
        private System.Windows.Forms.Label CIAmount_label;
        private System.Windows.Forms.Label CIBalance_label;
        private System.Windows.Forms.Label CI_label;
        private System.Windows.Forms.Label DName_label;
        private System.Windows.Forms.Label DebetorName_label;
        private System.Windows.Forms.Button Refresh_button;
    }
}