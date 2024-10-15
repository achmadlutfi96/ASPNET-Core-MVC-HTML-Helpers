using EditorHtmlHelperInAspNetCoreMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace EditorHtmlHelperInAspNetCoreMvc.Controllers;

public class EmployeeController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            // Populating Employee with some dummy data
            var model = new Employee
            {
                Name = "Pranaya Rout",
                Age = 35,
                Salary = 55000.00m,
                IsEmployed = true,
                DateOfBirth = new DateTime(1988, 02, 29),
                Gender = Gender.Male,
                Skills = new List<string>() { "C#", "ASP.NET Core" },
                ProfilePicture = null, 
                UserId = Guid.NewGuid(),
                WorkingHours = new TimeSpan(8, 0, 0) // 8 hours
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult Create(Employee model)
        {
            if (ModelState.IsValid)
            {
                // Save the model to the database or process it here.
                return RedirectToAction("Success");
            }
            return View(model);
        }
        public string Success()
        {
            return "Employee Created/Modified Successfully";
        }
    }