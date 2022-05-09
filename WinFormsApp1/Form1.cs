using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Commons;
using Model;
using Contracts;
using BankServices;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        public static ICustomer _customer;
        public static ICustomer Customer
        {
            get => _customer ??= new CustomerServices();
        }
    
        public static IValidators _validate;
        public static IValidators Validate
        {
            get => _validate ??= new ValidationServices();
        }
    public Form1()
        {
            InitializeComponent();
        }

        private async void btnregister_Click(object sender, EventArgs e)
        {

            try
            {
                bool proceed = true;
                if (!Validate.CheckName(txtFirstName.Text))
                {
                    lblFirstName.Visible = true;
                    proceed = false;
                }
                else
                {
                    lblFirstName.Visible = false;
                }
                if (!Validate.CheckName(txtLastName.Text))
                {
                    lblLastName.Visible = true;
                    proceed = false;
                }
                else
                {
                    lblLastName.Visible = false;
                }
                if (!Validate.CheckEmail(txtEmail.Text))
                {
                    lblEmail.Visible = true;
                    proceed = false;
                }
                else
                {
                    lblEmail.Visible = false;
                }
                if (!Validate.CheckPassword(txtPassword.Text))
                {
                    lblPassword.Visible = true;
                    proceed = false;
                }
                else
                {
                    lblPassword.Visible = false;
                }
                if (!Validate.CheckPassword(txtConfPassword.Text))
                {
                    lblConfPassword.Visible = true;
                    proceed = false;
                }
                else
                {
                    lblPassword.Visible = false;
                }
                if (proceed)
                {
                    Customer customer = new Customer(txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtPassword.Text);
                    bool isSuccess = await Customer.AddCustomer(customer);
                    this.Hide();
                    Menu menu = new Menu(customer.CustomerId);
                    menu.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form2 form = new Form2();
            form.Show();
        }
    }
}
