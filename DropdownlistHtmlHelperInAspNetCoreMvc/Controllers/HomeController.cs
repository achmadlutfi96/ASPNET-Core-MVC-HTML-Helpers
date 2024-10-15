using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using DropdownlistHtmlHelperInAspNetCoreMvc.Models;

namespace DropdownlistHtmlHelperInAspNetCoreMvc.Controllers;

public class HomeController : Controller
{
    // public ActionResult Index()
    // {
    //     return View();
    // }

    // public ActionResult Index()
    // {
    //     // Creating a list of SelectListItem objects to represent options in a dropdown list
    //     // Each SelectListItem has 'Text' for display and 'Value' for the submitted data
    //     // Selected will set the default selected value in the dropdownlist
    //     List<SelectListItem> items = new List<SelectListItem>()
    //         {
    //             // First dropdown item: Displayed as "IT", with a value of "1" when selected
    //             new SelectListItem { Text = "IT", Value = "1", Selected = true },
    //             // Second dropdown item: Displayed as "HR", with a value of "2" when selected
    //             new SelectListItem { Text = "HR", Value = "2" },
    //             // Third dropdown item: Displayed as "Payroll", with a value of "3" 
    //             new SelectListItem { Text = "Payroll", Value = "3" }
    //         };
    //     // Assigning the list of SelectListItem objects to the ViewBag with the key "Departments"
    //     // This makes the dropdown data accessible to the view when rendering the dropdown list
    //     ViewBag.Departments = items;
    //     // Returning the view for rendering the HTML content
    //     // The ViewBag data (Departments) will be available for use in this view
    //     return View();
    // }

    public ActionResult Index()
    {
        //Let’s create list department for dropdownlist
        List<Department> ListDepartments = new List<Department>()
            {
                new Department() {Id = 1, Name="IT" },
                new Department() {Id = 2, Name="HR" },
                new Department() {Id = 3, Name="Payroll" },
            };
        ViewBag.Departments = ListDepartments;
        //let’s create one employee
        Employee emp = new Employee()
        {
            EmployeeId = 1,
            EmployeeName = "Pranaya",
            Gender = "Male",
            DepartmentID = 2
        };
        //Pass that employee to the view
        return View(emp);
    }
}
