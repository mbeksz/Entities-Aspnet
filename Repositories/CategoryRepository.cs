using Entities.Models;
using Repositories.Contracts;

namespace Repositories
{
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public IQueryable<Category> GetAllCategories(bool trackChanges) =>
            FindAll(trackChanges);

        public Category? GetOneCategory(int id, bool trackChanges)
        {
            throw new NotImplementedException();
        }
    }
}