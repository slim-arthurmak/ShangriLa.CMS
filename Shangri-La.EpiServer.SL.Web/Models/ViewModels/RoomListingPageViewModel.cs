using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using EPiServer.Core;

using Shangri_La.EpiServer.SL.Web.Models.Pages;
using Shangri_La.EpiServer.SL.Web.Models.Blocks;
using Shangri_La.EpiServer.SL.Web.Business;
using Shangri_La.EpiServer.SL.Web.Models.Blocks.RoomPage;
using EPiServer.ServiceLocation;
using EPiServer;
using Shangri_La.EpiServer.SL.Web.Models.ViewModels.RoomPage;
using Shangri_La.EpiServer.SL.Web.Models.ViewModels.RoomListing;
using Shangri_La.EpiServer.SL.Web.Models.ViewModels;
using Shangri_La.EpiServer.SL.Web.Models.Blocks.RoomListing;

namespace Shangri_La.EpiServer.SL.Web.Models.ViewModels
{
    public class RoomListingPageViewModel : PropertyPageViewModel<RoomListingPage>
    {
        public RoomListingPageViewModel(RoomListingPage currentPage) : base(currentPage)
        {
            RoomHeaderBanner = new RoomHeaderBannerViewModel();

            if (currentPage != null)
            {

                var contentRepository = ServiceLocator.Current.GetInstance<IContentRepository>();

                RoomCategoryListNavigatoins = new List<RoomCategoryListNavigatoinModel>();
                OtherRoomGroupListNavigatoins = new List<RoomGroupListingPageViewModel>();
                /*
                RoomSuiteBlock roomSuiteBlock = contentRepository.Get<RoomSuiteBlock>(currentPage.RoomSuiteBlock);

                RoomSuiteBlock = roomSuiteBlock;
                */
                if (currentPage.MainContentArea != null && 
                    currentPage.MainContentArea.Items != null)
                {
                    if (currentPage.MainContentArea != null)
                    {
                        foreach (ContentAreaItem item in currentPage.MainContentArea.Items)
                        {
                            if(item.GetContent() is RoomCategroyListBlock)
                            {
                                RoomCategroyListBlock roomHeaderBannerBlock = (RoomCategroyListBlock) item.GetContent();

                                RoomCategoryListNavigatoinModel Nav = new RoomCategoryListNavigatoinModel(roomHeaderBannerBlock);

                                RoomCategoryListNavigatoins.Add(Nav);
                            }
                        }
                    }
                }

                LinkURL = currentPage.LinkURL;

                if (currentPage.HeaderContentArea != null &&
                    currentPage.HeaderContentArea.Items != null)
                {
                    RoomHeaderBannerBlock roomHeaderBannerBlock = (RoomHeaderBannerBlock)currentPage.HeaderContentArea.Items.FirstOrDefault().GetContent();
                    RoomHeaderBanner = new RoomHeaderBannerViewModel(roomHeaderBannerBlock);
                }
            }
        }

        public string LinkURL { get; set; }

        public RoomHeaderBannerViewModel RoomHeaderBanner { get; set; }

        public List<RoomCategoryListNavigatoinModel> RoomCategoryListNavigatoins { get; set; }

        public List<RoomGroupListingPageViewModel> OtherRoomGroupListNavigatoins { get; set; }

    }
}