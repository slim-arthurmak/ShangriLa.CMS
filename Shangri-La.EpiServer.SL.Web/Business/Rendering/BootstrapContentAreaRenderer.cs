using EPiServer.Core;
using EPiServer.Web.Mvc.Html;
using System;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.ServiceLocation;
using EPiServer.Web;
using EPiServer.Web.Mvc;
using EPiServer.Web.Mvc.Html;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Linq;

namespace Shangri_La.EpiServer.SL.Web.Business.Rendering
{
    public class BootstrapContentAreaRenderer : ContentAreaRenderer
    {
        protected override string GetContentAreaItemCssClass(HtmlHelper htmlHelper, ContentAreaItem contentAreaItem)
        {
            var itemTag = GetContentAreaItemTemplateTag(htmlHelper, contentAreaItem);
            var areaTag = GetContentAreaTemplateTag(htmlHelper);
            var baseClasses = base.GetContentAreaItemCssClass(htmlHelper, contentAreaItem);

            return string.Format("{0} {1} {2}", GetTypeSpecificCssClasses(contentAreaItem, ContentRepository), GetCssClassesForTags(areaTag, itemTag), baseClasses);
        }

        private static string GetTypeSpecificCssClasses(ContentAreaItem contentAreaItem, IContentRepository contentRepository)
        {
            var content = contentAreaItem.GetContent(contentRepository);
            var cssClass = content == null ? String.Empty : content.GetOriginalType().Name.ToLowerInvariant();

            // ReSharper disable once SuspiciousTypeConversion.Global
            var customClassContent = content as ICustomCssInContentArea;
            if (customClassContent != null && !string.IsNullOrWhiteSpace(customClassContent.ContentAreaCssClass))
            {
                cssClass += string.Format(" {0}", customClassContent.ContentAreaCssClass);
            }

            return cssClass;
        }

        private static string GetCssClassesForTags(string areaTag, string itemTag)
        {
            if (areaTag == Global.ContentAreaTags.PageWidth)
                return string.Empty;

            switch (itemTag)
            {
                case Global.ContentAreaTags.OneQuarterWidth :
                    return "col-xs-12 col-sm-12 col-md-6 col-lg-3";
                case Global.ContentAreaTags.OneThirdWidth :
                    return "col-xs-12 col-sm-12 col-md-6 col-lg-4";
                case Global.ContentAreaTags.HalfWidth :
                    return "col-xs-12 col-sm-12 col-md-6 col-lg-6";
                case Global.ContentAreaTags.TwoThirdsWidth :
                    return "col-xs-12 col-sm-12 col-md-6 col-lg-8";
                case Global.ContentAreaTags.ThreeQuartersWidth :
                    return "col-xs-12 col-sm-12 col-md-6 col-lg-9";
                default : // FullWidth
                    return "col-xs-12 col-sm-12 col-md-12 col-lg-12";
            }
        }
    }
}