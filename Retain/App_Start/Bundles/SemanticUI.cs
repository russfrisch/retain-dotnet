using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Retain.App_Start.Bundles
{
    public class SemanticUI
    {
        public static Bundle Scripts()
        {
            return new ScriptBundle("~/bundles/semanticui").Include(
                      "~/Content/semantic-ui/javascript/semantic.js");
        }
    }
}