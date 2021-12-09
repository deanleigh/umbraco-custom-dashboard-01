using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.DependencyInjection;
using Umbraco.Cms.Core.Sections;

namespace umbraco_custom_dashboard_01
{
    public class ExternalLinksSectionComposer : IUserComposer
    {
        public void Compose(IUmbracoBuilder builder)
        {
            builder.Sections().InsertAfter<MediaSection, ExternalLinksSection>();
        }
    }
}
