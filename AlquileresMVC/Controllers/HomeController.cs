using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AlquileresMVC.Models;

namespace AlquileresMVC.Controllers;

public class HomeController : Controller
{
  
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

}
