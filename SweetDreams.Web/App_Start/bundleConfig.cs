using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace SweetDreams.Web.App_Start
{
     public static class BundleConfig
     {
          public static void RegisterBundles(BundleCollection bundles)
          {
               bundles.Add(new StyleBundle("~/bundles/bootstrap/css").Include(
                           "~/Content/bootstrap.min.css", new CssRewriteUrlTransform()));
               bundles.Add(new StyleBundle("~/bundles/mdbootstrap/css").Include(
                           "~/Content/mdb.min.css", new CssRewriteUrlTransform()));
               bundles.Add(new StyleBundle("~/bundles/style/css").Include(
                           "~/Content/style.css", new CssRewriteUrlTransform()));
               bundles.Add(new StyleBundle("~/bundles/AboutUs/css").Include(
                          "~/Content/AboutUs.css", new CssRewriteUrlTransform()));
               bundles.Add(new StyleBundle("~/bundles/Home/css").Include(
                          "~/Content/Home.css", new CssRewriteUrlTransform()));
               bundles.Add(new StyleBundle("~/bundles/fa/css").Include(
                          "~/Content/font-awesome.min.css", new CssRewriteUrlTransform()));
               bundles.Add(new ScriptBundle("~/bundles/bootstrap/js").Include(
                           "~/Scripts/bootstrap.min.js"));
               bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                         "~/Scripts/jquery-3.4.1.min.js"));
               bundles.Add(new ScriptBundle("~/bundles/popper/js").Include(
                                        "~/Scripts/popper.min.js"));
               bundles.Add(new ScriptBundle("~/bundles/mdbootstrap/js").Include(
                                        "~/Scripts/mdb.min.js"));
               bundles.Add(new ScriptBundle("~/bundles/main/js").Include(
                                        "~/Scripts/main.js"));
               bundles.Add(new ScriptBundle("~/bundles/jqueryval")
                .Include(
                    "~/Scripts/jquery.validate.min.js",
                    "~/Scripts/jquery.validate.unobtrusive.min.js"
                )
            );
          }
     }
}