using System.Web;
using System.Web.Optimization;

namespace ejercicio5
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/javascript").Include(
                       "~/Scripts/script.js"));


            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Content/plugins/jQuery/jquery.min.js",
                      "~/Content/plugins/bootstrap/bootstrap.min.js",
                      "~/Content/plugins/slick/slick.min.js",
                      "~/Content/plugins/shuffle/shuffle.min.js",
                      "~/Content/js/script.js"
));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/plugins/bootstrap/bootstrap.min.css",
                      "~/Content/plugins/slick/slick.css",
                      "~/Content/plugins/themify-icons/themify-icons.css",
                      "~/Content/css/style.css"));
        }
    }
}
