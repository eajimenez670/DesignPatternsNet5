using DesignPatternsASPNET.Configuration;
using DesignPatternsASPNET.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Diagnostics;
using Tools;

namespace DesignPatternsASPNET.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOptions<MyConfig> _options;

        public HomeController(IOptions<MyConfig> options)
        {
            _options = options;
        }

        public IActionResult Index()
        {
            Log.GetInstance(_options.Value.PathLog).WriteLog("Ha ingresado al Index");
            return View();
        }

        public IActionResult Privacy()
        {
            Log.GetInstance(_options.Value.PathLog).WriteLog("Ha ingresado al Privacy");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
