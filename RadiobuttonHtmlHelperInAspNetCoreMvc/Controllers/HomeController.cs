using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RadiobuttonHtmlHelperInAspNetCoreMvc.Models;

namespace RadiobuttonHtmlHelperInAspNetCoreMvc.Controllers;

public class HomeController : Controller
{
    // public ActionResult Index()
    // {
    //     return View();
    // }

    [HttpGet]
    public ActionResult Index()
    {
        Company company = new Company();
        //company.SelectedDepartment = 2;
        return View(company);
    }
    [HttpPost]
    public string Index(Company company)
    {
        if (company.SelectedDepartment <= 0)
        {
            return "You did not select any department";
        }
        else
        {
            return "You selected department with ID = " + company.SelectedDepartment;
        }
    }

}
