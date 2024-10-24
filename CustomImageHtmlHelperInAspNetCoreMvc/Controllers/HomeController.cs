using CustomImageHtmlHelperInAspNetCoreMvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CustomImageHtmlHelperInAspNetCoreMvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // Here we are hardcoded the Employee Details
            // In Realtime you will get the data from any data source
            Employee employee = new Employee()
            {
                Id = 106724,
                FullName = "Joko Widodo",
                Designation = "President",
                Department = "NKRI",
                Photo = "/Images/MyPhoto.jpg",
                AlternateText = "Joko Widodo Photo Not Available"
            };
            return View(employee);
        }
    }
}
