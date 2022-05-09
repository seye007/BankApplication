using System;
using System.ComponentModel;
using System.Windows.Forms;
using BankAppCore.Models;
using BankAppCore.Interfaces;

namespace BankAppUI
{
    public partial class Register : Form
    {
        private readonly IUsers _users;
        private readonly IUtilities _utility;
        private readonly IValidators _valid;

        public Register(IUsers users, IUtilities utilities, IValidators validators)
        {            
            _users = users;
            InitializeComponent();
            _utility = utilities;
            _valid = validators;
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            Users person = new Users()
            {
                Id = Guid.NewGuid().ToString(),
                FullName = txtFirstName.Text + " " + txtLastName.Text,
                EmailAddress = txtEmail.Text,
                MobileNumber = txtPhone.Text,
                Password = _utility.ComputeSha256Hash(txtPassword.Text),
                Age = Convert.ToInt16(txtAge.Text),
                IsActive = true
            };

            try
            {
                var check = await _users.AddUser(person);
                if(check)
                {
                    MessageBox.Show("User was successfully added");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                e.Cancel = true;
                txtFirstName.Focus();
                errorProviderApp.SetError(txtFirstName, "Name should not be left blank!");
            }
            else if(!_valid.CheckName(txtFirstName.Text))
            {
                e.Cancel = true;
                txtFirstName.Focus();
                errorProviderApp.SetError(txtFirstName, "Please First Name should start with capital letter");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(txtFirstName, "");
            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                e.Cancel = true;
                txtLastName.Focus();
                errorProviderApp.SetError(txtLastName, "Name should not be left blank!");
            }
            else if (!_valid.CheckName(txtLastName.Text))
            {
                e.Cancel = true;
                txtLastName.Focus();
                errorProviderApp.SetError(txtLastName, "Please First Name should start with capital letter");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(txtLastName, "");
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                e.Cancel = true;
                txtEmail.Focus();
                errorProviderApp.SetError(txtEmail, "Name should not be left blank!");
            }
            else if (!_valid.CheckEmail(txtEmail.Text))
            {
                e.Cancel = true;
                txtEmail.Focus();
                errorProviderApp.SetError(txtEmail, "Please Enter Correct Email Format");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(txtEmail, "");
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                e.Cancel = true;
                txtPassword.Focus();
                errorProviderApp.SetError(txtPassword, "Name should not be left blank!");
            }
            else if (!_valid.CheckEmail(txtPassword.Text))
            {
                e.Cancel = true;
                txtPassword.Focus();
                errorProviderApp.SetError(txtPassword, "Please Enter Correct Email Format");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(txtPassword, "");
            }
        }
    }
}
