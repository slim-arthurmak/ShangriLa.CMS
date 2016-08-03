using EPiServer.Core;
using Shangri_La.EpiServer.SL.Web.Models.Blocks;
using Shangri_La.EpiServer.SL.Web.Models.Blocks.RoomPage;
using Shangri_La.EpiServer.SL.Web.Models.Blocks.RoomListing;
using System.Collections.Generic;
using System.Linq;

namespace Shangri_La.EpiServer.SL.Web.Models.ViewModels.RoomListing
{
    public class HorizonClubListViewModel
    {
        public HorizonClubListViewModel(HorizonClubListBlock block)
        {
            RoomType = block.RoomType;
            Heading = block.Heading;
            IntroText = block.IntroText;
            MainText = block.MainText;
            Image = block.Image;
            BlockCTA = block.BlockCTA;
            BlockButtonLink = block.BlockButtonLink;

            //LinkURL = string.Format("{0}_{1}", RoomType, ((IContent)block).ContentGuid);
        }

        public string RoomType { get; set; }

        public string Heading { get; set; }

        public string IntroText { get; set; }

        public string MainText { get; set; }

        public ContentReference Image { get; set; }

        public string AlternateText { get; set; }

        public ButtonBlock BlockCTA { get; set; }

        public ButtonBlock BlockButtonLink { get; set; }

        public List<RoomDetailPageViewModel> AllRooms { get; set; }

        public string LinkURL { get; set; }

    }
}