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
    public partial class Form2 : Form
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
        public Form2()
        {
            InitializeComponent();
        }

        private void lblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 register = new Form1();
            register.Show();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            bool proceed = true;
            if (!Validate.CheckEmail(txtEmail.Text))
            {
                lblInvalidEmail.Visible = true;
                proceed = false;
            }
            else
            {
                lblInvalidEmail.Visible = false;
            }
            if (!Validate.CheckPassword(txtPassword.Text))
            {
                lblInvalidEmail.Visible = true;
                proceed = false;
            }
            else
            {
                lblInvalidPassword.Visible = false;
            }

            if (proceed)
            {
                try
                {
                    Customer customer = await Customer.GetCustomerByEmail(txtEmail.Text, txtPassword.Text);
                    if (customer != null)
                    {
                        this.Hide();
                        Menu menu = new Menu(customer.CustomerId);
                        menu.Show();
                    }
                    else
                    {
                        lblInvalidCredential.Visible = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "please fill field");    
                }
              
            }
        }
    }
}
