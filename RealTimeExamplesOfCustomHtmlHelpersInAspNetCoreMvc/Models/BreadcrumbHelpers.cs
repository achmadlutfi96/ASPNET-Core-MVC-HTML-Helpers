using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Text;

namespace RealTimeExamplesOfCustomHtmlHelpersInAspNetCoreMvc.Models
{
    public static class BreadcrumbHelpers
    {
        public static IHtmlContent Breadcrumbs(this IHtmlHelper htmlHelper, List<(string Url, string Name)> paths)
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append("<nav aria-label='breadcrumb'>");
            stringBuilder.Append("<ol class='breadcrumb'>");
            foreach (var path in paths)
            {
                stringBuilder.AppendFormat("<li class='breadcrumb-item'><a href='{0}'>{1}</a></li>", path.Url, path.Name);
            }
            stringBuilder.Append("</ol></nav>");
            return new HtmlString(stringBuilder.ToString());
        }
    }
}
