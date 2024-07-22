
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
    private readonly IHttpContextAccessor _contextAccessor;
    private readonly IUsuarioDAO _usuarioDAO;  
    private readonly UserManager<IdentityUser> _userManager;

    public HomeController(ILogger<HomeController> logger, IConfiguration config, IUsuarioDAO usuario, UserManager<IdentityUser> userManager)
    {
        _logger = logger;
        _configuration = config;    
        _contextAccessor = new HttpContextAccessor(); // ? es necesario, quiero comprobar si el usuario sigue logeado o se ha logeado para acceder a adminpanel
        _usuarioDAO = usuario;
        _userManager = userManager; 
    }

    public async Task<IActionResult> Login(LoginViewModel model)
    {
        if (ModelState.IsValid)
        {
            var user = await _userManager.FindByNameAsync(model.email);
            if (user != null && await _userManager.CheckPasswordAsync(user, model.password))
            {
                // Valid credentials, sign in the user (e.g., create a cookie or token)
                return RedirectToAction("AdminPanel", "Home");  // Redirect to home page after login
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Invalid username or password.");
            }
        }

        return View();
    }







    public IActionResult Index()
    {
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
