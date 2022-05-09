using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IValidators
    {
        bool CheckName(string name);
        bool CheckEmail(string email);
        bool CheckPassword(string password);
        bool CheckAmount(string amount);
        bool CheckAccountNumber(string account);
        bool ConfirmPasswordValidator(string password, string confirmPassword);
    }
}
