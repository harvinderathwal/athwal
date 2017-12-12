using System.Web;
using System.Web.Optimization;


namespace HarvinderAthwal.App_Start
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            ScriptBundle thirdPartyScripts = new ScriptBundle("~/Scripts/ThirdParty");
            thirdPartyScripts.Include(
                          "~/assets/js/jquery.min.js",
                           "~/assets/js/animation.min.js",
                           "~/assets/js/bootstrap.min.js",
                           "~/assets/js/detectmobilebrowser.min.js",

                           "~/assets/js/main.min.js",
                           "~/assets/js/plugins.min.js",
                           "~/assets/js/switch-style.js"
       );

            StyleBundle thirdPartyStyle = new StyleBundle("~/style/css");
            thirdPartyStyle.Include(
                "~/assets/css/bootstrap.min.css",
                 "~/assets/css/icomoon.min.css",
                  "~/assets/css/font-awesome.min.css",
                   "~/assets/css/jpreloader.min.css",
                            "~/assets/css/animate.min.css",
                            "~/assets/css/magnific-popup.min.css",
                                "~/assets/css/flexslider.min.css",
                            "~/assets/css/berg.min.css",
                           "~/assets/css/switch-style.css"
                 );
            StyleBundle thirdPartyStyle1 = new StyleBundle("~/assets/css/colors");
            thirdPartyStyle1.Include(
                 "~/assets/css/colors/blue.css",
                 "~/assets/css/colors/green.css",
                 "~/assets/css/colors/green2.css",
                 "~/assets/css/colors/orange.css",
                 "~/assets/css/colors/pink.css",
                 "~/assets/css/colors/purple.css",
                 "~/assets/css/colors/red.css",
                 "~/assets/css/colors/yellow.css"
                 );
            bundles.Add(thirdPartyScripts);
            bundles.Add(thirdPartyStyle);
            bundles.Add(thirdPartyStyle1);


            BundleTable.EnableOptimizations = true;
        }

    }
}