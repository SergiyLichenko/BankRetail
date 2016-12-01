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
    public partial class NewPayment : Form
    {
        DAL dal = new DAL();
        DataTable allDebetors;
        DataTable allCredits;
        public NewPayment()
        {
            InitializeComponent();

            allDebetors = dal.GetAllDebetors();
            if (allDebetors == null || allDebetors.Rows.Count == 0)
            {
                SaveNewPayment_button.Enabled = false;
                PaymentAmount_textBox.Enabled = false;
            }
            else
            {
                SaveNewPayment_button.Enabled = true;
                PaymentAmount_textBox.Enabled = true;
            }

            DebitorID_listBox.DataSource = allDebetors;
            DebitorName_listBox.DataSource = allDebetors;

            

        }

        private void DebitorID_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            allCredits = dal.GetAllCreditsForDebetor(DebitorID_listBox.SelectedValue.ToString());
            CreditID_listBox.DataSource = allCredits;
            CreditAmount_listBox.DataSource = allCredits;
            CreditBalance_listBox.DataSource = allCredits;

            if(allCredits==null || allCredits.Rows.Count==0)
            {
                SaveNewPayment_button.Enabled = false;
                PaymentAmount_textBox.Enabled = false;
                State_label.Text = "Нет кредитов";
            }
            else
            {
                SaveNewPayment_button.Enabled = true;
                PaymentAmount_textBox.Enabled = true;
                State_label.Text = "Введите сумму";
            }
            CreditID_listBox.DisplayMember = "ID";
            CreditID_listBox.ValueMember = "ID";
            CreditAmount_listBox.DisplayMember = "Amount";
            CreditAmount_listBox.ValueMember = "ID";
            CreditBalance_listBox.DisplayMember = "Balance";
            CreditBalance_listBox.ValueMember = "Balance";

        }

        private void PaymentAmount_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',')
                if (PaymentAmount_textBox.Text.Trim().Contains(',') || PaymentAmount_textBox.Text == String.Empty)
                {
                    e.Handled = true;
                    return;
                }
                else
                {
                    e.Handled = false;
                    return;
                }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }
            short res;
            if (Int16.TryParse(e.KeyChar.ToString(), out res))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void PaymentAmount_textBox_Leave(object sender, EventArgs e)
        {
            if (PaymentAmount_textBox.Text.Trim() == String.Empty)
            {
                State_label.ForeColor = Color.Red;
                State_label.Text = "Сумма платежа не введена";
                SaveNewPayment_button.Enabled = false;
                return;
            }
            decimal payValue = Decimal.Parse(PaymentAmount_textBox.Text.Trim());
            if(payValue<10 || payValue>Decimal.Parse(CreditBalance_listBox.SelectedValue.ToString()))
            {
                State_label.ForeColor = Color.Red;
                State_label.Text = "Неверная сумма платежа";
                SaveNewPayment_button.Enabled = false;
            }
            else
            {
                State_label.ForeColor = Color.Green;
                State_label.Text = "Доступная сумма платежа";
                SaveNewPayment_button.Enabled = true;
            }
        }

        private void Refresh_button_Click(object sender, EventArgs e)
        {
            PaymentAmount_textBox.Text = String.Empty;
            State_label.ForeColor = Color.Red;
            State_label.Text = "Сумма платежа не введена";
            SaveNewPayment_button.Enabled = false;
        }

        private void SaveNewPayment_button_Click(object sender, EventArgs e)
        {
            decimal paymentAmount;

            if (!decimal.TryParse(PaymentAmount_textBox.Text.Trim(), out paymentAmount))
            {
                MessageBox.Show("Не верно указана сумма платежа");
                return;
            }
            try
            {
                if (dal.SaveNewPayment(Int32.Parse(CreditID_textBox.Text), Int32.Parse(CreditID_listBox.SelectedValue.ToString()),
                    paymentAmount, PaymentDate_dateTimePicker.Text))
                    this.DialogResult = DialogResult.OK;
                else
                    this.DialogResult = DialogResult.No;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
