using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication7.data;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class HomeController : Controller
    {
       

        private readonly AppDbcontext _appDbcontext;
        public HomeController(AppDbcontext appDbcontext)
        {
            _appDbcontext = appDbcontext;
        }

        public IActionResult Index()
        {
            var repon= _appDbcontext.Departments.ToList();
            return View(repon);
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
