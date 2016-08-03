using EPiServer.Core;
using Shangri_La.EpiServer.SL.Web.Models.Blocks;
using Shangri_La.EpiServer.SL.Web.Models.Blocks.HotelHomepage;
using System.Collections.Generic;
using System.Linq;



namespace Shangri_La.EpiServer.SL.Web.Models.ViewModels.HotelHomepage
{
    public class RoomGroupNavigatoinModel
    {
        public string Heading { get; set; }
        public string IntroText { get; set; }

        public ContentReference Image { get; set; }

        public string LinkURL { get; set; }
    }
}