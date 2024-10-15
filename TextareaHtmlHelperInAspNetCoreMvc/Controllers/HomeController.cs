using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TextareaHtmlHelperInAspNetCoreMvc.Models;

namespace TextareaHtmlHelperInAspNetCoreMvc.Controllers;

public class HomeController : Controller
{
    public ActionResult Index()
    {
        Employee emp = new Employee()
        {
            EmployeeId = 1,
            Address = "Andheri, Sakinaka, Mumbai, 400097, Maharashtra, India"
        };
        return View(emp);
    }
}
