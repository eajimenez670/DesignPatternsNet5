using DesignPatterns.Repository;
using DesignPatternsASPNET.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsASPNET.Controllers
{
    public class BeerController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public BeerController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            IEnumerable<BeerViewModel> beers = from b in _unitOfWork.Beers.Get()
                                               select new BeerViewModel
                                               {
                                                   Id = b.Id,
                                                   Name = b.Name,
                                                   Style = b.Style
                                               };
            return View("Index", beers);
        }
    }
}
