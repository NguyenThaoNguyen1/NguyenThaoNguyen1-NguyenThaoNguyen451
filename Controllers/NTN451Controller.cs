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
    public class NTN451Controller : Controller
    {
        private readonly ApplicationDbContext _context;

        public NTN451Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: NTN451
        public async Task<IActionResult> Index()
        {
              return _context.NTN451 != null ? 
                          View(await _context.NTN451.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.NTN451'  is null.");
        }

        // GET: NTN451/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.NTN451 == null)
            {
                return NotFound();
            }

            var nTN451 = await _context.NTN451
                .FirstOrDefaultAsync(m => m.NTNId == id);
            if (nTN451 == null)
            {
                return NotFound();
            }

            return View(nTN451);
        }

        // GET: NTN451/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NTN451/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NTNId,NTNName")] NTN451 nTN451)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nTN451);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nTN451);
        }

        // GET: NTN451/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.NTN451 == null)
            {
                return NotFound();
            }

            var nTN451 = await _context.NTN451.FindAsync(id);
            if (nTN451 == null)
            {
                return NotFound();
            }
            return View(nTN451);
        }

        // POST: NTN451/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("NTNId,NTNName")] NTN451 nTN451)
        {
            if (id != nTN451.NTNId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nTN451);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NTN451Exists(nTN451.NTNId))
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
            return View(nTN451);
        }

        // GET: NTN451/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.NTN451 == null)
            {
                return NotFound();
            }

            var nTN451 = await _context.NTN451
                .FirstOrDefaultAsync(m => m.NTNId == id);
            if (nTN451 == null)
            {
                return NotFound();
            }

            return View(nTN451);
        }

        // POST: NTN451/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.NTN451 == null)
            {
                return Problem("Entity set 'ApplicationDbContext.NTN451'  is null.");
            }
            var nTN451 = await _context.NTN451.FindAsync(id);
            if (nTN451 != null)
            {
                _context.NTN451.Remove(nTN451);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NTN451Exists(string id)
        {
          return (_context.NTN451?.Any(e => e.NTNId == id)).GetValueOrDefault();
        }
    }
}
