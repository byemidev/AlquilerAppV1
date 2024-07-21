
using Microsoft.AspNetCore.Mvc;

namespace AlquileresMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IConfiguration _configuration;
   

    public HomeController(ILogger<HomeController> logger, IConfiguration config)
    {
        _logger = logger;
        
    }

  
    public IActionResult Index()
    {
        return View();
    }


    public IActionResult Vehiculo()
    {
        return View();
    }

    public IActionResult LoginAdmin()
    {
        return View();
    }

    //custom logic
    //controller 

}
