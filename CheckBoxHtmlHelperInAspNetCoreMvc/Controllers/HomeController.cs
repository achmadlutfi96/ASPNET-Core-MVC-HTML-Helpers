using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CheckBoxHtmlHelperInAspNetCoreMvc.Models;

namespace CheckBoxHtmlHelperInAspNetCoreMvc.Controllers;

public class HomeController : Controller
{
    // public ActionResult Index()
    // {
    //     return View();
    // }

    // [HttpPost]
    // public string UpdateProfile(bool SubscribeToNewsletter)
    // {
    //     if (SubscribeToNewsletter)
    //     {
    //         return "You Subscribed to Newsletter";
    //     }
    //     else
    //     {
    //         return "You Havenot Subscribed to Newsletter";
    //     }
    // }

    public ActionResult Index()
    {
        //Current Settings
        SecuritySettingsViewModel settings = new SecuritySettingsViewModel()
        {
            EnableTwoFactorAuth = false
        };
        return View();
    }
    [HttpPost]
    public string UpdateSecuritySettings(SecuritySettingsViewModel settings)
    {
        if (settings.EnableTwoFactorAuth)
        {
            return "You Enable Two Factor Authentication";
        }
        else
        {
            return "You Disabled Two Factor Authentication";
        }
    }
}
