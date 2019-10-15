using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountOperationAppPractice1
{
    public partial class AccountOperationUi : Form
    {
        public AccountOperationUi()
        {
            InitializeComponent();
        }

        Account account = new Account();
        private void CreateButton_Click(object sender, EventArgs e)
        {
            

            account.AccountNamber= accountNoTextBox.Text;
            account.CustomerName= customerNameTextBox.Text;
            account.balance =Convert.ToDouble(amountTextBox.Text);
            
            accountNoTextBox.Clear();
            customerNameTextBox.Clear();
            amountTextBox.Clear();
            
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show(account.GetReport());
        }

        private void DipositButton_Click(object sender, EventArgs e)
        {
            //account.balance = Convert.ToDouble(amountTextBox.Text);
            account.Deposit(Convert.ToDouble (amountTextBox.Text));
            MessageBox.Show("Deposit successful");
            amountTextBox.Clear();

        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            account.Withdrow(Convert.ToDouble( amountTextBox.Text));
            MessageBox.Show("Withdrow successful");
            amountTextBox.Clear();
        }
    }
}
