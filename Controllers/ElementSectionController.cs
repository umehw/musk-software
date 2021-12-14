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
  public class ElementSectionController : Controller
  {
    private readonly DBContext _context;

    public ElementSectionController(DBContext context)
    {
      _context = context;
    }

    // GET: ElementSection
    public async Task<IActionResult> Index()
    {
      return View(await _context.ElementSection.ToListAsync());
    }

    // GET: ElementSection/Details/5
    public async Task<IActionResult> Details(int? id)
    {
      if (id == null)
      {
        return NotFound();
      }

      var elementSection = await _context.ElementSection
          .FirstOrDefaultAsync(m => m.ElementSectionId == id);
      if (elementSection == null)
      {
        return NotFound();
      }

      return View(elementSection);
    }

    // GET: ElementSection/Create
    public IActionResult Create()
    {
      return View();
    }

    // POST: ElementSection/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("ElementSectionId,Name,ElementHeaderId")] ElementSection elementSection)
    {
      if (ModelState.IsValid)
      {
        _context.Add(elementSection);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
      }
      return View(elementSection);
    }

    // GET: ElementSection/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
      if (id == null)
      {
        return NotFound();
      }

      var elementSection = await _context.ElementSection.FindAsync(id);
      if (elementSection == null)
      {
        return NotFound();
      }
      return View(elementSection);
    }

    // POST: ElementSection/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, [Bind("ElementSectionId,Name,ElementHeaderId")] ElementSection elementSection)
    {
      if (id != elementSection.ElementSectionId)
      {
        return NotFound();
      }

      if (ModelState.IsValid)
      {
        try
        {
          _context.Update(elementSection);
          await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
          if (!ElementSectionExists(elementSection.ElementSectionId))
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
      return View(elementSection);
    }

    // GET: ElementSection/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
      if (id == null)
      {
        return NotFound();
      }

      var elementSection = await _context.ElementSection
          .FirstOrDefaultAsync(m => m.ElementSectionId == id);
      if (elementSection == null)
      {
        return NotFound();
      }

      return View(elementSection);
    }

    // POST: ElementSection/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
      var elementSection = await _context.ElementSection.FindAsync(id);
      _context.ElementSection.Remove(elementSection);
      await _context.SaveChangesAsync();
      return RedirectToAction(nameof(Index));
    }

    private bool ElementSectionExists(int id)
    {
      return _context.ElementSection.Any(e => e.ElementSectionId == id);
    }
  }
}
