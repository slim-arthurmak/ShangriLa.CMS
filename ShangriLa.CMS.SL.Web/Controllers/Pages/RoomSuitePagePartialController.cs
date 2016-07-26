﻿using ShangriLa.CMS.SL.Web.Models.Pages;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EPiServer.Framework.Web;

namespace ShangriLa.CMS.SL.Web.Controllers
{
    [TemplateDescriptor(TemplateTypeCategory = TemplateTypeCategories.MvcPartialController, Default = true, Inherited = true, AvailableWithoutTag = true)]
    public class RoomSuitePagePartialController : PartialContentController<RoomSuitePage>
    {
        public override ActionResult Index(RoomSuitePage currentContent)
        {
            return PartialView("/Views/Shared/PagePartials/RoomSuitePage.cshtml", currentContent);
        }
    }

    [TemplateDescriptor(TemplateTypeCategory = TemplateTypeCategories.MvcPartialController, Inherited = true, 
        Tags = new[] { Global.ContentAreaTags.FullWidth },
        AvailableWithoutTag = false)]
    public class RoomSuitePageFullWidthPartialController : PartialContentController<RoomSuitePage>
    {
        public override ActionResult Index(RoomSuitePage currentContent)
        {
            return PartialView("/Views/Shared/PagePartials/RoomSuitePageFullWidth.cshtml", currentContent);
        }
    }
}