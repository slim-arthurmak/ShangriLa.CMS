using EPiServer.Core;
using Shangri_La.EpiServer.SL.Web.Models.Blocks;
using Shangri_La.EpiServer.SL.Web.Models.Blocks.HotelHomepage;
using System.Collections.Generic;
using System.Linq;
using Shangri_La.EpiServer.Common.Models.Blocks.SL;

namespace Shangri_La.EpiServer.SL.Web.Models.ViewModels.HotelHomepage
{
    public class MapAndDirectionContentModel
    {
        public MapAndDirectionContentModel(MapAndDirectionContentBlock block)
        {
            Heading = block.Heading;
            IntroText = block.IntroText;
            MainText = block.IntroText;

            LocationInfogramPoints = new List<SLLocationInfogramBlock>();

            ContentArea contentArea = new ContentArea();
            if (block.LocationInfogramBlocks != null)
            {
                foreach (ContentAreaItem item in block.LocationInfogramBlocks.Items)
                {
                    SLLocationInfogramBlock point = (SLLocationInfogramBlock)item.GetContent();
                    LocationInfogramPoints.Add(point);
                }
            }
           
        }

        public string Heading { get; set; }

        public string IntroText { get; set; }

        public string MainText { get; set; }

        public List<RoomGroupBlock> RoomGroups { get; set; }

        public List<SLLocationInfogramBlock> LocationInfogramPoints { get; set; }

    }
}