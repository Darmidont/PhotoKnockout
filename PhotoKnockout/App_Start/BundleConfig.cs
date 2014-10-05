using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace PhotoKnockout.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/base")
                               .Include("~/Scripts/jquery-2.1.1.js")
                               .Include("~/Scripts/knockout-3.2.0.js")
                               .Include("~/Scripts/bootstrap.js")
                               .Include("~/Scripts/Common/knockout.validation.js"));
        }
    }
}