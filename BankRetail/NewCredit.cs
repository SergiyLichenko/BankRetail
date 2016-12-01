using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace BankRetail
{
    public partial class NewCredit : Form
    {
        DataTable allDebetors;
        DAL dal = new DAL();
        public NewCredit()
        {
            InitializeComponent();

            allDebetors = dal.GetAllDebetors();
            if (allDebetors == null || allDebetors.Rows.Count == 0)
                this.CreditBalance_textBox.Enabled = this.CreditAmount_textBox.Enabled =
                    this.OpenNewCredit_button.Enabled = false;
            this.OpenNewCredit_button.Enabled = false;
            DebitorID_listBox.DataSource = allDebetors;
            DebitorName_listBox.DataSource = allDebetors;

        }

        private void CreditAmount_textBox_TextChanged(object sender, EventArgs e)
        {
            CreditBalance_textBox.Text = CreditAmount_textBox.Text;
        }

        private void OpenNewCredit_button_Click(object sender, EventArgs e)
        {
            if (dal.SaveNewCredit(Convert.ToInt32(CreditID_textBox.Text), Convert.ToInt32(DebitorID_listBox.SelectedValue.ToString()),
                Convert.ToInt32(CreditAmount_textBox.Text), Convert.ToInt32(CreditBalance_textBox.Text), CreditOpenDate_dateTimePicker.Text))
                this.DialogResult = DialogResult.OK;
            else
                this.DialogResult = DialogResult.No;
        }

        private void CreditBalance_textBox_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(CreditID_textBox.Text) && !String.IsNullOrEmpty(CreditBalance_textBox.Text))
                this.OpenNewCredit_button.Enabled = true;
            else
                this.OpenNewCredit_button.Enabled = false;
        }

        private void CreditID_textBox_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(CreditID_textBox.Text) && !String.IsNullOrEmpty(CreditBalance_textBox.Text))
                this.OpenNewCredit_button.Enabled = true;
            else
                this.OpenNewCredit_button.Enabled = false;
        }

        private void CreditAmount_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57)&& e.KeyChar!=8)
                e.Handled = true;
        }

        private void CreditAmount_textBox_Leave(object sender, EventArgs e)
        {
            if (CreditAmount_textBox.Text == String.Empty || Int64.Parse(CreditAmount_textBox.Text.Trim()) < 100 || Int64.Parse(CreditAmount_textBox.Text.Trim()) > 100000000)
            {
                MessageCreditAmount_label.Text = "Недопустимое значение суммы кредита";
                MessageCreditAmount_label.ForeColor = Color.Red;
                OpenNewCredit_button.Enabled = false;
            }
            else
            {
                MessageCreditAmount_label.Text = "Сумма допустима";
                MessageCreditAmount_label.ForeColor = Color.Green;
                OpenNewCredit_button.Enabled = true;
            }

        }
    }
}
