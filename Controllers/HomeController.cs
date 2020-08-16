using Microsoft.AspNetCore.Mvc;

namespace netcoreapp3_template.Controllers {
    public class HomeController : Controller {
        public IActionResult Index() => View();
    }
}