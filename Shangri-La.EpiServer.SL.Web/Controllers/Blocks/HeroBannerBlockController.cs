using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Web;
using EPiServer.Web.Mvc;

using Shangri_La.EpiServer.SL.Web.Models.Blocks;
using Shangri_La.EpiServer.SL.Web.Business;

namespace Shangri_La.EpiServer.SL.Web.Controllers.Blocks
{
    public class HeroBannerBlockController : BlockController<HeroBannerBlock>
    {
        private ContentLocator contentLocator;
        private IContentLoader contentLoader;
        public HeroBannerBlockController(ContentLocator contentLocator, IContentLoader contentLoader)
        {
            this.contentLocator = contentLocator;
            this.contentLoader = contentLoader;
        }

        public override ActionResult Index(HeroBannerBlock currentBlock)
        {
            return PartialView(currentBlock);
        }
    }
}
