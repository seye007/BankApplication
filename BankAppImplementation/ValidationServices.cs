using System.Text.RegularExpressions;
using Contracts;

namespace BankServices
{
    public class ValidationServices : IValidators
    {
        public bool CheckEmail(string email)
        {
            string strRegex = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            return PerformRegEx(strRegex, email);
        }

        public bool CheckName(string name)
        {
            string strRegex = @"^[A-Z]";

            return PerformRegEx(strRegex, name);
        }

        public bool CheckPassword(string password)
        {

            string strRegex = @"^(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{6,}$";
            return PerformRegEx(strRegex, password);
        }

        private static bool PerformRegEx(string pattern, string value)
        {
            Regex re = new Regex(pattern);


            if (re.IsMatch(value))
                return (true);
            else
                return (false);
        }
        public bool CheckAmount(string amount)
        {
            return (decimal.TryParse(amount, out decimal result));

        }
        public bool CheckAccountNumber(string account)
        {
            return (!(string.IsNullOrEmpty(account)) && account.Length == 10 && int.TryParse(account, out int result));

        }


        public bool ConfirmPasswordValidator(string password, string confirmPassword)
        {
            return (password == confirmPassword);
        }
    }
 }
