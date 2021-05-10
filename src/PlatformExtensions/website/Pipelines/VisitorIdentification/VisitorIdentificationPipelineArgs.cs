using Sitecore.Pipelines;
using System;

namespace AlexVanWolferen.PlatformExtensions.Pipelines.VisitorIdentification
{

    [Serializable]
    public class VisitorIdentificationPipelineArgs : PipelineArgs
    {
        /// <summary>
        /// The rendered HTML for the Visitor Identification
        /// </summary>
        public string RenderedHtml { get; set; } = string.Empty;
    }
}