using Services.Contracts;

namespace Services
{
    public class ServiceManager : IServicesManager
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public ServiceManager(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public IProductService ProductService => _productService;

        public ICategoryService CategoryService =>  _categoryService;
    }
}