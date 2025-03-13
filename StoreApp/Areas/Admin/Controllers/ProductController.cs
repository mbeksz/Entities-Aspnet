using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace StoreApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IServicesManager _servicesManager;

        public ProductController(IServicesManager servicesManager)
        {
            _servicesManager = servicesManager;
        }
        public IActionResult Index()
        {
            var products = _servicesManager.ProductService.GetAllProducts(false);
            return View(products);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([FromForm] Product product)
        {
            if (ModelState.IsValid)
            {
                _servicesManager.ProductService.CreateProduct(product);
                return RedirectToAction("Index");
            }
            return View();

        }

        public IActionResult Update([FromRoute(Name ="id")] int id)
        {
            var model = _servicesManager.ProductService.GetOneProduct(id, false);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Product product)
        {
            if (ModelState.IsValid)
            {
                _servicesManager.ProductService.UpdateOneProduct(product);
                return RedirectToAction("Index");
            }
            
            return View();
        }

        [HttpGet]
        
        public IActionResult Delete([FromRoute(Name = "id")] int id)
        {
             _servicesManager.ProductService.DeleteOneProduct(id);
            return RedirectToAction("Index");
        }
        
    }
}