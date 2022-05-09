using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Model;
using Commons.Enum;

namespace Contracts
{
    public interface IBankAccount
    {
        Task<bool> Add(BankAccount account, string detail);
        Task<bool> Deposit(decimal amount,string detail, string accountNumber);
        Task<bool> Withdraw(decimal amount, string detail, string accountNumber);
        Task<List<BankAccount>> GetAllAccount(int customerId);
        Task<BankAccount> GetAccountBYAccountNumber(string accountNumber);
        Task<bool> Transfer(decimal amount, string senderAccount, string receiverAccount);

    }
}
