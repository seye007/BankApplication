
using Model;
using Contracts;
using Moq;
using BankServices;
using Xunit;


namespace BankAppTest
{
    public class RadWriteJson
    {
        private Mock<IDBConnect> _DBConnect;
        public RadWriteJson()
        {
            _DBConnect = new Mock<IDBConnect>();
        }

       
    }
}

