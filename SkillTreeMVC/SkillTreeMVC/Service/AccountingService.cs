using SkillTreeMVC.Models;
using SkillTreeMVC.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SkillTreeMVC.Service
{
    
    public class AccountingService
    {
        private readonly IRepository<AccountBook> _accountingRepository;

        public AccountingService()
        {
            _accountingRepository = new Repository<AccountBook>();
        }

        public IEnumerable<AccountingViewModel> Lookup()
        {
            var accountingList = _accountingRepository.LookupAll().OrderByDescending(d => d.Dateee).Select(d => new AccountingViewModel()
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