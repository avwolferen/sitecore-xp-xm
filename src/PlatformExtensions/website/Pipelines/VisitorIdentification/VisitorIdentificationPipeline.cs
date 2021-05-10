using Sitecore.Pipelines;

namespace AlexVanWolferen.PlatformExtensions.Pipelines.VisitorIdentification
{
    public class VisitorIdentificationPipeline
    {
        public const string pipelineName = "platformextensions.visitorIdentification";

        public static string Run()
        {
            string result = string.Empty;
            try
            {
                var args = new VisitorIdentificationPipelineArgs();
                CorePipeline.Run(pipelineName, args);
                result = args.RenderedHtml;
            }
            catch (System.Exception ex)
            {
                Sitecore.Diagnostics.Log.Error($"Possible misconfiguration of the feature toggle for topology:define.", ex, typeof(VisitorIdentificationPipeline));
            }

            return result;
        }
    }
}