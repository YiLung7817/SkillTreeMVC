using SkillTreeMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace SkillTreeMVC.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbContext _dbContext;
        public Repository() {
            _dbContext = new SkillTreeHomeworkEntities();
        }
        public IQueryable<T> LookupAll()
        {
            return _dbContext.Set<T>();
        }

        public IQueryable<T> Query(Expression<Func<T, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}