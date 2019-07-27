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

        public AccountingService(IUnitOfWork unitOfWork)
        {
            _accountingRepository = new Repository<AccountBook>(unitOfWork);
        }
        /// <summary>
        /// 取得記帳本所有資料
        /// </summary>
        /// <returns></returns>
        public IEnumerable<AccountingViewModel> Lookup()
        {
            var accountingList = _accountingRepository.LookupAll().AsEnumerable().OrderByDescending(d => d.Dateee).Select(d => new AccountingViewModel()
            {
                Num = d.Id,
                Category = (CategoryType)d.Categoryyy,
                Amount = d.Amounttt,
                Date = d.Dateee,
                Note = d.Remarkkk
            });
            return accountingList;
        }

        public void Add(AccountingViewModel accountViewModel)
        {
            var accountBook = new AccountBook() {
                Id = Guid.NewGuid(),
                Amounttt = accountViewModel.Amount,
                Categoryyy = (int)accountViewModel.Category,
                Dateee = accountViewModel.Date,
                Remarkkk = accountViewModel.Note
            };
            _accountingRepository.Add(accountBook);

        }
    }
}