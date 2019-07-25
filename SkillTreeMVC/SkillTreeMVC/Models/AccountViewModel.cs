using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SkillTreeMVC.Models
{
    /// <summary>
    /// 記帳本
    /// </summary>
    public class AccountingViewModel
    {
        /// <summary>
        /// 流水號
        /// </summary>
        public Guid Num { get; set; }
        /// <summary>
        /// 類別
        /// </summary>
        public string Category { get; set; }
        /// <summary>
        /// 金額
        /// </summary>
        public int Amount { get; set; }
        /// <summary>
        /// 日期
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// 備註
        /// </summary>
        public string Note { get; set; }
    }
}