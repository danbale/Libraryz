using System.Web;
using System.Web.Optimization;

namespace SSUABC
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new ScriptBundle("~/Content/jquery").Include(
                        "~/Content/node_modules/jquery/dist/jquery.min.js"));

            bundles.Add(new ScriptBundle("~/Content/Bootstrap/js").Include(
                        "~/Content/node_modules/bootstrap/dist/js/bootstrap.min.js"));

            bundles.Add(new StyleBundle("~/Content/Bootstrap/css").Include(
                        "~/Content/node_modules/bootstrap/dist/css/bootstrap.css"));

            bundles.Add(new ScriptBundle("~/Content/Angular").Include(
                        "~/Content/node_modules/angular/angular.min.js" , "~/Content/node_modules/angular-route/angular-route.min.js" , "~/Content/node_modules/angular-crypto/angular-crypto.min.js"));

            bundles.Add(new ScriptBundle("~/Content/Angular/app").Include(
                       "~/Content/src/app-controller.js","~/Content/src/app.js", "~/Content/src/Directive/templete-directive.js"));

            bundles.Add(new ScriptBundle("~/Content/Angular/Inicio").Include(
                       "~/Content/src/Controller/loginCtrl.js", "~/Content/src/Controller/timeOutCtrl.js"));

            bundles.Add(new ScriptBundle("~/Content/Angular/Usuario").Include(
                       "~/Content/src/Controller/usuarioCtrl.js", "~/Content/src/Controller/timeOutCtrl.js", "~/Content/src/Service/crudService.js"));


        }
    }
}
