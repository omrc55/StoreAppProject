using Microsoft.AspNetCore.Mvc;

namespace StoreApp.Components.Product
{
    public class ProductFilterMenuViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
