using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankRetail
{
    public partial class NewDebetor_form : Form
    {
        DAL dal = new DAL();
        public NewDebetor_form()
        {
            InitializeComponent();
        }

        private void SaveNewDebetor_button_Click(object sender, EventArgs e)
        {
            if(dal.SaveNewDebetor(DebetorID_textBox.Text.Trim(), DebetorName_textBox.Text.Trim(),
                DebetorPostNumber_textBox.Text.Trim(), DebetorPhoneNumber_textBox.Text.Trim()))
                this.DialogResult = DialogResult.OK;
            else
                this.DialogResult = DialogResult.No;
            
        }
    }
}
