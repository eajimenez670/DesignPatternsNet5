using DesignPatternsASPNET.Configuration;
using DesignPatternsASPNET.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Diagnostics;
using Tools;
using DesignPatterns.Models.Data;
using DesignPatterns.Repository;

namespace DesignPatternsASPNET.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOptions<MyConfig> _options;
        private readonly IRepository<Beer> _repositoryBeer;

        public HomeController(IOptions<MyConfig> options, IRepository<Beer> repositoryBeer)
        {
            _options = options;
            _repositoryBeer = repositoryBeer;
        }

        public IActionResult Index()
        {
            Log.GetInstance(_options.Value.PathLog).WriteLog("Ha ingresado al Index");

            IEnumerable<Beer> lst = _repositoryBeer.Get();
            return View("Index", lst);
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
