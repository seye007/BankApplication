using Contracts;
using Model;
using DataBase;
using System.Collections.Generic;
using Commons.Enum;
using System.Threading.Tasks;

namespace BankServices
{
    public class TransactionServices : ITransaction
    {
        public async Task<Transaction> GetTransactionById(int transactionId)
        {
            Transaction transaction = await DataBase.DataBase.GetTransactionId(transactionId);
            return transaction;
        }

        public async Task<List<Transaction>> GetAllTransaction(int accountId)
        {
            List<Transaction> transactions = await DataBase.DataBase.GetAllTransaction(accountId);
            if (transactions != null) { return transactions; }
            return null;
            ;
        }
        public async Task<bool> Add(Transaction transaction)
        {
            if (transaction != null)
            {
                bool isCustomerStored = await DataBase.DataBase.CreateTransaction(transaction);
                return isCustomerStored;
            }
            return default;
        }
    }
}
