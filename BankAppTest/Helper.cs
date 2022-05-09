using Model;
using System.Collections.Generic;

using Commons.Enum;

namespace BankAppTest
{
    public class Helper
    {
        public static List<Customer> Get_Customer_By_ID()
        {
            List<Customer> customers = new List<Customer>()
            {
               new Customer("Seye","Deji", "seye@gmail.com","Chelsea@1"),
               new Customer("Adeola","Sabejide","adeola@gmail.com","Adeola@1"),
               new Customer("Mike","Tyson","miketyson@gmail.com","Miketyson@1")
            };
            return customers;
        }

        public static List<BankAccount> Get_Account()
        {
            List<BankAccount> account = new List<BankAccount>()
            {
               new BankAccount(1,"1111876593",AccountType.Current,2345),
               new BankAccount(1,"1671876593",AccountType.Savings,5645),
            };
            return account;
        }
    }
}
