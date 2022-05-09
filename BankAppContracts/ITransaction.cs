using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Model;
using Commons.Enum;

namespace Contracts
{
    public interface ITransaction
    {
        Task<Transaction> GetTransactionById(int transactionId);
        Task<bool> Add(Transaction transaction);

        Task<List<Transaction>> GetAllTransaction(int accountId);
    }
}
