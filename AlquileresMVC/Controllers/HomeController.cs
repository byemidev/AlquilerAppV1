
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
    private readonly IUsuarioDAO _usuarioDAO;  
    
    public HomeController(ILogger<HomeController> logger, IConfiguration config, IUsuarioDAO usuario)
    {
        _logger = logger;
        _configuration = config;    
        _usuarioDAO = usuario;
    }

    


    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Login() { 
        return View();
    }

    public IActionResult Vehiculo()
    {
        return View();
    }

    [Authorize]
    public IActionResult AdminPanel()
    {
        return View();
    }

    
    //TODO: Cargar desde IIndexDAO los vehiculos metodos de pago y extras para mostrarlo en las respectivas vistas / reendiracion 
    
}
