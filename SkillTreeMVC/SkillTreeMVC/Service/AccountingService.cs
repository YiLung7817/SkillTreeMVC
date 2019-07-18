using SkillTreeMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SkillTreeMVC.Service
{
    
    public class AccountingService
    {
        private readonly SkillTreeHomeworkEntities _db;
        public AccountingService()
        {
            _db = new SkillTreeHomeworkEntities();
        }

        public IEnumerable<AccountingViewModel> Lookup()
        {
            var accountingList = _db.AccountBook.OrderByDescending(d => d.Dateee).Select(d => new AccountingViewModel()
            {
                Type = d.Categoryyy.ToString(),
                Amount = d.Amounttt.ToString(),
                Date = d.Dateee,
                Note = d.Remarkkk
            });
            return accountingList;
        }
    }
}