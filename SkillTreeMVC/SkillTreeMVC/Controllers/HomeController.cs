using SkillTreeMVC.Models;
using SkillTreeMVC.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SkillTreeMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly AccountingService _accountingService;

        public HomeController()
        {
            _accountingService = new AccountingService();
        }

        public ActionResult Index()
        {
            
            return View();
        }

        [ChildActionOnly]
        public ActionResult _AccountingList()
        {
            return PartialView(_accountingService.Lookup());
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