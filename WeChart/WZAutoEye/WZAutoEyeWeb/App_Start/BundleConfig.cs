using System.Web;
using System.Web.Optimization;

namespace WZAutoEye.WZAutoEyeMVC.Web
{
    public class BundleConfig
    {
        // 有关绑定的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/json2.js",
                        "~/Scripts/jquery.base64.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // 使用要用于开发和学习的 Modernizr 的开发版本。然后，当你做好
            // 生产准备时，请使用 http://modernizr.com 上的生成工具来仅选择所需的测试。
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.min.js",
                      "~/Scripts/respond.min.js",
                      "~/Scripts/Custom/bootstrap-datetimepicker.js",
                      "~/Scripts/Custom/bootstrap-datetimepicker.zh-CN.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/Custom/jquery.alerts.css",
                      "~/Content/Custom/lhgcalendar.css",
                      "~/Content/Custom/myRadio.css",
                      "~/Content/Custom/slider-pro.min.css",
                      "~/Content/Custom/bootstrap-datetimepicker.css",
                      "~/Content/Custom/Custom.css"));

            bundles.Add(new StyleBundle("~/Content/Custom/css").Include(
                      "~/Content/Custom/colorbox.css",
                      "~/Content/Custom/hint.css",
                      "~/Content/Custom/dexhin.tw.zh.css",
                      "~/Content/Custom/Huploadify.css",
                    "~/Content/Custom/loading.css",
                    "~/Content/Custom/myRadio.css",
                    "~/Content/Custom/no.response.css",
                    "~/Content/Custom/polaris.css",
                    "~/Content/Custom/tips.css"));

            bundles.Add(new ScriptBundle("~/bundles/Custom/jquery").Include(
                      "~/Scripts/Custom/jquery-ui-1.10.3.custom.min.js",
                      "~/Scripts/Custom/jquery.dataTables.min.js",
                      "~/Scripts/Custom/jquery.flexslider-min.js",
                      "~/Scripts/Custom/jquery.slide.js",
                      "~/Scripts/Custom/myRadio.js",
                      "~/Scripts/Custom/common.js",
                      "~/Scripts/Custom/jquery.hotkeys.js",
                      "~/Scripts/Custom/jquery.alerts.js",
                      "~/Scripts/Custom/comb.js",
                      "~/Scripts/Custom/htmlStr.js",
                      "~/Scripts/Custom/getName.js",
                      "~/Scripts/Custom/lang.js", 
                      "~/Scripts/Custom/ho_index.js",
                      "~/Scripts/Custom/jquery.colorbox.js",
                      "~/Scripts/Custom/icheck.js",
                      "~/Scripts/Custom/tips.js"));
            //,
            //          "~/Scripts/Custom/diabetic_retinopathy_manager.js"
            //,
                      
        }
    }
}
