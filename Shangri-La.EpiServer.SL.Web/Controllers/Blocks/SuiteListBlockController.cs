using EPiServer;
using EPiServer.Core;
using EPiServer.ServiceLocation;
using EPiServer.Web.Mvc;
using EPiServer.Web.Routing;

using Shangri_La.EpiServer.SL.Web.Business;
using Shangri_La.EpiServer.SL.Web.Models.Pages;
using Shangri_La.EpiServer.SL.Web.Models.Blocks.RoomListing;
using Shangri_La.EpiServer.SL.Web.Models.ViewModels.RoomListing;
using Shangri_La.EpiServer.SL.Web.Models.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Shangri_La.EpiServer.SL.Web.Controllers.Blocks
{
    public class SuiteListBlockController : BlockControllerBase<SuiteListBlock>
    {
        private ContentLocator contentLocator;
        private IContentLoader contentLoader;
        public SuiteListBlockController(ContentLocator contentLocator, IContentLoader contentLoader) : base(contentLocator, contentLoader)
        {
            this.contentLocator = contentLocator;
            this.contentLoader = contentLoader;
        }

        public override ActionResult Index(SuiteListBlock currentBlock)
        {
            SuiteListViewModel model = new SuiteListViewModel(currentBlock);

            SetEditingHints();

            if (CurrentPage != null)
            {
                if (CurrentPage is RoomListingPage)
                {
                    model.AllRooms = GetAllRooms(currentBlock.RoomType);
                }
            }

            return PartialView(model);
        }

        private List<RoomDetailPageViewModel> GetAllRooms(string roomType)
        {
            List<RoomDetailPageViewModel> Rooms = new List<RoomDetailPageViewModel>();

            IEnumerable<PageData> pages = FindPages(CurrentPageReference, typeof(RoomDetailPage), true);


            if (pages != null)
            {
                foreach (PageData page in pages)
                {
                    if (page is RoomDetailPage)
                    {
                        RoomDetailPage roomPage = (RoomDetailPage)page;

                        RoomDetailPageViewModel room = new RoomDetailPageViewModel(roomPage);

                        if (room != null && room.RoomSuiteBlock != null && string.Equals(room.RoomSuiteBlock.RoomType, roomType, System.StringComparison.InvariantCultureIgnoreCase))
                        {
                            Rooms.Add(room);
                        }

                        //string url = urlResolver.GetVirtualPath(page).VirtualPath;

                        /*
                        if (listingPage.RoomGroupBlock != null)
                        {
                            RoomGroupBlock roomGroup = contentLoader.Get<RoomGroupBlock>(listingPage.RoomGroupBlock);
                            model.RoomGroups.Add(roomGroup);

                            model.RoomGroupNavigatoins.Add(
                                new RoomGroupNavigatoinModel()
                                {
                                    Title = roomGroup.RoomGroupName,
                                    Description = roomGroup.Teaser,
                                    Url = page.LinkURL
                                });

                        }
                        */
                    }
                }
            }

            return Rooms;
        }

        private void SetEditingHints()
        {
            EditHintCollection<SuiteListViewModel, SuiteListBlock> editingHints = ViewData.GetEditHints<SuiteListViewModel, SuiteListBlock>();

            // Adds a connection between 'Heading' in view model and 'MyText' in content data.
            //editingHints.AddConnection(m => m.Image, p => p.Image);

            editingHints.AddConnection(m => m.Heading, p => p.Heading);
            editingHints.AddConnection(m => m.IntroText, p => p.IntroText);
            editingHints.AddConnection(m => m.MainText, p => p.MainText);
            editingHints.AddConnection(m => m.Image, p => p.Image);
            //editingHints.AddConnection(m => m.FeatureRoomsContentArea, p => p.FeatureRoomsContentArea);
            /*
            editingHints.AddConnection(m => m.MainText, p => p.MainText);
            editingHints.AddConnection(m => m.Highlights, p => p.Highlights);

            editingHints.AddConnection(m => m.BlockCTA, p => p.BlockCTA);
            editingHints.AddConnection(m => m.BlockButtonLink, p => p.BlockButtonLink);
            */
        }
    }
}
