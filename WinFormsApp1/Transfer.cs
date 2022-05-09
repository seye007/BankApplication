using Contracts;
using BankServices;
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
    public partial class Transfer : Form
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
        public Transfer(int customerId)
        {
            InitializeComponent();
            CustomerId = customerId;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu(CustomerId);
            menu.Show(this);
        }

        private void lblMenu2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu(CustomerId);
            menu.Show(this);
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transfer transfer = new Transfer(CustomerId);
            transfer.Show();
        }

        private async void btnProceed_Click(object sender, EventArgs e)
        {
            try
            {

                if (Validate.CheckAccountNumber(txtSenderAccountNo.Text) && Validate.CheckAccountNumber(txtRecieverAccNo.Text) && Validate.CheckAmount(txtAmount.Text) && Convert.ToDecimal(txtAmount.Text) > 0)
                {
                    //amount, string senderAccount, string receiverAccount)
                    await BankAccount.Transfer(Convert.ToDecimal(txtAmount.Text), txtSenderAccountNo.Text, txtRecieverAccNo.Text);
                    lblTransactionStatus.Visible = true;
                    btnMenu.Visible = true;
                    btnTransfer.Visible = true;
                    btnProceed.Visible = false;
                    btnMenu.Visible = false;
                    lblAmount.Visible = false;
                    lblreciever.Visible = false;
                    lblsender.Visible = false;
                    txtAmount.Visible = false;
                    txtRecieverAccNo.Visible = false;
                    txtSenderAccountNo.Visible = false;
                }
                else
                {
                    lblTransactionStatus.Text = "Transaction failed";
                    lblTransactionStatus.ForeColor = Color.Red;
                    lblTransactionStatus.Visible = true;
                    btnMenu.Visible = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
