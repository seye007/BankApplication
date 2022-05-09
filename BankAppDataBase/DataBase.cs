using System.Collections.Generic;
using System.Linq;
using Model;
using Contracts;
using System.IO;
using System.Threading.Tasks;
using System;

namespace DataBase
{
    public class DataBase
    {
        private readonly IDBConnect _dBConnect;
        public DataBase(IDBConnect dbConnect)
        {
            _dBConnect ??= dbConnect;
        }

        private static List<Customer> customerDB = new List<Customer>();
        private static List<BankAccount> bankAccountsDB = new List<BankAccount>();
        private static List<Transaction> transactionDB = new List<Transaction>();

        public static List<Customer> CustomerDB => customerDB;

        public static List<BankAccount> BankAccountDB => bankAccountsDB;

        public static List<Transaction> TransactionDB => transactionDB;

        public static async Task<bool> CreateCustomer(Customer customer)
        {
            try
            {
                DBConnect.UpdatePath();
                if (File.Exists(DBConnect.path + "Customer.json"))
                {
                    customerDB = await DBConnect.ReadFromJason<Customer>("Customer.json");
                    customer.CustomerId = customerDB[customerDB.Count - 1].CustomerId + 1;
                    await DBConnect.WriteToJason<Customer>(customer, "Customer.json");
                    customerDB = await DBConnect.ReadFromJason<Customer>("Customer.json");
                }
                else
                {
                    await DBConnect.WriteToJason<Customer>(customer, "Customer.json");
                    customerDB = await DBConnect.ReadFromJason<Customer>("Customer.json");
                }
                return CustomerDB.Contains(customer);
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public static async Task<Customer> GetCustomerById(int customerId)
        {
            try 
            {
                customerDB = await DBConnect.ReadFromJason<Customer>("Customer.json");
                return CustomerDB.FirstOrDefault(x => x.CustomerId == customerId);
            }
            catch(Exception)
            {
                throw;
            }
            
        }
        public static async Task<bool> RemoveCustomerByID(int customerId)
        {
            try
            {
                customerDB = await DBConnect.ReadFromJason<Customer>("Customer.json");
                Customer customer = await GetCustomerById(customerId);
                return CustomerDB.Remove(customer);
            }
            catch (Exception)
            {
                throw;
            }
            
        }
        public static async Task<Customer> GetCustomerByEmail(string email, string password)
        {
            try
            {
                customerDB = await DBConnect.ReadFromJason<Customer>("Customer.json");
                Customer customer = CustomerDB.FirstOrDefault(x => x.Email == email && x.Password == password);
                return customer;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static async Task<bool> CreateAcoount(BankAccount account)
        {
            try
            {
                DBConnect.UpdatePath();
                if (File.Exists(DBConnect.path + "Account.json"))
                {
                    bankAccountsDB = await DBConnect.ReadFromJason<BankAccount>("Account.json");
                    account.Id = bankAccountsDB[bankAccountsDB.Count - 1].Id + 1;
                    await DBConnect.WriteToJason<BankAccount>(account, "Account.json");
                    customerDB = await DBConnect.ReadFromJason<Customer>("Account.json");
                }
                else
                {
                    await DBConnect.WriteToJason<BankAccount>(account, "Account.json");
                    customerDB = await DBConnect.ReadFromJason<Customer>("Account.json");
                }
                return BankAccountDB.Contains(account);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static async Task<bool> UpdateDeposit(BankAccount account, decimal amount)
        {

            try
            {
                if (bankAccountsDB.Contains(account))
                {
                    foreach (BankAccount bankAccount in bankAccountsDB)
                    {
                        if (bankAccount == account)
                        {
                            bankAccount.Balance += amount;
                        }
                    }
                    await DBConnect.UpdateJason<BankAccount>(bankAccountsDB, "Account.json");
                };
                return true;
            }
            catch (Exception)
            {
                throw;
            }
            
        }
        public static async Task<bool> UpdateWithdraw(BankAccount account, decimal amount)
        {

            try
            {
                if (BankAccountDB.Contains(account))
                {
                    foreach (BankAccount bankAccount in bankAccountsDB)
                    {
                        if (bankAccount == account)
                        {
                            bankAccount.Balance -= amount;
                        }
                    }
                    await DBConnect.UpdateJason<BankAccount>(bankAccountsDB, "Account.json");
                };
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
       /* public staticasync Task<BankAccount> GetAccountByCustomertId(int customerId)
        {
            bankAccountsDB = await DBConnect.ReadFromJason<BankAccount>("Account.json");
            return BankAccountDB.FirstOrDefault(x => x.CustomerId == customerId);
        }*/
        public static async Task<BankAccount> GetAccountByAccountNumber(string accountNumber)
        {
            try
            {
                bankAccountsDB = await DBConnect.ReadFromJason<BankAccount>("Account.json");
                return bankAccountsDB.FirstOrDefault(x => x.AccountNumber == accountNumber);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static async Task<List<BankAccount>> GetAllAccount(int customerId)
        {
            try
            {
                bankAccountsDB = await DBConnect.ReadFromJason<BankAccount>("Account.json");
                return BankAccountDB.FindAll(x => x.CustomerId == customerId);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static async Task<Transaction> GetTransactionId(int accountNo)
        {

            try
            {
                transactionDB = await DBConnect.ReadFromJason<Transaction>("Transaction.json");
                return TransactionDB.FirstOrDefault(x => x.AccountId == accountNo);
            }
            catch (Exception)
            {
                throw;
            }
            
        }
        public static async Task<List<Transaction>> GetAllTransaction(int accountId)
        {
            try
            {
                transactionDB = await DBConnect.ReadFromJason<Transaction>("Transaction.json");
                return TransactionDB.FindAll(x => x.AccountId == accountId);
            }
            catch (Exception)
            {
                throw;
            }
           
        }

        public static async Task<bool> CreateTransaction(Transaction transaction)
        {
            try
            {
                DBConnect.UpdatePath();
                if (File.Exists(DBConnect.path + "Transaction.json"))
                {
                    transactionDB = await DBConnect.ReadFromJason<Transaction>("Transaction.json");
                    transaction.Id = transactionDB[transactionDB.Count - 1].Id + 1;
                    await DBConnect.WriteToJason<Transaction>(transaction, "Transaction.json");
                    transactionDB = await DBConnect.ReadFromJason<Transaction>("Transaction.json");
                }
                else
                {
                    await DBConnect.WriteToJason<Transaction>(transaction, "Transaction.json");
                    transactionDB = await DBConnect.ReadFromJason<Transaction>("Transaction.json");
                }
                return TransactionDB.Contains(transaction);
            }
            catch (Exception)
            {
                throw;
            }
           
        }
    }
}
