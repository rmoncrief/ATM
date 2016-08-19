using ATM.Models;
using System.Linq;

namespace ATM.Services
{

    public class CheckingAccountService
    {
        private ApplicationDbContext db;

        public CheckingAccountService(ApplicationDbContext dbContext)
        {
            db = dbContext;
        }
        public void CreateCheckingAccount(string firstname, string lastname, string userId, decimal initialBalance)
        {

            var accountNumber = (123456 + db.CheckingAccounts.Count()).ToString().PadLeft(10, '0');
            var checkingAccount = new CheckingAccount
            {
                Firstname = firstname,
                Lastname = lastname,
                AccountNumber = accountNumber,
                Balence = initialBalance,
                ApplicationUserId = userId
            };
            db.CheckingAccounts.Add(checkingAccount);
            db.SaveChanges();


        }
    }
}