using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using website.Data;
using website.Models;

namespace website.Controllers
{
    public class ArrangementController : Controller
    {
        private readonly CinemaContext _context;

        public ArrangementController(CinemaContext context)
        {
            _context = context;
        }

        // GET: Arrangement
        public async Task<IActionResult> Index()
        {
            var cinemaContext = _context.Arrangements.Include(a => a.Snack);
            return View(await cinemaContext.ToListAsync());
        }

        // GET: Arrangement/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var arrangement = await _context.Arrangements
                .Include(a => a.Snack)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (arrangement == null)
            {
                return NotFound();
            }

            return View(arrangement);
        }

        // GET: Arrangement/Create
        public IActionResult Create()
        {
            ViewData["SnackId"] = new SelectList(_context.Snacks, "Id", "Name");
            return View();
        }

        // POST: Arrangement/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description,Price,SnackId")] Arrangement arrangement)
        {
            if (ModelState.IsValid)
            {
                _context.Add(arrangement);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SnackId"] = new SelectList(_context.Snacks, "Id", "Name", arrangement.SnackId);
            return View(arrangement);
        }

        // GET: Arrangement/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var arrangement = await _context.Arrangements.FindAsync(id);
            if (arrangement == null)
            {
                return NotFound();
            }
            ViewData["SnackId"] = new SelectList(_context.Snacks, "Id", "Name", arrangement.SnackId);
            return View(arrangement);
        }

        // POST: Arrangement/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,Price,SnackId")] Arrangement arrangement)
        {
            if (id != arrangement.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(arrangement);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArrangementExists(arrangement.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["SnackId"] = new SelectList(_context.Snacks, "Id", "Id", arrangement.SnackId);
            return View(arrangement);
        }

        // GET: Arrangement/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var arrangement = await _context.Arrangements
                .Include(a => a.Snack)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (arrangement == null)
            {
                return NotFound();
            }

            return View(arrangement);
        }

        // POST: Arrangement/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var arrangement = await _context.Arrangements.FindAsync(id);
            _context.Arrangements.Remove(arrangement);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArrangementExists(int id)
        {
            return _context.Arrangements.Any(e => e.Id == id);
        }
    }
}
