using Repositories.Contracts;

namespace Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;
        private readonly IProductRepository _productRepository;

        public RepositoryManager(IProductRepository productRepository , RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _productRepository = productRepository;
        }

        public IProductRepository Product => _productRepository;

        public void Save()
        {
          _repositoryContext.SaveChanges();
        }
    }
}