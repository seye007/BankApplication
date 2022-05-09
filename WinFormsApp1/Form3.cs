using Contracts;
using BankServices;
using System;
using Model;
using System.Windows.Forms;
using Commons.Enum;
using Commons;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public int CustomerId;
        public static ICustomer _customer;
        public static ICustomer Customer
        {
            get => _customer ??= new CustomerServices();
        }
        public static IBankAccount _account;
        public static IBankAccount BankAccount
        {
            get => _account ??= new BankAccountServices();
        }

        public static IValidators _validate;
        public static IValidators Validate
        {
            get => _validate ??= new ValidationServices();
        }
        public Form3(int customerId)
        {
            InitializeComponent();
            CustomerId = customerId;
        }

        private int accountType;
        private void Form3_Load(object sender, EventArgs e)
        {
            lblDeposit.Visible = false;
            txtAmount.Visible = false;
            lblCurrent.Visible = false;
            BtnCreate.Visible = false;
            txtAmount.Visible = false;
            lblAccount.Visible = false;
        }
        private void btnSavings_Click(object sender, EventArgs e)
        {
            btnSavings.Visible = false;
            lblDeposit.Visible = true;
            txtAmount.Visible = true;
            btnCurrent.Visible = false;
            lblCurrent.Visible = false;
            BtnCreate.Visible = true;
            accountType = 1;
            
        }

        private void btnCurrent_Click(object sender, EventArgs e)
        {
            btnCurrent.Visible = false;
            lblDeposit.Visible = false;
            btnCurrent.Visible = false;
            lblCurrent.Visible = true;
            txtAmount.Visible = true;
            btnSavings.Visible = false;
            lblAccount.Visible = false;
            BtnCreate.Visible = true;
            accountType = 2;
        }
        private async void BtnCreate_Click(object sender, EventArgs e)
        {
            if (Validate.CheckAmount(txtAmount.Text))
            {
                lblDeposit.Visible = false;
                btnSavings.Visible = false;
                txtAmount.Visible = false;
                btnCurrent.Visible = false;
                lblCurrent.Visible = false;
                BtnCreate.Visible = false;
                lblAccount.Visible = true;
                txtName.Text = "Congratulations, account successfully created!";
                txtName.ForeColor = System.Drawing.Color.Green;
                txtName.Visible = true;

                Customer customer = await Customer.GetCustomerById(CustomerId);
                Random randomaccountNumber = new Random();

                string accountNumber = Convert.ToString(randomaccountNumber.Next(1111211119, 1111555571));

                if (accountType == (int)AccountType.Savings)
                {
                    if (Validate.CheckAmount(txtAmount.Text))
                    {
                        BankAccount account = new BankAccount(customer.CustomerId, accountNumber, AccountType.Savings, Convert.ToDecimal(Convert.ToInt32(txtAmount.Text)));
                        await BankAccount.Add(account, "Initial Deposit");
                        lblAccount.Text = "Your Savings Account number is: " + account.AccountNumber;
                        lblConfirm.Visible = true;
                    }

                }
                else
                {
                    BankAccount account = new BankAccount(customer.CustomerId, accountNumber, AccountType.Current, Convert.ToDecimal(Convert.ToInt32(txtAmount.Text)));
                    await BankAccount.Add(account, "Initial Deposit");
                    lblAccount.Text = "Your Current Account number is: " + account.AccountNumber;
                    lblConfirm.Visible = true;
                }
            }
            else
            {
                txtName.Text = "Invalid Input";
                txtName.ForeColor = System.Drawing.Color.Red;
                txtName.Visible = true;
            }
        }

        private void lblConfirm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu(CustomerId);
            menu.Show();
        }
    }
}
