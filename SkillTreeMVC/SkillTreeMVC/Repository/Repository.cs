using SkillTreeMVC.Repository;
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
        public IUnitOfWork UnitOfWork { get; set; }
        private DbSet<T> _objectSet;
        private DbSet<T> ObjectSet => _objectSet ?? (_objectSet = UnitOfWork.Context.Set<T>());

        public Repository(IUnitOfWork unitOfWork) {
            UnitOfWork = unitOfWork;
        }

        public IQueryable<T> LookupAll()
        {
            return ObjectSet;
        }


        public IQueryable<T> Query(Expression<Func<T, bool>> filter)
        {
            return ObjectSet.Where(filter);
        }

        public void Add(T Entity)
        {
            ObjectSet.Add(Entity);
        }
    }
}