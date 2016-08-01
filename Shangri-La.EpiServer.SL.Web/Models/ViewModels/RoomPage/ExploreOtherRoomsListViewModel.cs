using EPiServer.Core;
using Shangri_La.EpiServer.SL.Web.Models.Blocks;
using Shangri_La.EpiServer.SL.Web.Models.Blocks.RoomPage;
using System.Collections.Generic;
using System.Linq;

namespace Shangri_La.EpiServer.SL.Web.Models.ViewModels.RoomPage
{
    public class ExploreOtherRoomsListViewModel
    {
        public ExploreOtherRoomsListViewModel(ExploreOtherRoomsListBlock block)
        {
            Heading = block.Heading;
            IntroText = block.IntroText;

            //RoomGroups = new List<RoomGroupBlock>();
            //RoomGroupNavigatoins = new List<RoomGroupNavigatoinModel>();

            ContentArea contentArea = new ContentArea();
            if (block.FeatureRoomsContentArea != null)
            {
                foreach (ContentAreaItem item in block.FeatureRoomsContentArea.FilteredItems)
                {
                    contentArea.Items.Add(new ContentAreaItem
                    {
                        ContentLink = item.ContentLink,
                        RenderSettings = item.RenderSettings,
                        AllowedRoles = item.AllowedRoles,
                        ContentGroup = item.ContentGroup,
                        ContentGuid = item.ContentGuid
                    });
                }
            }

            FeatureRoomsContentArea = contentArea;
        }

        public string Heading { get; set; }

        public string IntroText { get; set; }

        //public List<RoomGroupBlock> RoomGroups { get; set; }

        //public List<RoomGroupNavigatoinModel> RoomGroupNavigatoins { get; set; }

        public ContentArea FeatureRoomsContentArea { get; set; }
    }
}