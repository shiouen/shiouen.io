using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Mvc;

namespace shiouen.io.Web.MVC.Helpers {
    public static class HtmlExtensions {
        public static MvcHtmlString Build(this HtmlHelper helper, string tag, Dictionary<string, string> attributes, string content = "", TagRenderMode tagRenderMode = TagRenderMode.Normal) {
            TagBuilder builder = new TagBuilder(tag);

            // set attributes
            foreach (var tuple in attributes) { builder.MergeAttribute(tuple.Key, tuple.Value); }

            // set inner html
            builder.InnerHtml = content;

            // Render tag
            return MvcHtmlString.Create(builder.ToString(tagRenderMode));
        }

        public static bool FileExists(this HtmlHelper helper, string physicalPath) { return File.Exists(physicalPath); }
    }
}