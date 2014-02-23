using Retain.App_Start.Bundles;
using System.Web;
using System.Web.Optimization;

namespace Retain
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css")
                .Include("~/Content/site.css")
            );

            bundles.Add(new StyleBundle("~/Content/semantic-ui/css/semantic")
                .Include("~/Content/semantic-ui/css/semantic.css", new CssRewriteUrlTransform())
            );

            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/foundation/fastclick.js",
                        "~/Content/semantic-ui/javascript/semantic.js",
                        "~/Scripts/app.js"));

            #region Foundation Bundles
            bundles.Add(Foundation.Scripts());
            #endregion

            #region Semantic UI Bundles
            bundles.Add(SemanticUI.Scripts());
            #endregion
        }
    }
}
