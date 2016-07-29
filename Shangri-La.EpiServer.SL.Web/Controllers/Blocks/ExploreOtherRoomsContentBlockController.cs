﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Web;
using EPiServer.Web.Mvc;

using Shangri_La.EpiServer.SL.Web.Models.Blocks;
using Shangri_La.EpiServer.SL.Web.Models.Blocks.RoomPage;
using Shangri_La.EpiServer.SL.Web.Business;

namespace Shangri_La.EpiServer.SL.Web.Controllers.Blocks
{
    public class ExploreOtherRoomsListBlockController : BlockController<ExploreOtherRoomsListBlock>
    {
        private ContentLocator contentLocator;
        private IContentLoader contentLoader;
        public ExploreOtherRoomsListBlockController(ContentLocator contentLocator, IContentLoader contentLoader)
        {
            this.contentLocator = contentLocator;
            this.contentLoader = contentLoader;
        }

        public override ActionResult Index(ExploreOtherRoomsListBlock currentBlock)
        {
            return PartialView(currentBlock);
        }
    }
}
