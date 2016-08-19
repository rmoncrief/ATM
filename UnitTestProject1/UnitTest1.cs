//using ATM.Models;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

//namespace UnitTestProject1
//{
//    [TestClass]
//    public class UnitTest1
//    {
//        [TestMethod]
//        public void BalanceIsCorrectAfterDeposit()
//        {
//            var fakeDb = new FakeApplicationDbContext();
//            fakeDb.CheckingAccounts = new FakeDbSet<CheckingAccount>();


//            var checkingAccount = new CheckingAccount { Id = 1, AccountNumber = "000123Test", Balence = 0 };
//            fakeDb.CheckingAccounts.Add(checkingAccount);

//            fakeDb.Transactions = new FakeDbSet<Transaction>();
//        }
//    }
//}
