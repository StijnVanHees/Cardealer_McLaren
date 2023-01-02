using McLaren_Cardealer.Data;
using McLaren_Cardealer.Models;
using McLaren_Cardealer.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace McLaren_Cardealer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CardealerContext _context;

        public HomeController(ILogger<HomeController> logger, CardealerContext context)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            HomeViewModel hvm = new HomeViewModel()
            {
                autos = _context.Autos.ToList()
            };
            return View(hvm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateBericht(HomeViewModel cbvm)
        {
            if (ModelState.IsValid)
            {
                if (!string.IsNullOrEmpty(cbvm.Email))
                {
                    _context.Add(new Bericht()
                    {
                        Email = cbvm.Email,
                        Message = cbvm.Message
                    });
                }
                else
                {
                    _context.Add(new Bericht()
                    {
                        Email = "anonymously",
                        Message = cbvm.Message
                        
                    });
                }

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }
            return View(cbvm);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Info()
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
