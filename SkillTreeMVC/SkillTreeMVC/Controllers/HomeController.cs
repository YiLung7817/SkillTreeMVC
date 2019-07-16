using SkillTreeMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SkillTreeMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            
            return View();
        }

        [ChildActionOnly]
        public ActionResult _AccountingList()
        {
            List<AccountingViewModel> accountingList = new List<AccountingViewModel>();

            Random random = new Random();
            for (int i = 1; i <= 100; i++)
            {
                accountingList.Add(new AccountingViewModel()
                {
                    Num = i,
                    Type = random.Next(1, 3).ToString(),
                    Amount = random.Next(1, 10000).ToString("#,0"),
                    Date = DateTime.Now.AddDays(i),
                    Note = string.Empty
                });
            }
            return PartialView(accountingList);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}