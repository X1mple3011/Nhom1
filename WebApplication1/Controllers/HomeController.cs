using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
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

        public IActionResult Login()
        {
            return View("~/Views/Login/Login.cshtml");
        }

        public IActionResult Register()
        {
            return View("~/Views/Login/Register.cshtml");
        }
        public IActionResult Course()
        {
            return View("~/Views/Course/Course.cshtml");
        }

        public IActionResult CourseDetail()
        {
            return View("~/Views/Course/CourseDetail.cshtml");
        }

        public IActionResult CourseDetail_Lesson()
        {
            return View("~/Views/Course/CourseDetail_Lesson.cshtml");
        }
        public IActionResult Blog()
        {
            return View("~/Views/Blog/Blog.cshtml");

        }

        public IActionResult BlogDetail()
        {
            return View("~/Views/Blog/detailBlog.cshtml");

        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}