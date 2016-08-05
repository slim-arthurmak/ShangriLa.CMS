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
using Shangri_La.EpiServer.SL.Web.Business;

namespace Shangri_La.EpiServer.SL.Web.Controllers.Blocks
{
    public class HeroHeaderBannerBlockController : BlockController<HeroHeaderBannerBlock>
    {
        private ContentLocator contentLocator;
        private IContentLoader contentLoader;
        public HeroHeaderBannerBlockController(ContentLocator contentLocator, IContentLoader contentLoader)
        {
            this.contentLocator = contentLocator;
            this.contentLoader = contentLoader;
        }

        public override ActionResult Index(HeroHeaderBannerBlock currentBlock)
        {

            HeroHeaderBannerViewModel model = new HeroHeaderBannerViewModel(currentBlock);

            SetEditingHints();

            return PartialView(model);
        }

        private void SetEditingHints()
        {
            EditHintCollection<HeroHeaderBannerViewModel, HeroHeaderBannerBlock> editingHints = ViewData.GetEditHints<HeroHeaderBannerViewModel, HeroHeaderBannerBlock>();

            // Adds a connection between 'Heading' in view model and 'MyText' in content data.
            editingHints.AddConnection(m => m.Image, p => p.DesktopImage);
            editingHints.AddConnection(m => m.AlternateText, p => p.AlternateText);

            editingHints.AddConnection(m => m.Label, p => p.Label);
            editingHints.AddConnection(m => m.Title, p => p.Title);
            editingHints.AddConnection(m => m.Introduction, p => p.Introduction);
        }
    }
}
