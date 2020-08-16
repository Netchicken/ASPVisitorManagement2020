using ASPVisitorManagement2020.Business;
using ASPVisitorManagement2020.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.IO;

namespace ASPVisitorManagement2020.Controllers
{
    public class HomeController : Controller
    {
                private readonly ILogger<HomeController> _logger;

        private ITextFileOperations _textFileOperations;


        public HomeController(ILogger<HomeController> logger, ITextFileOperations textFileOperations)
        {
            _logger = logger;
            _textFileOperations = textFileOperations;
        }

        public IActionResult Index()
        {

            ViewBag.Welcome = "Welcome to the Visitor Management System V2";

            ViewBag.NewVisitor = new Visitor()
            {

                FirstName = "Howard",
                LastName = "Davis"

            };

            ViewData["Welcome2"] = "This is another welcome";


          
            ViewData["Conditions"] = _textFileOperations.LoadConditionsForAcceptanceText();




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

    public interface IWebHostingEnvironment
    {
    }
}
