using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tools.Earn;

namespace DesignPatternsASPNET.Controllers
{
    public class ProductDetailController : Controller
    {
        private readonly EarnFactory _localEarnFactory;
        private readonly EarnFactory _foreignEarnFactory;

        public ProductDetailController(LocalEarnFactory localEarnFactory, ForeignEarnFactory foreignEarnFactory)
        {
            _localEarnFactory = localEarnFactory;
            _foreignEarnFactory = foreignEarnFactory;
        }

        public IActionResult Index(decimal total)
        {
            // Product
            IEarn localEarn = _localEarnFactory.GetEarn();
            IEarn foreignEarn = _foreignEarnFactory.GetEarn();

            // Total
            ViewBag.totalLocal = total + localEarn.Earn(total);
            ViewBag.totalForeign = total + foreignEarn.Earn(total);

            return View();
        }
    }
}
