using System.Web;
using System.Web.Optimization;

namespace MvcMusicStore
{
    public class BundleConfig
    {
        // 有关绑定的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // 使用要用于开发和学习的 Modernizr 的开发版本。然后，当你做好
            // 生产准备时，请使用 http://modernizr.com 上的生成工具来仅选择所需的测试。
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/datatables").Include(
                      "~/Scripts/datatables/demo.js",
                      "~/Scripts/datatables/jquery.dataTables.min.js",
                      "~/Scripts/datatables/jquery.csv-0.71.min.js"
                ));
            bundles.Add(new ScriptBundle("~/bundles/jPlayer").Include(

                        "~/Scripts/jPlayer/jquery.jplayer.min.js",
                        "~/Scripts/jPlayer/add-on/jplayer.playlist.min.js",
                        "~/Scripts/jPlayer/demo.js"
                ));
            bundles.Add(new ScriptBundle("~/bundles/App").Include(
                        "~/Scripts/app.js",
                        "~/Scripts/app.plugin.js"
                ));
            bundles.Add(new ScriptBundle("~/bundles/slimscroll").Include(
                         "~/Scripts/slimscroll/jquery.slimscroll.min.js"
                ));


            bundles.Add(new StyleBundle("~/Content/css").Include(
                         "~/Content/bootstrap.css",
                         "~/Content/animate.css",
                         "~/Content/font-awesome.min.css",
                         "~/Content/simple-line-icons.css",
                         "~/Content/font.css",
                         "~/Content/app.css"));

            bundles.Add(new StyleBundle("~/Scripts/css").Include(
                         "~/Scripts/jPlayer/jplayer.flat.css"));

            bundles.Add(new StyleBundle("~/Scripts/datatables/css").Include(
                         "~/Scripts/datatables/datatables.css"));
        }
    }
}
