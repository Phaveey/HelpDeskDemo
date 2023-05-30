using HelpDeskDemo.Application.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskDemo.Persistence.Common
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected RepositoryContext RepositoryContext;

        public RepositoryBase(RepositoryContext repositoryContext)
        {
           RepositoryContext = repositoryContext;
        }
        public void Create(T entity)
        {
            RepositoryContext.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            RepositoryContext.Set<T>().Remove(entity);
        }

        public IQueryable<T> FindAllAsync(bool trackChanges)
        {
            return !trackChanges ?
                RepositoryContext.Set<T>()
                .AsNoTracking() :
                RepositoryContext.Set<T>();
        }

        public IQueryable<T> FindByConditionAsync(Expression<Func<T, bool>> condition, bool trackChanges)
        {
            return !trackChanges ?
                RepositoryContext.Set<T>()
                .Where(condition)
                .AsNoTracking() :
                RepositoryContext.Set<T>()
                .Where(condition);
        }

        public void Update(T entity)
        {
            RepositoryContext.Set<T>().Update(entity);
        }
    }
}
