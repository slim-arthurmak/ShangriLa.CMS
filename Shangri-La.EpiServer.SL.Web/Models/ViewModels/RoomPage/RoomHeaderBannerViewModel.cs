using EPiServer.Core;
using Shangri_La.EpiServer.SL.Web.Models.Blocks;
using Shangri_La.EpiServer.SL.Web.Models.Blocks.RoomPage;
using System.Collections.Generic;
using System.Linq;


namespace Shangri_La.EpiServer.SL.Web.Models.ViewModels.RoomPage
{
    public class RoomHeaderBannerViewModel
    {
        public RoomHeaderBannerViewModel()
        {
        }

        public RoomHeaderBannerViewModel(RoomHeaderBannerBlock block)
        {
            Label = block.Label;
            Introduction = block.Introduction;
            Image = block.DesktopImage;
            AlternateText = block.AlternateText;

            TeaserText = block.TeaserText;
        }

        public string Label { get; set; }

        public string Title { get; set; }

        public string Introduction { get; set; }

        public ContentReference Image { get; set; }

        public string AlternateText { get; set; }

        public string TeaserText { get; set; }
    }
}