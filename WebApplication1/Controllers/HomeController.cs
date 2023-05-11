using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ITransient _transient;
        private readonly ISingleton _singlenton;
        private readonly IScoped _scoped;


        public HomeController(ILogger<HomeController> logger, ITransient transient, ISingleton singlenton, IScoped scoped)
        {
            _logger = logger;
            _transient = transient;
            _scoped = scoped;
            _singlenton= singlenton;
        }

        public IActionResult Index()
        {
            ViewBag.transiet = _transient;
            ViewBag.scoped = _scoped;
            ViewBag.singleton  = _singlenton;

            return View();
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
}