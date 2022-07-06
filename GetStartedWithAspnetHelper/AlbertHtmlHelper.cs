using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace System.Web.Mvc
{
    public static class AlbertHtmlHelper
    {
        public static MvcHtmlString Br(this HtmlHelper helper)
        {
            var builder = new TagBuilder("br");
            return MvcHtmlString.Create(builder.ToString(TagRenderMode.SelfClosing));
        }
    }
}
