using Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class, new()
    {
        protected readonly RepositoryContext _repositoryContext;

        protected RepositoryBase(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public void Create(T entity)
        {
            _repositoryContext.Set<T>().Add(entity);
        }

        public IQueryable<T> FindAll(bool trackChanges)
        {
            return trackChanges ? _repositoryContext.Set<T>()
                                : _repositoryContext.Set<T>().AsNoTracking();
        }

        public T? findByCondition(Expression<Func<T, bool>> expression, bool trackChanges)
        {
           return trackChanges ? _repositoryContext.Set<T>().FirstOrDefault(expression)
                                : _repositoryContext.Set<T>().AsNoTracking().FirstOrDefault(expression);
        }

        public void Remove(T entity)
        {
            _repositoryContext.Set<T>().Remove(entity);
        }
    }
}