using Microsoft.AspNetCore.Mvc;
using ShoppingListApp.Contracts;

namespace ShoppingListApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService productService;

        public ProductController(IProductService _productService)
        {
            productService = _productService;
        }

        public async Task<IActionResult> All()
        {
            var model = await productService.GetAllAsync();

            return View(model);
        }

        public IActionResult Add()
        {
            return RedirectToAction(nameof(All));
        }

        public IActionResult Edit()
        {
            return RedirectToAction(nameof(All));
        }

        public IActionResult Delete()
        {
            return RedirectToAction(nameof(All));
        }
    }
}
