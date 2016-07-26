using EPiServer.Core;
using EPiServer.ServiceLocation;
using EPiServer.Web.Mvc;
using System.Web.Mvc;
using Shangri_La.EpiServer.SL.Web.Business.Rendering;

namespace Shangri_La.EpiServer.SL.Web.Business.Extensions
{
    public static class ContentAreaExtensions
    {
        public static void RenderCustomContentArea(this HtmlHelper htmlHelper, ContentArea contentArea)
        {
            ServiceLocator.Current.GetInstance<CustomContentAreaRenderer>().Render(htmlHelper, contentArea);
        }
    }
}