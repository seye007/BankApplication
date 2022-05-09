
using Model;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IAuthentication
    {
        Task<Customer> Login(string username, string password);
    }
}
