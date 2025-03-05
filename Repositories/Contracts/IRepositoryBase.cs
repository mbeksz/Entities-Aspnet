using System.Linq.Expressions;

namespace Repositories.Contracts
{
    public interface IRepositoryBase<T>
     {

    IQueryable<T> FindAll(bool trackChanges);

    T? findByCondition(Expression<Func<T, bool>> expression, bool trackChanges);
    }
    
}