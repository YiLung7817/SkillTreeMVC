using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using SkillTreeMVC.Models;

namespace SkillTreeMVC.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public DbContext Context { get; set; }

        public UnitOfWork()
        {
            Context = new SkillTreeHomeworkEntities();
        }

        public void Dispose()
        {
            Context.Dispose();
        }

        public void Commit()
        {
            Context.SaveChanges();
        }
    }
}