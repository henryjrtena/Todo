using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Todo.Views.Helpers
{
    public static class Components
    {
        public static IHtmlContent CustomButton(this IHtmlHelper htmlHelper, string buttonText, string cssClass)
        {
            var buttonBuilder = new TagBuilder("button");
            buttonBuilder.InnerHtml.AppendHtml(buttonText);
            buttonBuilder.AddCssClass(cssClass);
            return buttonBuilder;
        }
    }
}