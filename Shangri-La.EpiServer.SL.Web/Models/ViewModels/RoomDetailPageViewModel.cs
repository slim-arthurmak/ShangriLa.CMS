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

namespace Shangri_La.EpiServer.SL.Web.Models.ViewModels
{
    public class RoomDetailPageViewModel : PropertyPageViewModel<RoomDetailPage>
    {
        public RoomDetailPageViewModel(RoomDetailPage currentPage) : base(currentPage)
        {
            RoomHeaderBanner = new RoomHeaderBannerViewModel();

            if (currentPage != null && currentPage.RoomSuiteBlock != null)
            {

                var contentRepository = ServiceLocator.Current.GetInstance<IContentRepository>();

                RoomSuiteBlock roomSuiteBlock = contentRepository.Get<RoomSuiteBlock>(currentPage.RoomSuiteBlock);

                RoomSuiteBlock = roomSuiteBlock;

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

        public RoomSuiteBlock RoomSuiteBlock { get; set; }
    }
}