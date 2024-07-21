using Microsoft.AspNetCore.Mvc;

namespace AlquileresMVC.Controllers.Admin
{
    public class IndexAdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
