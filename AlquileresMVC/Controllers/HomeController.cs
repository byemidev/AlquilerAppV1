
using AlquileresMVC.Models.Admin;
using AlquileresMVC.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AlquileresMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IConfiguration _configuration;
    private readonly IIndexDAO _indexDAO;  
    
    public HomeController(ILogger<HomeController> logger, IConfiguration config, IIndexDAO indexDAO)
    {
        _logger = logger;
        _configuration = config;    
        _indexDAO = indexDAO;
    }
    public IActionResult Index()
    {
        var items = _indexDAO.GetVehiculos();   
        return View(items);
    }

    public IActionResult Login() { 
        return View();
    }

    public IActionResult Vehiculo()
    {
        return View();
    }

    // [Authorize] Para hacer pruebas del CRUD lo desactivo.
    public IActionResult AdminPanel()
    {
        return View();
    }

    
    //TODO: Cargar desde IIndexDAO los vehiculos metodos de pago y extras para mostrarlo en las respectivas vistas / reendiracion 
    
}
