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
    public class ArrangementController : Controller
    {
        private readonly ILogger<ArrangementController> _logger;
        private readonly CinemaContext _context;

        public ArrangementController(CinemaContext context, ILogger<ArrangementController> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var arrangements = await _context.Arrangements.Take(3).ToListAsync();
            var snacks = (from snack in _context.Snacks
                          where snack.Arrangements.Any()
                          select snack);

            return View(arrangements);
        }
    }
}
