using CreatingFormUsingHtmlHelpersInAspNetCoreMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace CreatingFormUsingHtmlHelpersInAspNetCoreMvc.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            var model = new UserRegistrationModel
            {
                Courses = new List<string> { "ASP.NET Core", "Azure", "Microservices" },
                Skills = new List<string> { "C#", "SQL", "JavaScript", "Docker", "Kubernetes" },
                HiddenField = Guid.NewGuid()
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Register(UserRegistrationModel model)
        {
            if (ModelState.IsValid)
            {
                // You can save the model data to the database or process it as needed here.
               
                // Pass the model data to the Success view
                return View("Success", model);
            }
            
            // Re-populate the Courses and Skills if validation fails
            model.Courses = new List<string> { "ASP.NET Core", "Azure", "Microservices" };
            model.Skills = new List<string> { "C#", "SQL", "JavaScript", "Docker", "Kubernetes" };

            return View(model);
        }
    }
}
