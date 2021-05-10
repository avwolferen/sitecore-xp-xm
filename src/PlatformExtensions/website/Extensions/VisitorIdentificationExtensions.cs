using Sitecore.Mvc.Helpers;
using System.Web;

namespace AlexVanWolferen.PlatformExtensions.Extensions
{
    public static class VisitorIdentificationExtensions
    {
        public static HtmlString SafeVisitorIdentification(this SitecoreHelper sitecoreHelper)
        {
            var renderedHtml = Pipelines.VisitorIdentification.VisitorIdentificationPipeline.Run();
            return new HtmlString(renderedHtml);
        }
    }
}