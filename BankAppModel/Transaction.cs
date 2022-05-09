using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Transaction
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public string TransactionDetail { get; set; }
        public string Operation { get; set; }
        public decimal Balance { get; set; }
        public decimal TransactionAmount { get; set; }
        public string DateCreated = DateTime.UtcNow.ToString("MM-dd-yyyy");
        private static int id;
        public Transaction(int accountId, string transactionDetail, string operation, decimal amount, decimal balance)
        {
            this.Id = ++id;
            this.AccountId = accountId;
            this.Operation = operation;
            this.TransactionAmount = amount;
            TransactionDetail = transactionDetail;
            Balance = balance;

        }
    }
}
