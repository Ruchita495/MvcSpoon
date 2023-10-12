using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcSpoon.Data;
using MvcSpoon.Models;

namespace MvcSpoon.Controllers
{
    public class SpoonsController : Controller
    {
        private readonly MvcSpoonContext _context;

        public SpoonsController(MvcSpoonContext context)
        {
            _context = context;
        }

        // GET: Spoons
        public async Task<IActionResult> Index(string searchString)
        {
            // add search fecility so user can search with Type field
            var spoons = from s in _context.Spoons
                         select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                spoons = spoons.Where(se => se.Type.Contains(searchString));
            }
            return View(await spoons.ToListAsync());
        }

        // GET: Spoons/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var spoons = await _context.Spoons
                .FirstOrDefaultAsync(m => m.Id == id);
            if (spoons == null)
            {
                return NotFound();
            }

            return View(spoons);
        }

        // GET: Spoons/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Spoons/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Type,Size,Price,Material,Use,Rating")] Spoons spoons)
        {
            if (ModelState.IsValid)
            {
                _context.Add(spoons);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(spoons);
        }

        // GET: Spoons/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var spoons = await _context.Spoons.FindAsync(id);
            if (spoons == null)
            {
                return NotFound();
            }
            return View(spoons);
        }

        // POST: Spoons/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Type,Size,Price,Material,Use,Rating")] Spoons spoons)
        {
            if (id != spoons.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(spoons);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SpoonsExists(spoons.Id))
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
            return View(spoons);
        }

        // GET: Spoons/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var spoons = await _context.Spoons
                .FirstOrDefaultAsync(m => m.Id == id);
            if (spoons == null)
            {
                return NotFound();
            }

            return View(spoons);
        }

        // POST: Spoons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var spoons = await _context.Spoons.FindAsync(id);
            _context.Spoons.Remove(spoons);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SpoonsExists(int id)
        {
            return _context.Spoons.Any(e => e.Id == id);
        }
    }
}
