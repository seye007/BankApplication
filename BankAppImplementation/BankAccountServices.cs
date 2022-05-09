using Contracts;
using Model;
using DataBase;
using Commons.Enum;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;

namespace BankServices
{

    public class BankAccountServices : IBankAccount
    {
        public static ITransaction _transaction;

        public static ITransaction Transaction
        {
            get => _transaction ??= new TransactionServices();
        }
        public async Task<bool> Add(BankAccount account, string detail)
        {
            try
            {
                if (account != null)
                {
                    bool isCustomerStored = await DataBase.DataBase.CreateAcoount(account);
                    Transaction transaction = new Transaction(account.Id, detail, "Deposit", account.Balance, account.Balance);
                    await Transaction.Add(transaction);
                    return isCustomerStored;
                }
                return default;
            }
           catch (Exception)
            {
                throw;
            }
        }

        

        public async Task<List<BankAccount>> GetAllAccount(int customerId)
        {
            try
            {
                List<BankAccount> accountt = await DataBase.DataBase.GetAllAccount(customerId);
                if (accountt != null) { return accountt; }
                return null;
            }
            catch (Exception)
            {
                throw;
            }
            
        }
        public async Task<bool> Deposit(decimal amount,string detail, string accountNumber)
        {
            try
            {
                //DBConnect.UpdatePath();

                BankAccount account = null;
                if (amount > 0)
                {
                    account = await DataBase.DataBase.GetAccountByAccountNumber(accountNumber);
                    await DataBase.DataBase.UpdateDeposit(account, amount);
                    Transaction transaction = new Transaction(account.Id, detail, "Deposit", amount, account.Balance);
                    await Transaction.Add(transaction);
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                throw;
            }
             
        }
        public async Task<bool> Withdraw(decimal amount, string detail,string accountNumber)
        {
            try
            {
                BankAccount account = await DataBase.DataBase.GetAccountByAccountNumber(accountNumber);
                if ((account.Balance - amount >= 1000) && (amount > 0) && ((int)account.AccountType == 2))
                {
                    await DataBase.DataBase.UpdateWithdraw(account, amount);
                    Transaction transaction = new Transaction(account.Id, detail, "Withdraw", amount, account.Balance);
                    await Transaction.Add(transaction);
                    return true;
                }
                else if ((amount > 0) && ((int)account.AccountType == 1))
                {
                    await DataBase.DataBase.UpdateWithdraw(account, amount);
                    Transaction transaction = new Transaction(account.Id, detail, "Withdraw", amount, account.Balance);
                    await Transaction.Add(transaction);
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public async Task<bool> Transfer(decimal amount, string senderAccount, string receiverAccount)
        {
            try
            {
                BankAccount recieverAccountNo = await this.GetAccountBYAccountNumber(receiverAccount);
                BankAccount senderAccountNo = await this.GetAccountBYAccountNumber(senderAccount);
                if (recieverAccountNo != null && senderAccountNo != null)
                {
                    Customer sender = await DataBase.DataBase.GetCustomerById(senderAccountNo.CustomerId);
                    Customer reciever = await DataBase.DataBase.GetCustomerById(recieverAccountNo.CustomerId);
                    string senderFullName = sender.FirstName + " " + sender.LastName;
                    string receiverFullName = reciever.FirstName + " " + reciever.LastName;
                    recieverAccountNo = await this.GetAccountBYAccountNumber(receiverAccount);
                    await DataBase.DataBase.UpdateDeposit(recieverAccountNo, amount);
                    senderAccountNo = await this.GetAccountBYAccountNumber(senderAccount);
                    await DataBase.DataBase.UpdateWithdraw(senderAccountNo, amount);
                    Transaction senderTransaction = new Transaction(senderAccountNo.Id, receiverFullName, "Withdraw", amount, senderAccountNo.Balance);
                    await Transaction.Add(senderTransaction);
                    Transaction recieverTransaction = new Transaction(recieverAccountNo.Id, senderFullName, "Deposit", amount, recieverAccountNo.Balance);
                    await Transaction.Add(recieverTransaction);
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<BankAccount> GetAccountBYAccountNumber(string accountNumber)
        {
            return await DataBase.DataBase.GetAccountByAccountNumber(accountNumber);
        }

    }
}
