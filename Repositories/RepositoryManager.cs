using Repositories.Contracts;

namespace Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;

        public RepositoryManager(IProductRepository productRepository,
         RepositoryContext repositoryContext,
          ICategoryRepository categoryRepository)
        {
            _repositoryContext = repositoryContext;
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }

        public IProductRepository Product => _productRepository;

        public ICategoryRepository Category => _categoryRepository;

        public void Save()
        {
            _repositoryContext.SaveChanges();
        }
    }
}