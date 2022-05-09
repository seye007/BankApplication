using Contracts;
using DataBase;
using Model;
using System.Threading.Tasks;

namespace BankServices
{
    public class AuthenticationService : IAuthentication
    {

        public async Task<Customer> Login(string email, string password)
        {
            if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password))
            {
                return await DataBase.DataBase.GetCustomerByEmail(email, password);

            }
            return null;
        }
    }
}
