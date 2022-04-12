using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using website.Data;
using website.Models;

namespace website.Controllers
{
    public class EnqueteController : Controller
    {
        private readonly CinemaContext _context;

        public EnqueteController(CinemaContext context)
        {
            _context = context;
        }

        // GET: Enquete
        public async Task<IActionResult> Index()
        {
            return View(await _context.Enquetes.ToListAsync());
        }

        // GET: Enquete/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enquete = await _context.Enquetes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (enquete == null)
            {
                return NotFound();
            }

            return View(enquete);
        }

        // GET: Enquete/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Enquete/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description")] Enquete enquete)
        {
            if (ModelState.IsValid)
            {
                _context.Add(enquete);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(enquete);
        }

        // GET: Enquete/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enquete = await _context.Enquetes.FindAsync(id);
            if (enquete == null)
            {
                return NotFound();
            }
            return View(enquete);
        }

        // POST: Enquete/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description")] Enquete enquete)
        {
            if (id != enquete.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(enquete);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EnqueteExists(enquete.Id))
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
            return View(enquete);
        }

        // GET: Enquete/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enquete = await _context.Enquetes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (enquete == null)
            {
                return NotFound();
            }

            return View(enquete);
        }

        // POST: Enquete/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var enquete = await _context.Enquetes.FindAsync(id);
            _context.Enquetes.Remove(enquete);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EnqueteExists(int id)
        {
            return _context.Enquetes.Any(e => e.Id == id);
        }
    }
}
