using ATM.Models;
using System.Web.Mvc;

namespace ATM.Controllers
{
    public class TransactionController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Deposit(int checkingAccountId)
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public ActionResult Deposit(Transaction transaction)
        {
            if (ModelState.IsValid)
            {
                db.Transactions.Add(transaction);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }
        }


    }
}
