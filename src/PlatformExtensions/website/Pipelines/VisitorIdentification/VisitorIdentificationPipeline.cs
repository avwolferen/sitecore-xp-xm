using Sitecore.Pipelines;

namespace AlexVanWolferen.PlatformExtensions.Pipelines.VisitorIdentification
{
    public class VisitorIdentificationPipeline
    {
        public const string pipelineName = "platformextensions.visitorIdentification";

        public static string Run()
        {
            var args = new VisitorIdentificationPipelineArgs();
            CorePipeline.Run(pipelineName, args);
            return args.RenderedHtml;
        }
    }
}