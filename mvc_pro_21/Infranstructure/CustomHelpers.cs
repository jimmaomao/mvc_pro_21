using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_pro_21.Infranstructure
{
    public static class CustomHelpers
    {
        public static MvcHtmlString ListArrayItems(this HtmlHelper htmlhelper, string[] list) {
            TagBuilder tag = new TagBuilder("ul");
            foreach (string str in list) {
                TagBuilder itemTag = new TagBuilder("li");
                itemTag.SetInnerText(str);
                tag.InnerHtml += itemTag.ToString();
            }
            return new MvcHtmlString(tag.ToString());
        }

        public static MvcHtmlString DisplayMessage(this HtmlHelper html, string msg) {
            string encodeMessage = html.Encode(msg);
            return new MvcHtmlString(string.Format("This is the message :<p>{0}</p>", encodeMessage));
        }
    }
}