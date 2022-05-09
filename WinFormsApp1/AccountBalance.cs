using Contracts;
using BankServices;
using Model;
using Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class AccountBalance : Form
    {
        public int CustomerId;
        public static IBankAccount _bankAccount;
        public static IBankAccount BankAccount
        {
            get => _bankAccount ??= new BankAccountServices();
        }

        public static IValidators _validate;
        public static IValidators Validate
        {
            get => _validate ??= new ValidationServices();
        }
        public AccountBalance(int customerId)
        {
            CustomerId = customerId;
            InitializeComponent();
        }

        private async void lblCheckBalance_Click(object sender, EventArgs e)
        {
            
                try 
                {
                    if (Validate.CheckAccountNumber(txtAccountNumber.Text))
                    {
                        BankAccount bankAccount = await BankAccount.GetAccountBYAccountNumber(txtAccountNumber.Text);
                        if (bankAccount != null && bankAccount.CustomerId == CustomerId)
                        {
                            lblDetail.Text = "Account Balance: N" + Convert.ToString(bankAccount.Balance);
                            lblDetail.Visible = true;
                            label3.Visible = false;
                            txtAccountNumber.Visible = false;
                            lblMenu.Visible = true;
                            lblCheckBalance.Visible = false;
                        }
                        else
                        {
                            lblDetail.Text = "This account number is assigned to a different customer";
                            lblDetail.Visible = true;
                            lblMenu.Visible = true;
                        }
                    }
                    else
                    {
                        lblDetail.Visible = true;
                        lblMenu.Visible = true;
                        lblEnterAccNo.Visible = true;
                        txtAccountNumber.Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                 
        }

        private void lblMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu(CustomerId);
            menu.Show();
        }

        private void lblEnterAccNo_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccountBalance balance = new AccountBalance(CustomerId);
            balance.Show();
        }
    }
}
