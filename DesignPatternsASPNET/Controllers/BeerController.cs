using DesignPatterns.Models.Data;
using DesignPatterns.Repository;
using DesignPatternsASPNET.Models.ViewModels;
using DesignPatternsASPNET.Strategies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        [HttpGet]
        public IActionResult Add()
        {
            GetBrands();
            return View();
        }

        [HttpPost]
        public IActionResult Add(FormBeerViewModel formBeerVM)
        {
            if (!ModelState.IsValid)
            {
                GetBrands();
                return View("Add", formBeerVM);
            }

            var beerContext = (formBeerVM.BrandId == null) ?
                              new BeerContext(new BeerWithoutBrandStrategy()) :
                              new BeerContext(new BeerWithBrandStrategy());

            beerContext.Add(formBeerVM, _unitOfWork);

            return RedirectToAction("Index");
        }

        #region Helpers
        private void GetBrands()
        {
            var brands = _unitOfWork.Brands.Get();
            ViewBag.Brands = new SelectList(brands, "Id", "Name");
        }
        #endregion
    }
}
