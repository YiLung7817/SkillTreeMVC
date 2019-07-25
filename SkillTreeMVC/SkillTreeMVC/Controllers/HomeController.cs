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
        /// <summary>
        /// 驗證日期不可大於今天
        /// </summary>
        /// <param name="date">日期</param>
        /// <returns></returns>
        public ActionResult CheckDateLessThanToday(DateTime? date)
        {
            var isValidate = false;
            if (date != null)
            {
                isValidate = date <= DateTime.Now;
            }
            return Json(isValidate, JsonRequestBehavior.AllowGet);
        }
        /// <summary>
        /// 驗證金額是否為正整數
        /// </summary>
        /// <param name="amount">金額</param>
        /// <returns></returns>
        public ActionResult CheckInt(string amount)
        {
            if (amount.Length >= 2 && amount.IndexOf("0") == 0)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(int.TryParse(amount, out int result), JsonRequestBehavior.AllowGet);
            }
        }
    }
}