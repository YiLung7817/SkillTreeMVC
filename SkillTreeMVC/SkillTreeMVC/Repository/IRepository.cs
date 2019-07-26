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
        /// <summary>
        /// 取得所有資料
        /// </summary>
        /// <returns></returns>
        IQueryable<T> LookupAll();

        /// <summary>
        /// 取得條件下所有資料
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        IQueryable<T> Query(Expression<Func<T, bool>> filter);
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity"></param>
        void Add(T entity);
    }
}
