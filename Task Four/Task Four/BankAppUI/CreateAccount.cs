using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BankAppCore.Models;
using BankAppCore.Interfaces;

namespace BankAppUI
{
    public partial class CreateAccount : Form
    {
        private readonly IAccount _account;
        private readonly IUtilities _utility;
        public CreateAccount(IAccount account, IUtilities utilities)
        {
            InitializeComponent();
            _account = account;
            _utility = utilities;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Accounts account = new ()
            {
                AccountNumber = _utility.RandomDigits(10),
                AccountType = rdbSaving.Checked ? "Saving" : "Current",
                Balance = Convert.ToDouble(txtInitailAmt.Text),
                UserId = GlobalVariable.GlobalUser.Id
            };

            try
            {
                bool check = await _account.AddAccount(account);
                MessageBox.Show("Account Added Successfully!!");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
