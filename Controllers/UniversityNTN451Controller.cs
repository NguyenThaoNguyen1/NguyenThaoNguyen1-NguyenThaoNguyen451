using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NguyenThaoNguyen451.Models;

namespace NguyenThaoNguyen451.Controllers
{
    public class UniversityNTN451Controller : Controller
    {
        private readonly ApplicationDbContext _context;

        public UniversityNTN451Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: UniversityNTN451
        public async Task<IActionResult> Index()
        {
              return _context.UniversityNTN451 != null ? 
                          View(await _context.UniversityNTN451.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.UniversityNTN451'  is null.");
        }

        // GET: UniversityNTN451/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.UniversityNTN451 == null)
            {
                return NotFound();
            }

            var universityNTN451 = await _context.UniversityNTN451
                .FirstOrDefaultAsync(m => m.UniversityId == id);
            if (universityNTN451 == null)
            {
                return NotFound();
            }

            return View(universityNTN451);
        }

        // GET: UniversityNTN451/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UniversityNTN451/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UniversityId,UniversityName")] UniversityNTN451 universityNTN451)
        {
            if (ModelState.IsValid)
            {
                _context.Add(universityNTN451);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(universityNTN451);
        }

        // GET: UniversityNTN451/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.UniversityNTN451 == null)
            {
                return NotFound();
            }

            var universityNTN451 = await _context.UniversityNTN451.FindAsync(id);
            if (universityNTN451 == null)
            {
                return NotFound();
            }
            return View(universityNTN451);
        }

        // POST: UniversityNTN451/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("UniversityId,UniversityName")] UniversityNTN451 universityNTN451)
        {
            if (id != universityNTN451.UniversityId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(universityNTN451);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UniversityNTN451Exists(universityNTN451.UniversityId))
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
            return View(universityNTN451);
        }

        // GET: UniversityNTN451/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.UniversityNTN451 == null)
            {
                return NotFound();
            }

            var universityNTN451 = await _context.UniversityNTN451
                .FirstOrDefaultAsync(m => m.UniversityId == id);
            if (universityNTN451 == null)
            {
                return NotFound();
            }

            return View(universityNTN451);
        }

        // POST: UniversityNTN451/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.UniversityNTN451 == null)
            {
                return Problem("Entity set 'ApplicationDbContext.UniversityNTN451'  is null.");
            }
            var universityNTN451 = await _context.UniversityNTN451.FindAsync(id);
            if (universityNTN451 != null)
            {
                _context.UniversityNTN451.Remove(universityNTN451);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UniversityNTN451Exists(string id)
        {
          return (_context.UniversityNTN451?.Any(e => e.UniversityId == id)).GetValueOrDefault();
        }
    }
}
