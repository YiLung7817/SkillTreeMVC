using SkillTreeMVC.Models;
using SkillTreeMVC.Repository;
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
        private readonly UnitOfWork _unitOfWork;
        public HomeController()
        {
            _unitOfWork = new UnitOfWork();
            _accountingService = new AccountingService(_unitOfWork);
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