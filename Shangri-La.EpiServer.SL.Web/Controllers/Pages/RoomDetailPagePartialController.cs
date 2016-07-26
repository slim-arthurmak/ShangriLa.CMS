using Shangri_La.EpiServer.SL.Web.Models.Pages;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EPiServer.Framework.Web;

namespace Shangri_La.EpiServer.SL.Web.Controllers
{
    [TemplateDescriptor(TemplateTypeCategory = TemplateTypeCategories.MvcPartialController, Default = true, Inherited = true, AvailableWithoutTag = true)]
    public class RoomDetailPagePartialController : PartialContentController<RoomDetailPage>
    {
        public override ActionResult Index(RoomDetailPage currentContent)
        {
            return PartialView("/Views/Shared/PagePartials/RoomDetailPage.cshtml", currentContent);
        }
    }

    [TemplateDescriptor(TemplateTypeCategory = TemplateTypeCategories.MvcPartialController, Inherited = true, 
        Tags = new[] { Global.ContentAreaTags.FullWidth },
        AvailableWithoutTag = false)]
    public class RoomDetailPageFullWidthPartialController : PartialContentController<RoomDetailPage>
    {
        public override ActionResult Index(RoomDetailPage currentContent)
        {
            return PartialView("/Views/Shared/PagePartials/RoomDetailPageFullWidth.cshtml", currentContent);
        }
    }
}