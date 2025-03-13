using Microsoft.AspNetCore.Mvc;
using Repositories;
using Services.Contracts;

namespace StoreApp.Components
{
    public class ProductSummaryViewComponent : ViewComponent
    {
        private readonly IServicesManager _context;

        public ProductSummaryViewComponent(IServicesManager context)
        {
            _context = context;
        }

        public string Invoke()
        {
            //service
            return _context.ProductService.GetAllProducts(false).Count().ToString();
        }
    }
    
}