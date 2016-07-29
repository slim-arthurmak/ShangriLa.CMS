using EPiServer;
using EPiServer.Core;
using EPiServer.ServiceLocation;
using EPiServer.Web.Mvc;
using EPiServer.Web.Routing;

using Shangri_La.EpiServer.SL.Web.Business;
using Shangri_La.EpiServer.SL.Web.Models.Blocks.RoomPage;
using Shangri_La.EpiServer.SL.Web.Models.ViewModels.RoomPage;

using System.Web.Mvc;


namespace Shangri_La.EpiServer.SL.Web.Controllers.Blocks
{
    public class RoomHeaderBannerBlockController : BlockControllerBase<RoomHeaderBannerBlock>
    {
        private ContentLocator contentLocator;
        private IContentLoader contentLoader;

        public RoomHeaderBannerBlockController(ContentLocator contentLocator, IContentLoader contentLoader) : base(contentLocator, contentLoader)
        {
            this.contentLocator = contentLocator;
            this.contentLoader = contentLoader;
        }

        public override ActionResult Index(RoomHeaderBannerBlock currentBlock)
        {
            RoomHeaderBannerViewModel model = new RoomHeaderBannerViewModel(currentBlock);

            //set Default Label Text
            if (string.IsNullOrEmpty(model.Label))
            {
                if (Hotel != null)
                {
                    model.Label = Hotel.HotelName;
                }
            }


            // Get the edit hint collections
            EditHintCollection<RoomHeaderBannerViewModel, RoomHeaderBannerBlock> editingHints = ViewData.GetEditHints<RoomHeaderBannerViewModel, RoomHeaderBannerBlock>();

            // Adds a connection between 'Heading' in view model and 'MyText' in content data.
            editingHints.AddConnection(m => m.Image, p => p.DesktopImage);
            editingHints.AddConnection(m => m.AlternateText, p => p.AlternateText);

            editingHints.AddConnection(m => m.Label, p => p.Label);
            editingHints.AddConnection(m => m.Title, p => p.Title);
            editingHints.AddConnection(m => m.Introduction, p => p.Introduction);

            return PartialView(model);
        }
        
    }
}
