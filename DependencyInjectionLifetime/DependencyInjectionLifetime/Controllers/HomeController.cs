using DependencyInjectionLifetime.Models;
using DependencyInjectionLifetime.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionLifetime.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITransientService _transientService1;
        private readonly ITransientService _transientService2;
        private readonly IScopedService _scopedService1;
        private readonly IScopedService _scopedService2;
        private readonly ISingletonService _singletonService1;
        private readonly ISingletonService _singletonService2;

        public HomeController(ITransientService transientService1,ITransientService transientService2,
            IScopedService scopedService1,IScopedService scopedService2,ISingletonService singletonService1,
            ISingletonService singletonService2)
        {
            _transientService1 = transientService1;
            _transientService2 = transientService2;
            _singletonService1 = singletonService1;
            _singletonService2 = singletonService2;
            _scopedService1 = scopedService1;
            _scopedService2 = scopedService2;
        }

        public IActionResult Index()
        {
            ViewBag.transient1 = _transientService1.GetID().ToString();
            ViewBag.transient2 = _transientService2.GetID().ToString();
            ViewBag.scoped1 = _scopedService1.GetID().ToString();
            ViewBag.scoped2 = _scopedService2.GetID().ToString();
            ViewBag.singleton1 = _singletonService1.GetID().ToString();
            ViewBag.singleton2 = _singletonService2.GetID().ToString();
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
