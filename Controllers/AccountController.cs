using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Software_Engineering_Assingment.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Software_Engineering_Assingment.Controllers
{
  public class AccountController : Controller
  {
    private readonly DBContext _context;

    public AccountController(DBContext context)
    {
      _context = context;
    }


    public IActionResult Login()
    {
      return View();
    }

    public ActionResult Validate(User user)
    {
      var _user = _context.User.Where(s => s.Email == user.Email);
      if (_user.Any())
      {
        if (_user.Where(s => s.Password == user.Password).Any())
        {

          return Json(new { status = true, message = "Login Successfull!" });
        }
        else
        {
          return Json(new { status = false, message = "Invalid Password!" });
        }
      }
      else
      {
        return Json(new { status = false, message = "Invalid Email!" });
      }
    }
  }
}
