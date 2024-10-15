using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TextboxHtmlHelperInAspNetCoreMvc.Models;

namespace TextboxHtmlHelperInAspNetCoreMvc.Controllers;

public class HomeController : Controller
{
    public ActionResult Index()
    {
        return View();
    }
}
