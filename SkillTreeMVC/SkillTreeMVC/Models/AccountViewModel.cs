using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
        [Required]
        [Display(Name = "類別")]
        public string Category { get; set; }
        /// <summary>
        /// 金額
        /// </summary>
        [Required]
        [Display(Name = "金額")]
        [Range(0, int.MaxValue)]
        [Remote("CheckInt", "Home", ErrorMessage = "tttt")]
        public int Amount { get; set; }
        /// <summary>
        /// 日期
        /// </summary>
        [Required]
        [Display(Name = "日期")]
        [Remote("CheckDateLessThanToday", "Home", ErrorMessage = "日期不可大於今天")]
        public DateTime Date { get; set; }
        /// <summary>
        /// 備註
        /// </summary>
        [Required]
        [Display(Name = "備註")]
        [StringLength(100)]
        public string Note { get; set; }
    }
}