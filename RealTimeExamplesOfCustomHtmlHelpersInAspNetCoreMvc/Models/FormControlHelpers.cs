using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RealTimeExamplesOfCustomHtmlHelpersInAspNetCoreMvc.Models
{
    public static class FormControlHelpers
    {
        public static IHtmlContent CustomInputWithValidation(this IHtmlHelper htmlHelper, string modelPropertyName, string labelText)
        {
            var fullHtml = $@"
            <div class='form-group'>
                <label for='{modelPropertyName}'>{labelText}</label>
                <input type='text' class='form-control' id='{modelPropertyName}' name='{modelPropertyName}' asp-for='{modelPropertyName}' />
                <span asp-validation-for='{modelPropertyName}' class='text-danger'></span>
            </div>";
            return new HtmlString(fullHtml);
        }
    }
}
