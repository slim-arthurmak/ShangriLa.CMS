using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System.Linq;
using System.Collections.Generic;

namespace ShangriLa.CMS.SL.Web.Models.Blocks.HotelHomepage
{ 
    [ContentType(DisplayName = "RoomContentBlock", 
        GroupName="Hotel Homepage Sections", 
        GUID = "7888b2ca-2732-49a7-8b6c-8c4e4085b254", Description = "")]
    [SiteImageUrl]
    public class RoomContentBlock : HotelHomepageContentBlockData
    {
        /*
        [CultureSpecific]
        [Display(
            Name = "Name",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Name { get; set; }
         */


        [AllowedTypes(new[] { typeof(RoomGroupBlock) })]
        [Display(
          Name = "Room Group Content Area",
          Description = "Room Group Blocks",
          GroupName = SystemTabNames.Content,
          Order = 10)]
        public virtual ContentArea RoomGroupContentArea { get; set; }

        [AllowedTypes(new[] { typeof(RoomSuiteBlock) })]
        [Display(
         Name = "Feature Rooms Content Area",
         Description = "Feature Rooms",
         GroupName = SystemTabNames.Content,
         Order = 10)]
        public virtual ContentArea FeatureRoomsContentArea { get; set; }

        public IEnumerable<RoomGroupBlock> RoomGroups
        {
            get
            {
                if (RoomGroupContentArea != null)
                {
                    return RoomGroupContentArea.FilteredItems.Select(item => item.GetContent() as RoomGroupBlock).ToList();
                }

                return Enumerable.Empty<RoomGroupBlock>(); ;
            }
        }

        //public IEnumerable<RoomGroupBlock> FeatureRooms
        //{
        //    get; set;
        //}
    }
}