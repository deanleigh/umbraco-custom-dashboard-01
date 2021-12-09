using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core;
using Umbraco.Cms.Core.Events;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Trees;
using Umbraco.Cms.Web.BackOffice.Trees;
using Umbraco.Cms.Web.Common.ModelBinders;

namespace umbraco_custom_dashboard_01
{
    [Tree("externalLinksSection", "External Links Section",
        TreeGroup = "CustomGroup",
        TreeTitle = "MyCustomTree",
        SortOrder = 10)]
    public class ExternalLinkSectionTreeController : TreeController
    {
        public ExternalLinkSectionTreeController(ILocalizedTextService localizedTextService, UmbracoApiControllerTypeCollection umbracoApiControllerTypeCollection, IEventAggregator eventAggregator) : base(localizedTextService, umbracoApiControllerTypeCollection, eventAggregator)
        {
        }

        protected override ActionResult<MenuItemCollection> GetMenuForNode(string id, [ModelBinder(typeof(HttpQueryStringModelBinder))] FormCollection queryStrings)
        {
            throw new System.NotImplementedException();
        }

        protected override ActionResult<TreeNodeCollection> GetTreeNodes(string id, [ModelBinder(typeof(HttpQueryStringModelBinder))] FormCollection queryStrings)
        {
            var tree = new TreeNodeCollection();

            if (id == "-1")
            {
                // for this example build some top level nodes 
                for (int x = 0; x < 10; x++)
                {
                    tree.Add(CreateTreeNode(x.ToString(), id, queryStrings, $"Child {x}", "icon-cloud"));
                }
            }

            return tree;
        }
    }
}
