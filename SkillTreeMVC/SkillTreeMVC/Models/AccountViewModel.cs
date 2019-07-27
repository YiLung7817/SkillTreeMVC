using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SkillTreeMVC.Models
{

    public enum CategoryType
    {
        expense = 0,
        income = 1
    }
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
        public CategoryType Category { get; set; }
        /// <summary>
        /// 金額
        /// </summary>
        [Required]
        [Display(Name = "金額")]
        [Range(0, int.MaxValue)]
        [Remote("CheckInt", "Home", ErrorMessage = "「金額」只能輸入正整數")]
        public int Amount { get; set; }
        /// <summary>
        /// 日期
        /// </summary>
        [Required]
        [Display(Name = "日期")]
        [Remote("CheckDateLessThanToday", "Home", ErrorMessage = "「日期」不可大於今天")]
        public DateTime Date { get; set; }
        /// <summary>
        /// 備註
        /// </summary>
        [Required]
        [Display(Name = "備註")]
        [StringLength(100, ErrorMessage = "「備註」最多輸入100個字元")]
        public string Note { get; set; }
    }
}