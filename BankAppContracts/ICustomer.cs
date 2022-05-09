
using Model;
using System.Threading.Tasks;
namespace Contracts
{
    public interface ICustomer
    {
        Task<bool> AddCustomer(Customer customer);
        Task<Customer> GetCustomerById(int customerId);
        Task<Customer> GetCustomerByEmail(string customerEmail, string password);

    }
}
