using EPiServer.Core;
using Shangri_La.EpiServer.SL.Web.Models.Blocks;
using Shangri_La.EpiServer.SL.Web.Models.Blocks.RoomPage;
using System.Collections.Generic;
using System.Linq;


namespace Shangri_La.EpiServer.SL.Web.Models.ViewModels.RoomPage
{
    public class RoomFeaturesContentViewModel
    {
        public RoomFeaturesContentViewModel(RoomFeaturesContentBlock block)
        {
            Heading = block.Heading;
            IntroText = block.IntroText;
            MainText = block.MainText;
            Image = block.Image;
            BlockCTA = block.BlockCTA;
            BlockButtonLink = block.BlockButtonLink;
            Highlights = block.Highlights;
        }

        public string Heading { get; set; }

        public string IntroText { get; set; }

        public string MainText { get; set; }

        public ContentReference Image { get; set; }

        public string AlternateText { get; set; }

        public ButtonBlock BlockCTA { get; set; }

        public ButtonBlock BlockButtonLink { get; set; }

        public string[] Highlights { get; set; }
    }
}