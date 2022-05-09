using Commons.Enum;
using System;

namespace Model
{
    public class BankAccount
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string AccountNumber { get; set; }
        public AccountType AccountType { get; set; }
        public decimal Balance { get; set; }
        public string DateCreated = DateTime.UtcNow.ToString("MM-dd-yyyy");
        private static int id;
        public BankAccount(int CustomerId, string AccountNumber, AccountType AccountType, decimal Balance)
        {
            Id = ++id;
            this.CustomerId = CustomerId;
            this.AccountNumber = AccountNumber;
            this.AccountType = AccountType;
            this.Balance = Balance;
        }
    }
}
