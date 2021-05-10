using Sitecore.Framework.Conditions;
using Sitecore.Web;

namespace AlexVanWolferen.PlatformExtensions.Pipelines.VisitorIdentification
{
    public class RenderVisitorIdentificationProcessor : VisitorIdentificationBase
    {
        public override void Process(VisitorIdentificationPipelineArgs args)
        {
            Condition.Requires(args, "args").IsNotNull();
            Sitecore.Web.UI.WebControls.VisitorIdentification ctl = new Sitecore.Web.UI.WebControls.VisitorIdentification();
            args.RenderedHtml += HtmlUtil.RenderControl(ctl);
        }
    }
}