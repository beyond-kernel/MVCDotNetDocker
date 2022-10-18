using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mvc1.Models;

namespace mvc1.Controllers;

public class HomeController : Controller
{
    private IRepository _repository;
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger, IRepository repo)
    {
        _logger = logger;
        _repository = repo;
    }

    public IActionResult Index()
    {
        return View(_repository.Produtos);
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
