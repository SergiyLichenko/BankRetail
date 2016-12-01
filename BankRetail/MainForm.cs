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
    public partial class MainForm : Form
    {
        DAL dal = new DAL();
        List<DataGridViewRow> searchedRows;
        DataTable allDebetors;
        int currentRow;
        public MainForm()
        {
            InitializeComponent();

            allDebetors = dal.GetAllDebetors();
            
            Debetors_dataGridView.DataSource=allDebetors;
            Settings_DataGridView_Debetors();
        }

        void Settings_DataGridView_Debetors()
        {
            try
            {
                Debetors_dataGridView.Columns["ID"].Visible = false;
                Debetors_dataGridView.Columns["PostNumber"].Visible = false;
                Debetors_dataGridView.Columns["PhoneNumber"].Visible = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Debetors_dataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            string ID = Debetors_dataGridView.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            DebetorID_textBox.Text = (ID == string.Empty) ? "Нет данных" : ID;
            
            string name = Debetors_dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            DebetorName_textBox.Text = (name == String.Empty) ? "Нет данных" : name;

            string post = Debetors_dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value.ToString();
            DebetorPostNumber_textBox.Text = (post == String.Empty) ? "Нет данных" : post;

            string phone = Debetors_dataGridView.Rows[e.RowIndex].Cells["PhoneNumber"].Value.ToString();
            DebetorPhoneNumber_textBox.Text = (phone == String.Empty) ? "Нет данных" : phone;

            Credits_dataGridView.DataSource = dal.GetAllCreditsForDebetor(Debetors_dataGridView.CurrentRow.Cells["ID"].Value.ToString());//Передача ID дебетора в метод получения данных о его кредитах
            if (Credits_dataGridView.Rows.Count == 0)
                Payments_dataGridView.DataSource = null;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Debetors_dataGridView.CellEnter += new DataGridViewCellEventHandler(Debetors_dataGridView_CellEnter);
            Credits_dataGridView.CellEnter+=Credits_dataGridView_CellEnter;
        }

        private void Credits_dataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            string creditsID = Credits_dataGridView.CurrentRow.Cells["ID"].Value.ToString();
            Payments_dataGridView.DataSource = dal.GetAllPaymentsForCredit(creditsID);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("Вы действительно желаете закрыть приложение?", "Bank Manager", MessageBoxButtons.OKCancel))
                Application.ExitThread();
            else
                e.Cancel = true;
        }

        private void addNewDebetorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewDebetor_form newDebetor = new NewDebetor_form();
            if (newDebetor.ShowDialog() == DialogResult.OK)
                
                MessageBox.Show("Новый дебетор успешно создан","Bank Manager",MessageBoxButtons.OK);
            else
                MessageBox.Show("Новый дебетор не создан!!!", "Bank Manager", MessageBoxButtons.OK);
            allDebetors.Clear();
            allDebetors = dal.GetAllDebetors();
            Debetors_dataGridView.DataSource = allDebetors;
        }

        private void openNewCreditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewCredit newCredit = new NewCredit();
            if (newCredit.ShowDialog() == DialogResult.OK)
            {
                Credits_dataGridView.DataSource = dal.GetAllCreditsForDebetor(Debetors_dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                MessageBox.Show("Новый кредит успешно выдан", "Bank Manager", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Новый кредит НЕ выдан", "Bank Manager", MessageBoxButtons.OK);

        }

        private void passNewPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewPayment newPayment = new NewPayment();
            if (newPayment.ShowDialog() == DialogResult.OK)
            {
                Credits_dataGridView.DataSource = dal.GetAllCreditsForDebetor(Debetors_dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                MessageBox.Show("Новый платеж успешно принят", "Bank Manager", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Новый платеж НЕ принят", "Bank Manager", MessageBoxButtons.OK);
        }

        private void saveDataToSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dal.SaveToFile())
                MessageBox.Show("Данные успешно сохранены","Bang manager",MessageBoxButtons.OK,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);
            else
                MessageBox.Show("Данные НЕ сохранены!", "Bang manager", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                
        }

        private void RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            object headValue = ((DataGridView)sender).Rows[e.RowIndex].HeaderCell.Value;
            if (headValue == null || !headValue.Equals((e.RowIndex + 1).ToString()))
                ((DataGridView)sender).Rows[e.RowIndex].HeaderCell.Value = (e.RowIndex + 1).ToString();
            ((DataGridView)sender).TopLeftHeaderCell.Value = "#";
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            
            searchedRows = new List<DataGridViewRow>();
            string debName = DebetorNameSearched_textBox.Text.Trim();
            string postNumber = DebetorPostNumberSearched_textBox.Text.Trim();
            string phoneNumber = DebetorPhoneNumberSearched_textBox.Text.Trim();
            if (!DataBase_checkBox.Checked)
            {
                
                Debetors_dataGridView.DataSource = allDebetors;
                foreach (DataGridViewRow row in Debetors_dataGridView.Rows)
                {
                    if (row.Index == Debetors_dataGridView.Rows.Count - 1)
                        break;
                    if (row.Cells["Name"].Value.ToString().Contains(debName) &&
                        row.Cells["PostNumber"].Value.ToString().Contains(postNumber) &&
                        row.Cells["PhoneNumber"].Value.ToString().Contains(phoneNumber))
                        searchedRows.Add(row);
                }
                if (searchedRows.Count == 0)
                {
                    MessageBox.Show("По данному запросу ничего не найдено");
                    NextRow_button.Enabled = false;
                    return;
                }
                NextRow_button.Enabled = true;
                MessageBox.Show("Найдено " + searchedRows.Count.ToString() + " записей");
                currentRow = -1;
                NextRow_button_Click(null, null);
            }
            else
            {
                DataTable searchedDebetors = dal.SearchDebitors(debName, postNumber, phoneNumber);
                if (searchedDebetors == null || searchedDebetors.Rows.Count == 0)
                {
                    MessageBox.Show("Ничего не найдено");
                    return;
                }
                MessageBox.Show("Найдено " + searchedDebetors.Rows.Count + " записей");
                Debetors_dataGridView.DataSource = searchedDebetors;
                NextRow_button.Enabled = false;
            }

            
        }

        private void NextRow_button_Click(object sender, EventArgs e)
        {
            if (currentRow == searchedRows.Count-1)
                currentRow = 0;
            else
                currentRow++;
            Debetors_dataGridView.CurrentCell = searchedRows[currentRow].Cells[1];
        }

     
    }
}
