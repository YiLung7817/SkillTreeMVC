using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SkillTreeMVC.Repository
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> LookupAll();

        IQueryable<T> Query(Expression<Func<T, bool>> filter);


    }
}
