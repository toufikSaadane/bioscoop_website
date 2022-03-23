using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using website.Data;
using website.Models;

namespace website.Controllers
{
    public class SnackController : Controller
    {
        private readonly ILogger<SnackController> _logger;
        private readonly CinemaContext _context;

        public SnackController(CinemaContext context, ILogger<SnackController> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var snacks = await _context.Snacks.Take(3).ToListAsync();

            return View(snacks);
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

        // GET: /<controller>/
        public async Task<IActionResult> Show(int? id)
        {
            if (id == null) { return NotFound(); }
            var snack = await _context.Snacks.FindAsync(id.Value);
            if (snack == null) { return NotFound(); }
            return View(snack);
        }
    }
}
