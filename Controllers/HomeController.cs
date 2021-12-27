using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Clase3Mvc.Models;

namespace Clase3Mvc.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly List<Users> _users;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        _users = new List<Users>();
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Users(){
        _users.Add(new Users(1, "Juan Carlos", "Pereyra", 35));
        _users.Add(new Users(2, "Eduardo Fabian", "Sosa", 29));
        _users.Add(new Users(3, "Luciano", "Ramirez", 54));
        return View(_users);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
