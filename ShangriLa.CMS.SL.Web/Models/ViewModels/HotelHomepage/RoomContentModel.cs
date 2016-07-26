using EPiServer.Core;
using ShangriLa.CMS.SL.Web.Models.Blocks;
using ShangriLa.CMS.SL.Web.Models.Blocks.HotelHomepage;
using System.Collections.Generic;
using System.Linq;

namespace ShangriLa.CMS.SL.Web.Models.ViewModels.HotelHomepage
{
    public class RoomContentModel
    {
        public RoomContentModel(RoomContentBlock block)
        {
            Title = block.Title;
            Description = block.ShortDescription;

            RoomGroups = new List<RoomGroupBlock>();
            RoomGroupNavigatoins = new List<RoomGroupNavigatoinModel>();


            ContentArea contentArea = new ContentArea();
            if (block.FeatureRoomsContentArea != null)
            {
                foreach (ContentAreaItem item in block.FeatureRoomsContentArea.Items)
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

        public string Title { get; set; }

        public string Description { get; set; }

        public List<RoomGroupBlock> RoomGroups { get; set; }

        public List<RoomGroupNavigatoinModel> RoomGroupNavigatoins { get; set; }

        public ContentArea FeatureRoomsContentArea { get; set; }
    }
}