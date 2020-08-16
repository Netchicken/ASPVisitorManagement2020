using ASPVisitorManagement2020.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.IO;

namespace ASPVisitorManagement2020.Controllers
{
    public class HomeController : Controller
    {





        private readonly ILogger<HomeController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public HomeController(ILogger<HomeController> logger, IWebHostEnvironment webHostEnvironment)
        {
            _logger = logger;
            _webHostEnvironment = webHostEnvironment;
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


            //===============COA==============

            string webRootPath = _webHostEnvironment.WebRootPath;
            FileInfo filePath = new FileInfo(Path.Combine(webRootPath, "COA.txt"));
            string[] lines = System.IO.File.ReadAllLines(filePath.ToString());
            ViewData["Conditions"] = lines;




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
