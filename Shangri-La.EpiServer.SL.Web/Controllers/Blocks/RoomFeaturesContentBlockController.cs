using EPiServer;
using EPiServer.Core;
using EPiServer.ServiceLocation;
using EPiServer.Web.Mvc;
using EPiServer.Web.Routing;

using Shangri_La.EpiServer.SL.Web.Business;
using Shangri_La.EpiServer.SL.Web.Models.Blocks;
using Shangri_La.EpiServer.SL.Web.Models.Pages;
using Shangri_La.EpiServer.SL.Web.Models.Blocks.RoomPage;
using Shangri_La.EpiServer.SL.Web.Models.ViewModels.RoomPage;

using System.Web.Mvc;
using System.Linq;


namespace Shangri_La.EpiServer.SL.Web.Controllers.Blocks
{
    public class RoomFeaturesContentBlockController : BlockControllerBase<RoomFeaturesContentBlock>
    {
        private ContentLocator contentLocator;
        private IContentLoader contentLoader;

        public RoomFeaturesContentBlockController(ContentLocator contentLocator, IContentLoader contentLoader) : base(contentLocator, contentLoader)
        {
            this.contentLocator = contentLocator;
            this.contentLoader = contentLoader;
        }

        public override ActionResult Index(RoomFeaturesContentBlock currentBlock)
        {
            RoomFeaturesContentViewModel model = new RoomFeaturesContentViewModel(currentBlock);
  
            //set Default Label Text
            if (!(model.Highlights != null && model.Highlights.Length > 0))
            {
                RoomSuiteBlock roomSuiteBlock = GetRoomSuiteBlock();

                if (roomSuiteBlock != null && roomSuiteBlock.RoomFeatures != null)
                {
                    model.Highlights = roomSuiteBlock.RoomFeatures;
                }

                //model.Highlights = new string[] { "ABC", "DEF" };
            }


            // Get the edit hint collections
            EditHintCollection<RoomFeaturesContentViewModel, RoomFeaturesContentBlock> editingHints = ViewData.GetEditHints<RoomFeaturesContentViewModel, RoomFeaturesContentBlock>();

            // Adds a connection between 'Heading' in view model and 'MyText' in content data.
            editingHints.AddConnection(m => m.Image, p => p.Image);

            editingHints.AddConnection(m => m.Heading, p => p.Heading);
            editingHints.AddConnection(m => m.IntroText, p => p.IntroText);
            editingHints.AddConnection(m => m.MainText, p => p.MainText);
            editingHints.AddConnection(m => m.Highlights, p => p.Highlights);

            editingHints.AddConnection(m => m.BlockCTA, p => p.BlockCTA);
            editingHints.AddConnection(m => m.BlockButtonLink, p => p.BlockButtonLink);

            return PartialView(model);
        }

        protected RoomSuiteBlock GetRoomSuiteBlock()
        {
            RoomSuiteBlock roomSuiteBlock = null;

            if (CurrentPage != null && CurrentPage.ContentTypeID == typeof(RoomDetailPage).GetPageType().ID)
            {
                //PageData _currentPage = pageRouteHelper.Page;
                RoomDetailPage roomPage = (RoomDetailPage)CurrentPage;

                if (roomPage != null)
                {
                    roomSuiteBlock = contentLoader.Get<RoomSuiteBlock>(roomPage.RoomSuiteBlock);
                }
            }

            return roomSuiteBlock;
        }
    }
}
