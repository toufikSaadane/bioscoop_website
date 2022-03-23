using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using website.Data;
using Microsoft.AspNetCore.Mvc;
using website.Models;
using Microsoft.EntityFrameworkCore;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace website.Controllers
{
    public class TicketController : Controller
    {
        private readonly CinemaContext _context;

        public TicketController(CinemaContext context)
        {
            _context = context;
        }

        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            var tickets = await (from ticket in _context.Tickets
                                 where ticket.Performances.Any()
                                 select ticket).Include(p =>
                                     p.Performances.Where(a =>
                                             a.startTime >= DateTime.Now && a.startTime <= DateTime.Today.AddDays(5)).OrderBy(o => o.startTime))
                                                .ThenInclude(performance => performance.Hall)
                                                .ToListAsync();

            return View(tickets);
        }

        // GET: /<controller>/
        public async Task<IActionResult> Show(int? id)
        {
            if (id == null) { return NotFound(); }
            var ticket = await _context.Tickets.FindAsync(id.Value);
            if (ticket == null) { return NotFound(); }
            return View(ticket);
        }
    }
}
