using System.Web;
using System.Web.Optimization;

namespace WebApplicationej3
{
    public class BundleConfig
    {
      public static void RegisterBundles(BundleCollection bundles)
        {
           
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                 "~/Content/js/scripts.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/css/styles.css", "~/Content/stylesheet"));
        }
    }
}
