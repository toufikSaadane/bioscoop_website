using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using website.Data;
using Microsoft.AspNetCore.Mvc;
using website.Models;
using Microsoft.EntityFrameworkCore;
using website.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        public async Task<IActionResult> Index(string genre, string score, int age, string language)
        {
            var movies = (from movie in _context.Movies
                          where movie.Performances.Any()
                          select movie);

            if (!string.IsNullOrEmpty(genre) && "0" != genre)
            {
                movies = movies.Where(movie => movie.Genre.Contains(genre));
            }

            if (!string.IsNullOrEmpty(score))
            {
                movies = score == "desc" ? movies.OrderByDescending(movie => movie.Score) : movies.OrderBy(movie => movie.Score);
            }

            if (age != null)
            {
                movies = movies.Where(movie => movie.MinimalAge >= age);
            }

            if (!string.IsNullOrEmpty(language) && "0" != language)
            {
                movies = movies.Where(movie => movie.Language.Equals(language));
            }

            var movieList = await movies.Include(p =>
                              p.Performances.Where(a =>
                                      a.startTime >= DateTime.Now && a.startTime <= DateTime.Today.AddDays(5)).OrderBy(o => o.startTime))
                                                .ThenInclude(performance => performance.Hall).ToListAsync();

            ViewData["genre"] = genre;
            ViewData["age"] = age.ToString();
            ViewData["score"] = score;
            ViewData["language"] = language;


            return View(movieList);
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