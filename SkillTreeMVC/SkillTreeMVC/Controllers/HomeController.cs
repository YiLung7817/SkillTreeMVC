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
        private SkillTreeHomeworkEntities db = new SkillTreeHomeworkEntities();
        public ActionResult Index()
        {
            
            return View();
        }

        [ChildActionOnly]
        public ActionResult _AccountingList()
        {
            var accountingList = db.AccountBook.OrderByDescending(d=>d.Dateee).Select(d => new AccountingViewModel()
            {
                Type = d.Categoryyy.ToString(),
                Amount = d.Amounttt.ToString(),
                Date = d.Dateee,
                Note = d.Remarkkk
            }).ToList();

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