using BundleTransformer.Core.Orderers;
using BundleTransformer.Core.Transformers;
using System.Web;
using System.Web.Optimization;

namespace Teste
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.UseCdn = true;

            var cssTransformer = new CssTransformer();
            var nullOrderer = new NullOrderer();
           
            var commonStylesBundle = new Bundle("~/Content/css");
            commonStylesBundle.Include("~/Content/teste.less");
            commonStylesBundle.Transforms.Add(cssTransformer);
            commonStylesBundle.Orderer = nullOrderer;
            bundles.Add(commonStylesBundle);
        }

    }
}
