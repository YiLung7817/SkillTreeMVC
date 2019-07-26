using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SkillTreeMVC.Helper
{
    public static class CategoryHelper
    {
        public static MvcHtmlString DisplayCategory(this HtmlHelper helper, int category)
        {

            if (category == 0)
            {
                return new MvcHtmlString("<span class='text-danger'>支出</span>");
            }
            return new MvcHtmlString("<span class='text-primary'>收入</span>");
        }
    }
    
}