using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Repositories.Contracts;

namespace StoreApp.Controllers
{
    public class CategoryController : Controller
    {

        private IRepositoryManager _repositoryManager;

        public CategoryController(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        public IActionResult Index()
        {
            var categories = _repositoryManager.Category.GetAllCategories(false);
            return View(categories);
        }
    }
}