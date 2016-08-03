using EPiServer.Core;
using Shangri_La.EpiServer.SL.Web.Models.Blocks;
using Shangri_La.EpiServer.SL.Web.Models.Blocks.RoomPage;
using Shangri_La.EpiServer.SL.Web.Models.Blocks.RoomListing;
using System.Collections.Generic;
using System.Linq;

namespace Shangri_La.EpiServer.SL.Web.Models.ViewModels.RoomListing
{
    public class RoomCategroyListViewModel
    {
        public RoomCategroyListViewModel(RoomCategroyListBlock block)
        {
            RoomType = block.RoomType;

            Heading = block.Heading;
            IntroText = block.IntroText;

            
        }

        public string RoomType { get; set; }

        public string Heading { get; set; }

        public string IntroText { get; set; }

        public List<RoomDetailPageViewModel> AllRooms { get; set; }


    }
}