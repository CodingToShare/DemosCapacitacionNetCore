using Microsoft.AspNetCore.Mvc;
using PatronRepository.Interfaces;
using PatronRepository.Models;
using PatronRepository.Repository;
using System.Diagnostics;
using System.Security.Cryptography.Xml;

namespace PatronRepository.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStudentRepository _studentRepository;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _studentRepository = new StudentRepository(new Data.DataContext());
        }

        public IActionResult Index()
        {

            var students = from s in _studentRepository.GetStudents()
                           select s;


            return View(students);

           
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