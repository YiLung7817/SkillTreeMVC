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
        public int Num { get; set; }
        /// <summary>
        /// 類別
        /// </summary>
        public string Type { get; set; }
        public string TypeStr
        {
            get
            {
                switch (this.Type)
                {
                    case "1":
                        return "支出";
                    case "2":
                        return "收入";
                    default:
                        return string.Empty;
                }
            }
        }
        /// <summary>
        /// 金額
        /// </summary>
        public string Amount { get; set; }
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