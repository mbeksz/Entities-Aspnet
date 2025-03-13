using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace StoreApp.Components
{
    public class CategoriesMenuViewComponent : ViewComponent
    {
        private readonly IServicesManager _context;

        public CategoriesMenuViewComponent(IServicesManager context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var model = _context.CategoryService.GetAllCategories(false);
            return View(model);
        }
    }
}