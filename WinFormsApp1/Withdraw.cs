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
    public partial class Withdraw : Form
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
        public Withdraw(int customerId)
        {
            InitializeComponent();
            CustomerId = customerId;
        }

        private void btnWithdrawAgain_Click(object sender, EventArgs e)
        {
            this.Close();
            Withdraw withdraw = new Withdraw(CustomerId);
            withdraw.Show();
        }

        private void lblMenu_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu(CustomerId);
            menu.Show();
        }

        private void lblMenu2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu(CustomerId);
            menu.Show();
        }

        private async void btnProceed_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (Validate.CheckAmount(txtAmount.Text) && Validate.CheckAccountNumber(txtAccountNumber.Text.Trim()) && Validate.CheckName(txtDescription.Text.Trim()))
                {
                    BankAccount bankAccount = await BankAccount.GetAccountBYAccountNumber(txtAccountNumber.Text.Trim());
                    bool isSuccessful = await BankAccount.Withdraw(Convert.ToDecimal(txtAmount.Text), txtDescription.Text.Trim(), bankAccount.AccountNumber);
                    if (isSuccessful == true && Convert.ToInt32(txtAmount.Text) > 0)
                    {
                        lblInstruction.Visible = false;
                        txtAccountNumber.Visible = false;
                        lblDetail.Text = "Withdraw Successful!";
                        lblDetail.ForeColor = System.Drawing.Color.Green;
                        lblDetail.Visible = true;
                        lblMenu2.Visible = true;
                        lblMenu.Visible = false;
                        lblInstruction.Visible = false;
                        btnProceed.Visible = false;
                        lblAmount.Visible = false;
                        txtAmount.Visible = false;
                        btnWithdrawAgain.Visible = true;
                        txtDescription.Visible = false;
                    }
                    else
                    {
                        lblDetail.Text = "Transaction failed";
                        lblDetail.ForeColor = System.Drawing.Color.Red;
                        lblDetail.Visible = true;
                        lblMenu.Visible = true;
                    }
                }
                else
                {
                    lblDetail.Text = "Invalid input";
                    lblDetail.ForeColor = System.Drawing.Color.Red;
                    lblDetail.Visible = true;
                    lblMenu.Visible = true;
                    txtAccountNumber.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            
            }
        }

    }
}
