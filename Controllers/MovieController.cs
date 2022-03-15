using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using website.Data;
using Microsoft.AspNetCore.Mvc;
using website.Models;
using Microsoft.EntityFrameworkCore;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace avansTeam.Controllers
{
    public class MovieController : Controller
    {
        private readonly CinemaContext _context;

        public MovieController(CinemaContext context)
        {
            _context = context;
        }

        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            var movies = await (from movie in _context.Movies
                                where movie.Performances.Any()
                                select movie).Include(p =>
                                    p.Performances.Where(a =>
                                            a.startTime >= DateTime.Now && a.startTime <= DateTime.Today.AddDays(5)).OrderBy(o => o.startTime))
                                                .ThenInclude(performance => performance.Hall)
                                                .ToListAsync();

            return View(movies);
        }

        // GET: /<controller>/
        public async Task<IActionResult> Show(int? id)
        {
            if (id == null) { return NotFound(); }
            var movie = await _context.Movies.FindAsync(id.Value);
            if (movie == null) { return NotFound(); }
            return View(movie);
        }

    }
}