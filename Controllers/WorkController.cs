using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using aspprojekt.Data;
using aspprojekt.Models;

namespace aspprojekt.Controllers
{
    public class WorkController : Controller
    {
        private readonly WorkContext _context;

        public WorkController(WorkContext context)
        {
            _context = context;
        }

        // GET: Work
        public async Task<IActionResult> Index()
        {
            return View(await _context.Works.ToListAsync());
        }

        // GET: Work/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var works = await _context.Works
                .FirstOrDefaultAsync(m => m.WorkId == id);
            if (works == null)
            {
                return NotFound();
            }

            return View(works);
        }

        // GET: Work/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Work/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("WorkId,Company,WorkTitle,WorkLength,Description")] Works works)
        {
            if (ModelState.IsValid)
            {
                _context.Add(works);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(works);
        }

        // GET: Work/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var works = await _context.Works.FindAsync(id);
            if (works == null)
            {
                return NotFound();
            }
            return View(works);
        }

        // POST: Work/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("WorkId,Company,WorkTitle,WorkLength,Description")] Works works)
        {
            if (id != works.WorkId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(works);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WorksExists(works.WorkId))
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
            return View(works);
        }

        // GET: Work/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var works = await _context.Works
                .FirstOrDefaultAsync(m => m.WorkId == id);
            if (works == null)
            {
                return NotFound();
            }

            return View(works);
        }

        // POST: Work/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var works = await _context.Works.FindAsync(id);
            _context.Works.Remove(works);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WorksExists(int id)
        {
            return _context.Works.Any(e => e.WorkId == id);
        }
    }
}
