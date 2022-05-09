using Contracts;
using Model;
using DataBase;
using System.Threading.Tasks;

namespace BankServices
{
    public class CustomerServices : ICustomer
    {
        public async Task<bool> AddCustomer(Customer customer)
        {
            if (customer != null)
            {
                bool isCustomerStored = await DataBase.DataBase.CreateCustomer(customer);
                return isCustomerStored;
            }
            return default;
        }
        public async Task<Customer> GetCustomerById(int customerId) { return await DataBase.DataBase.GetCustomerById(customerId); }
        public async Task<Customer> GetCustomerByEmail(string customerEmail, string password) { return await DataBase.DataBase.GetCustomerByEmail(customerEmail, password); }
    }
}
