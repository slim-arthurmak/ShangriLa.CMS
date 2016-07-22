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

            /*
            var pageRouteHelper = EPiServer.ServiceLocation.ServiceLocator.Current.GetInstance<EPiServer.Web.Routing.PageRouteHelper>();
            var pageReference = pageRouteHelper.PageLink;

            if (block.RoomGroupContentArea != null)
            {
                RoomGroups = block.RoomGroupContentArea.FilteredItems.Select(item => item.GetContent() as RoomGroupBlock).ToList();
            }
            */
            FeatureRoomsContentArea = block.FeatureRoomsContentArea;
        }

        public string Title { get; set; }
        public string Description { get; set; }

        public List<RoomGroupBlock> RoomGroups { get; set; }

        public List<RoomGroupNavigatoinModel> RoomGroupNavigatoins { get; set; }

        public virtual IList<ContentReference> FeatureRoomsContentArea { get; set; }
    }
}