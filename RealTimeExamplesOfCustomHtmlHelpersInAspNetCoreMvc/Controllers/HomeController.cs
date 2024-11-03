using Microsoft.AspNetCore.Mvc;
using RealTimeExamplesOfCustomHtmlHelpersInAspNetCoreMvc.Models;
using System.Diagnostics;

namespace RealTimeExamplesOfCustomHtmlHelpersInAspNetCoreMvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
