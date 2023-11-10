using System.Web;
using System.Web.Optimization;

namespace WebApplication1
{
    public class BundleConfig
    {
        // 有关捆绑的详细信息，请访问 https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // 使用要用于开发和学习的 Modernizr 的开发版本。然后，当你做好
            // 生产准备就绪，请使用 https://modernizr.com 上的生成工具仅选择所需的测试。
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new Bundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js", 
                      "~/Scripts/image1.js",
                      "~/Scripts/map.js",
                       "~/Scripts/map2.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                       "~/Content/btn.css",
                      "~/Content/a.css",
                      "~/Content/image1.css",
                       "~/Content/navbar.css",
                      "~/Content/image-container.css", 
                      "~/Content/Font1.css",
                      "~/Content/background.css",
                      "~/Content/navbarfont.css",
                      "~/Content/content2.css",
                      "~/Content/white-border.css",
                      "~/Content/geolocation-container.css",
                      "~/Content/geolocation-container2.css",
                      "~/Content/geolocation-container3.css",
                      "~/Content/p1container.css",
                      "~/Content/fontsetting1.css",
                      "~/Content/headsettings.css",
                      "~/Content/contact-info.css",
                       "~/Content/container.css"));
            
        }
    }
}
