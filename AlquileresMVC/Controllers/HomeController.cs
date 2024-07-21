using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AlquileresMVC.Models;
using AlquileresMVC.Models.user;
using System.Data.SqlClient;

namespace AlquileresMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IConfiguration _configuration;
    private readonly SqlConnection _connection; 

    private readonly List<carDescription> _descriptions;
    private readonly formRegistration _form;


    public HomeController(ILogger<HomeController> logger, IConfiguration config)
    {
        _logger = logger;
        _connection = new SqlConnection(config.GetConnectionString("DefaultConnection"));
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

    public IActionResult carDescription() {
        //TODO: send data from db
        return View(_descriptions);
    }
}
