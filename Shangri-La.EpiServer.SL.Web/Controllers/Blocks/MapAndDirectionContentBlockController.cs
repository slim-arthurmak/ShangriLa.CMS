using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Web;
using EPiServer.Web.Mvc;

using Shangri_La.EpiServer.SL.Web.Models.ViewModels.HotelHomepage;
using Shangri_La.EpiServer.SL.Web.Models.Blocks;
using Shangri_La.EpiServer.SL.Web.Models.Blocks.HotelHomepage;
using Shangri_La.EpiServer.SL.Web.Business;

namespace Shangri_La.EpiServer.SL.Web.Controllers.Blocks
{
    public class MapAndDirectionContentBlockController : BlockController<MapAndDirectionContentBlock>
    {
        private ContentLocator contentLocator;
        private IContentLoader contentLoader;
        public MapAndDirectionContentBlockController(ContentLocator contentLocator, IContentLoader contentLoader)
        {
            this.contentLocator = contentLocator;
            this.contentLoader = contentLoader;
        }

        public override ActionResult Index(MapAndDirectionContentBlock currentBlock)
        {

            MapAndDirectionContentModel model = new MapAndDirectionContentModel(currentBlock);

            var editingHints = ViewData.GetEditHints<MapAndDirectionContentModel, MapAndDirectionContentBlock>();

            // Adds a connection between 'Heading' in view model and 'MyText' in content data.
            editingHints.AddConnection(m => m.Heading, p => p.Heading);
            editingHints.AddConnection(m => m.IntroText, p => p.IntroText);
            editingHints.AddConnection(m => m.MainText, p => p.MainText);

            return PartialView(model);
        }
    }
}
