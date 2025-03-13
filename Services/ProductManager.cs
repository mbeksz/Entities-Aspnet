using Entities.Models;
using Repositories.Contracts;
using Services.Contracts;

namespace Services
{
    public class ProductManager : IProductService
    {
        private readonly IRepositoryManager _repositoryManager;

        public ProductManager(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        public void CreateProduct(Product product)
        {
            _repositoryManager.Product.Create(product);
            _repositoryManager.Save();
        }

        public void DeleteOneProduct(int id)
        {
            var product = _repositoryManager.Product.GetOneProduct(id, false) ;
            if (product is not null)
            {
            _repositoryManager.Product.DeleteOneProduct(product);
            _repositoryManager.Save();
            }
        }

        public IEnumerable<Product> GetAllProducts(bool trackChanges)
        {
            return _repositoryManager.Product.GetAllProducts(trackChanges);
        }

        public Product? GetOneProduct(int id, bool trackChanges)
        {
            var product = _repositoryManager.Product.GetOneProduct(id, trackChanges);
            if (product == null)
            {
                throw new Exception("Product not found");
            }
            return product;
        }

        public void UpdateOneProduct(Product product)
        {
            var model = _repositoryManager.Product.GetOneProduct(product.ProductId, true);

            model.ProductName = product.ProductName;
            model.Price = product.Price;
            _repositoryManager.Save();
        }
        
    }
}