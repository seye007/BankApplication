using Contracts;
using BankServices;
using System;
using Model;
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
    public partial class Menu : Form
    {

        public static ICustomer _customer;
        public static ICustomer Customer
        {
            get => _customer ??= new CustomerServices();
        }
        public int CustomerId;
        public Menu(int id)
        {
            InitializeComponent();
            CustomerId = id;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btnOpenAccount.Visible = false;
            btnBalance.Visible = false;
            btnDeposit.Visible = false;
            btnDeposit.Visible = false;
            btnWithdraw.Visible = false;
            btnFund.Visible = false;
            btnAccountDetails.Visible = false;
            btnAccountStatement.Visible = false;
        }

        private void txtSignout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 login = new Form2();
            login.Show();
        }

        private async void Menu_Load_1(object sender, EventArgs e)
        {
            try
            {
                Customer customer = await Customer.GetCustomerById(CustomerId);
                name.Text = "Welcome " + customer.FirstName + " ,Choose any option to perform any of the operations.";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private async void btnOpenAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer customer = await Customer.GetCustomerById(CustomerId);
            Form3 OpenAccount = new Form3(customer.CustomerId);
            OpenAccount.Show();
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccountBalance balance = new AccountBalance(CustomerId);
            balance.Show();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            this.Hide();
            WithdrawAndDeposit deposit = new WithdrawAndDeposit(CustomerId);
            deposit.Show();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            this.Hide();
            Withdraw withdraw = new Withdraw(CustomerId);
            withdraw.Show();
        }

        private void btnAccountDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccountTable accountTable = new AccountTable(CustomerId, true);
            accountTable.Show();
        }

        private void btnAccountStatement_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccountTable accountTable = new AccountTable(CustomerId, false);
            accountTable.Show();
        }

        private void btnFund_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transfer transfer = new Transfer(CustomerId);
            transfer.Show();
        }
    }
}
