using Contracts;
using Moq;
using Model;
using System.Collections.Generic;
using Xunit;
using Commons.Enum;
using BankServices;
using System.Threading.Tasks;

namespace BankAppTest
{
    public class AccountService
    {
        private Mock<IBankAccount> _bankAccount;
        private readonly BankAccountServices _user;
        public AccountService()
        {
            _bankAccount = new Mock<IBankAccount>();
            _user = new BankAccountServices();
        }
   
       
       // [Fact]
        /*public async void Add_Account()
        {
            ReadJsonReturnAccount();
            List<BankAccount> user = Helper.Get_Account();
            //Actual
            var result = _bankAccount.Object.Add(user[0], "USSD");
            var test1 = await _user.Add(user[0], "USSD");
            Assert.True(test1);
        }*/

        [Fact]
        public async void HasDepositedFalse()
        {
            MakeDeposit();
           bool result = await _bankAccount.Object.Deposit(100, "Bet9ja", "1111534753");
            
            var test1 =await _user.Deposit(300, "fff", "1111534753");
            Assert.True(test1);
        }
        
        #region
        [Fact]
        public void ReadJsonReturnAccount()
        {
            var account = Helper.Get_Account();
            _bankAccount.Setup(X => X.Add(account[0], "Deposit")).ReturnsAsync(true);
        }
        [Fact]
        public void ReadAllAccounts()
        {
            var accounts = Helper.Get_Account();
            _bankAccount.Setup(X => X.GetAllAccount(1)).ReturnsAsync(accounts);
        }
        [Fact]
        public void MakeDeposit()
        {
            _bankAccount.Setup(X => X.Deposit(It.Is<decimal>(x=> x > 0), It.Is<string>(x => !string.IsNullOrWhiteSpace(x)), It.Is<string>(x => !string.IsNullOrWhiteSpace(x)))).ReturnsAsync(true);
        }

        public void ShouldGetAccountByAccountNumber()
        {
                var accounts = Helper.Get_Account();
             var result =   _bankAccount.Setup(X => X.GetAccountBYAccountNumber(It.Is<string>(x => string.IsNullOrWhiteSpace(x)))).ReturnsAsync(accounts[0]);
            Assert.NotNull(result);
        }
        #endregion
    }

}


