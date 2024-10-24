using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace CustomImageHtmlHelperInAspNetCoreMvc.Models
{
    // Declares a static class names CustomHTMLHelper.
    // Static classes cannot be instantiated and are typically used for utility or helper methods.
    public static class CustomHTMLHelper
    {
        // Extension method for IHtmlHelper.
        // This method adds an 'Image' helper to generate an <img> tag.
        public static IHtmlContent Image(this IHtmlHelper htmlHelper, string src, string alt, object? htmlAttributes = null)
        {
            // Creates a new <img> tag using the TagBuilder class, which helps in generating well-formed HTML tags.
            var imgTag = new TagBuilder("img");
            // Adds the 'src' attribute to the <img> tag with the value passed in the 'src' parameter.
            imgTag.Attributes.Add("src", src);
            // Adds the 'alt' attribute to the <img> tag with the value passed in the 'alt' parameter.
            imgTag.Attributes.Add("alt", alt);
            // Checks if there are any additional HTML attributes (such as class, style, etc.) passed in the 'htmlAttributes' parameter.
            if (htmlAttributes != null)
            {
                // Converts the anonymous object 'htmlAttributes' into a dictionary of key-value pairs that represent HTML attributes.
                var attributes = HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes);
                // Merges the additional HTML attributes into the <img> tag.
                // Existing attributes (like 'src' and 'alt') are not overwritten.
                imgTag.MergeAttributes(attributes);
            }
            // Returns the generated <img> tag as an IHtmlContent object, which can be rendered directly in Razor views.
            return imgTag;
        }
    }
}
