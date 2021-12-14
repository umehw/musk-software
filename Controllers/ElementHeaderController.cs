using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Software_Engineering_Assingment.Models;

namespace Software_Engineering_Assingment.Controllers
{
    public class ElementHeaderController : Controller
    {
        private readonly DBContext _context;

        public ElementHeaderController(DBContext context)
        {
            _context = context;
        }

        // GET: ElementHeader
        public async Task<IActionResult> Index()
        {
            return View(await _context.ElementHeader.ToListAsync());
        }

        // GET: ElementHeader/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var elementHeader = await _context.ElementHeader
                .FirstOrDefaultAsync(m => m.ElementHeaderId == id);
            if (elementHeader == null)
            {
                return NotFound();
            }

            return View(elementHeader);
        }

        // GET: ElementHeader/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ElementHeader/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ElementHeaderId,Name")] ElementHeader elementHeader)
        {
            if (ModelState.IsValid)
            {
                _context.Add(elementHeader);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(elementHeader);
        }

        // GET: ElementHeader/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var elementHeader = await _context.ElementHeader.FindAsync(id);
            if (elementHeader == null)
            {
                return NotFound();
            }
            return View(elementHeader);
        }

        // POST: ElementHeader/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ElementHeaderId,Name")] ElementHeader elementHeader)
        {
            if (id != elementHeader.ElementHeaderId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(elementHeader);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ElementHeaderExists(elementHeader.ElementHeaderId))
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
            return View(elementHeader);
        }

        // GET: ElementHeader/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var elementHeader = await _context.ElementHeader
                .FirstOrDefaultAsync(m => m.ElementHeaderId == id);
            if (elementHeader == null)
            {
                return NotFound();
            }

            return View(elementHeader);
        }

        // POST: ElementHeader/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var elementHeader = await _context.ElementHeader.FindAsync(id);
            _context.ElementHeader.Remove(elementHeader);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ElementHeaderExists(int id)
        {
            return _context.ElementHeader.Any(e => e.ElementHeaderId == id);
        }
    }
}
