using Contracts;
using BankServices;
using Xunit;

namespace BankAppTest
{
    public class ValidationTest
    {
        public static IValidators _validate;
        public static IValidators Validate
        {
            get => _validate ??= new ValidationServices();
        }
        [Theory]
        [InlineData("seye@gma.com", true)]
        [InlineData("Seye@gmail.com", true)]
        [InlineData("SEYE@GMAIL.COM", true)]
        [InlineData("seye..gmailcom", false)]
        [InlineData("seye.@gmailcom", false)]
        public void Should_Validation_Email(string email, bool expected)
        {
            bool actual = Validate.CheckEmail(email);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData("Seye", true)]
        [InlineData("SEYE", true)]
        [InlineData("seye", false)]
        [InlineData("seye123", false)]
        [InlineData("seye..gmailcom", false)]
        [InlineData("1232", false)]
        public void Should_Validation_Name(string name, bool expected)
        {
            bool actual = Validate.CheckName(name);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData("Seye", false)]
        [InlineData("SEYE", false)]
        [InlineData("seye@1", false)]
        [InlineData("Seye@1", true)]
        [InlineData("Chelsea@1", true)]
        [InlineData("1232", false)]
        public void Should_Validation_Password(string password, bool expected)
        {
            bool actual = Validate.CheckPassword(password);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData("5000", true)]
        [InlineData("450.23", true)]
        [InlineData("seye@1", false)]
        [InlineData("0.567", true)]
        [InlineData("Chelsea@1", false)]
        [InlineData("", false)]
        public void Should_Validation_Amount(string amount, bool expected)
        {
            bool actual = Validate.CheckAmount(amount);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData("Chelsea@1", "Chelsea@1", true)]
        [InlineData("450.23", "Chelsea@1", false)]
        [InlineData("", "Sheye@1", false)]
        [InlineData("Sheye@1", "Sheye@1", true)]
        [InlineData("Adeola@1", "Adeola@1", true)]
        [InlineData("Mike@1", "", false)]
        public void Should_Validation_Passord_equlity(string password, string confPassword, bool expected)
        {
            bool actual = Validate.ConfirmPasswordValidator(password, confPassword);
            Assert.Equal(expected, actual);
        }



        [Theory]
        [InlineData("1111569847", true)]
        [InlineData("1122989833", true)]
        [InlineData("", false)]
        [InlineData("WDT1234276", false)]
        [InlineData("pouthfnfsa", false)]
        public void Should_Validate_AccountNumber(string accountNumber, bool expected)
        {
            bool actual = Validate.CheckAccountNumber(accountNumber);
            Assert.Equal(expected, actual);
        }

    }
}

