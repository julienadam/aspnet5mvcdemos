using System.Web;
using System.Web.Mvc;

namespace CustomImageResultDemo.Plumbing
{
    public static class ImageResultHelper
    {
        public static IHtmlString Image(this HtmlHelper helper, string controller, string action, int width, int height)
        {
            return helper.Image(controller, action, width, height, "");
        }

        public static IHtmlString Image(this HtmlHelper helper, string controller, string action, int width, int height, string alt)
        {
            var urlHelper = new UrlHelper(helper.ViewContext.RequestContext);
            var url = urlHelper.Action(action, controller);
            return helper.Raw($"<img src=\"{url}\" width=\"{width}\" height=\"{height}\" alt=\"{alt}\" />");
        }
    }
}