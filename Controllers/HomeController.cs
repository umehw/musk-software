using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Software_Engineering_Assingment.Models;
using Microsoft.EntityFrameworkCore;
using Software_Engineering_Assingment.ViewModels;

namespace Software_Engineering_Assingment.Controllers
{
  public class HomeController : Controller
  {
    private readonly DBContext _context;

    public HomeController(DBContext context)
    {
      _context = context;
      GenerateReports();
    }

    private void GenerateReports()
    {
      var siteTotalsTableReport = _context.Report.Include(r => r.Site).Include(r => r.Elements).GroupBy(r => r.SiteId).Select(t => new
      {
        Key = t.Key,
        SiteName = t.First().Site.Name,
        Amount = t.Sum(ra => ra.Elements.Sum(el => el.Interventions))
      });
      ViewData["SiteTotalsTableReport"] = siteTotalsTableReport;

      /* Month vs sitename */
      var list = _context.Report.Include(r => r.Site).Include(r => r.Elements).Select(t => new
      {
        SiteName = t.Site.Name,
        CreatedMonth = t.CreatedAt,
        Amount = t.Elements.Sum(el => el.Interventions)
      }).ToList();

      var siteReportItemList = new SortedDictionary<int, Dictionary<string, int>>();
      foreach (var item in list)
      {
        if (siteReportItemList.ContainsKey(item.CreatedMonth.Month))
        {
          var siteData = siteReportItemList[item.CreatedMonth.Month];
          if (siteData.ContainsKey(item.SiteName))
          {
            siteData[item.SiteName] = siteData[item.SiteName] + item.Amount;
          }
          else
          {
            siteData.Add(item.SiteName, item.Amount);
          }

        }
        else
        {
          var dict = new Dictionary<string, int>();
          dict.Add(item.SiteName, item.Amount);
          siteReportItemList.Add(item.CreatedMonth.Month, dict);
        }
      }
      ViewData["SiteMonthlyTableReport"] = siteTotalsTableReport;
    }

    public IActionResult Index()
    {
      return View();
    }

    public IActionResult Privacy()
    {
      return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}
