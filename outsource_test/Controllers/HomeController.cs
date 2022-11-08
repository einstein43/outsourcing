using Microsoft.AspNetCore.Mvc;
using outsource_test.Models;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace outsource_test.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public SurveyScoreModel SurveyScore { get; set; }
        public IActionResult OnPost()
        {
            int leadership, overallImpression, tidiness, punctuality, happiness, discipline, creativity, ambition;
            leadership = +Int32.Parse(Request.Form["q1"]);
            overallImpression = +Int32.Parse(Request.Form["q2"]);
            tidiness =+ Int32.Parse(Request.Form["q3"]);
            punctuality = +Int32.Parse(Request.Form["q4"]);
            happiness = +Int32.Parse(Request.Form["q5"]);
            discipline = +Int32.Parse(Request.Form["q6"]);
            creativity = +Int32.Parse(Request.Form["q7"]);
            ambition = +Int32.Parse(Request.Form["q8"]);
            leadership = +Int32.Parse(Request.Form["q9"]);
            overallImpression = +Int32.Parse(Request.Form["q10"]);
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