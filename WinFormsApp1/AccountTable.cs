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
    public partial class AccountTable : Form
    {
        public int CustomerId;
        public bool IsAccountStatement;
        public static IBankAccount _bankAccount;
        public static ICustomer _customer;
        public static ITransaction _transaction;
        public static IValidators _validate;
        public static IValidators Validate
        {
            get => _validate ??= new ValidationServices();
        }
        public static ICustomer Customer
        {
            get => _customer ??= new CustomerServices();
        }
        public static IBankAccount BankAccount
        {
            get => _bankAccount ??= new BankAccountServices();
        }
        public static ITransaction Transaction
        {
            get => _transaction ??= new TransactionServices();
        }
        public AccountTable(int customerId, bool isAccoutStatement)
        {
            InitializeComponent();
            CustomerId = customerId;
            IsAccountStatement = isAccoutStatement;
        }


        private async void AccountTable_Load(object sender, EventArgs e)
        {
            if (IsAccountStatement)
            {
                tbAccounts.Rows.Clear();
                tbTransaction.Visible = false;
                List<BankAccount> accounts = await BankAccount.GetAllAccount(CustomerId);
                int count = 1;
                foreach (BankAccount account in accounts)
                {
                    Customer customer = await Customer.GetCustomerById(account.CustomerId);
                    string[] rows = new string[6];
                    rows[0] = count.ToString();
                    rows[1] = customer.FirstName + " " + customer.LastName;
                    rows[2] = account.AccountNumber;
                    rows[3] = account.AccountType.ToString();
                    rows[4] = account.Balance.ToString();
                    rows[5] = account.DateCreated;
                    tbAccounts.Rows.Add(rows);
                    count++;

                }
            }
            else
            {
                tbAccounts.Visible = false;
                txtAccountNumber.Visible = true;
                lblAccountNumber.Visible = true;
                tbTransaction.Visible = false;
                lblMenu.Visible = false;

            }
        }

        private void lblMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu(CustomerId);
            menu.Show();    
        }

        private async void btnEnter_Click(object sender, EventArgs e)
        {
            lblMenu.Visible = true;
            if (Validate.CheckAccountNumber(txtAccountNumber.Text))
            {
                tbTransaction.Visible = true;
                lblAccountSummary.Visible = true;
                tbTransaction.Rows.Clear();
                BankAccount bankAccount = await BankAccount.GetAccountBYAccountNumber(txtAccountNumber.Text);
                List<Transaction> transactions = await Transaction.GetAllTransaction(bankAccount.Id);
                decimal totalDeposit = 0;
                decimal totalWithdrawal = 0;
          
                foreach (Transaction transaction in transactions)
                {
                    if (CustomerId == bankAccount.CustomerId)
                    {
                        string[] rows = new string[6];
                        rows[0] = transaction.DateCreated;
                        rows[1] = transaction.TransactionDetail;
                        if (transaction.Operation.ToLower() == "withdraw")
                        {
                            rows[2] = transaction.TransactionAmount.ToString();
                            totalWithdrawal += transaction.TransactionAmount;
                        }
                        else
                        {
                            rows[3] = transaction.TransactionAmount.ToString();
                            totalDeposit += transaction.TransactionAmount;
                        }
                        rows[4] = Convert.ToString(transaction.Balance);

                        tbTransaction.Rows.Add(rows);
                        lblAvailableBalance.Text = "Available balance: " + transaction.Balance.ToString();
                        lblTotalDeposit.Text = "Total money in: " + totalDeposit.ToString();
                        lblTotalWithdrawal.Text = "Total money out: " + totalWithdrawal.ToString();
                        lblTotalWithdrawal.Visible = true;
                        lblTotalDeposit.Visible = true;
                        lblAvailableBalance.Visible = true;
                    }
                }
            }
        }
    }
}
