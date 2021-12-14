using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Software_Engineering_Assingment.Models;
using Software_Engineering_Assingment.ViewModels;

namespace Software_Engineering_Assingment.Controllers
{
  public class ReportController : Controller
  {
    private readonly DBContext _context;

    public ReportController(DBContext context)
    {
      _context = context;
    }

    // GET: Report
    public async Task<IActionResult> Index()
    {
      var dBContext = _context.Report.Include(r => r.Site).Include(r => r.User);
      return View(await dBContext.ToListAsync());
    }

    // GET: Report/Details/5
    public async Task<IActionResult> Details(int? id)
    {
      if (id == null)
      {
        return NotFound();
      }

      var report = await _context.Report
          .Include(r => r.Site)
          .Include(r => r.User)
          .Include(r => r.Elements).ThenInclude(e => e.ElementHeader.Name)
          .Include(r => r.Elements).ThenInclude(e => e.ElementSection.Name)
          .FirstOrDefaultAsync(m => m.ReportId == id);
      if (report == null)
      {
        return NotFound();
      }

      return View(report);
    }

    // GET: Report/Create
    public IActionResult Create()
    {
      ViewData["SiteId"] = new SelectList(_context.Site, "SiteId", "Name");
      ViewData["UserId"] = new SelectList(_context.User, "UserId", "Email");
      PopulateReportElements();
      return View();
    }

    private void PopulateReportElements()
    {
      var elementTuples = new List<Tuple<string, List<ReportElement>>>();
      var allElementHeaders = _context.ElementHeader.Include(elH => elH.ElementSections).ToList();
      foreach (var elementHeader in allElementHeaders)
      {
        var elements = new List<ReportElement>();
        var relatedElementSections = elementHeader.ElementSections;

        foreach (var elementSection in relatedElementSections)
        {
          elements.Add(new ReportElement
          {
            ElementHeaderId = elementHeader.ElementHeaderId,
            ElementSectionId = elementSection.ElementHeaderId,
            ElementSectionName = elementSection.Name,
            Interventions = 0,
            Comment = null,
            Completed = null
          });
        }


        elementTuples.Add(new Tuple<string, List<ReportElement>>(elementHeader.Name, elements));
      }

      ViewData["ElementTuples"] = elementTuples;
    }

    // POST: Report/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("ReportId,SiteId,WorkArea,Supervisor,JobDescription,UserId,InspectorId,Date,Type,CreatedAt")] Report report)
    {
      if (ModelState.IsValid)
      {
        _context.Add(report);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
      }
      ViewData["SiteId"] = new SelectList(_context.Site, "SiteId", "Name", report.SiteId);
      ViewData["UserId"] = new SelectList(_context.User, "UserId", "Email", report.UserId);
      PopulateReportElements();
      return View(report);
    }

    // GET: Report/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
      if (id == null)
      {
        return NotFound();
      }

      var report = await _context.Report.FindAsync(id);
      if (report == null)
      {
        return NotFound();
      }
      ViewData["SiteId"] = new SelectList(_context.Site, "SiteId", "Name", report.SiteId);
      ViewData["UserId"] = new SelectList(_context.User, "UserId", "Email", report.UserId);
      return View(report);
    }

    // POST: Report/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, [Bind("ReportId,SiteId,WorkArea,Supervisor,JobDescription,UserId,InspectorId,Date,Type,CreatedAt")] Report report)
    {
      if (id != report.ReportId)
      {
        return NotFound();
      }

      if (ModelState.IsValid)
      {
        try
        {
          _context.Update(report);
          await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
          if (!ReportExists(report.ReportId))
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
      ViewData["SiteId"] = new SelectList(_context.Site, "SiteId", "Name", report.SiteId);
      ViewData["UserId"] = new SelectList(_context.User, "UserId", "Email", report.UserId);
      return View(report);
    }

    // GET: Report/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
      if (id == null)
      {
        return NotFound();
      }

      var report = await _context.Report
          .Include(r => r.Site)
          .Include(r => r.User)
          .FirstOrDefaultAsync(m => m.ReportId == id);
      if (report == null)
      {
        return NotFound();
      }

      return View(report);
    }

    // POST: Report/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
      var report = await _context.Report.FindAsync(id);
      _context.Report.Remove(report);
      await _context.SaveChangesAsync();
      return RedirectToAction(nameof(Index));
    }

    private bool ReportExists(int id)
    {
      return _context.Report.Any(e => e.ReportId == id);
    }
  }
}
