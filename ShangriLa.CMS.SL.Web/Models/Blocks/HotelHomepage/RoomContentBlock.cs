using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System.Linq;
using System.Collections.Generic;
using ShangriLa.CMS.SL.Web.Models.Pages;

namespace ShangriLa.CMS.SL.Web.Models.Blocks.HotelHomepage
{
    [ContentType(DisplayName = "RoomContentBlock",
        GroupName = Global.GroupNames.SLHotelHomepageSections,
        GUID = "7888b2ca-2732-49a7-8b6c-8c4e4085b254",
        Description = "")]
    [SiteImageUrl]
    public class RoomContentBlock : HotelHomepageContentBlockData
    {
        [AllowedTypes(new[] { typeof(RoomSuitePage) })]
        [Display(
        Name = "Feature Rooms Content Area",
        Description = "Feature Rooms",
        GroupName = SystemTabNames.Content,
        Order = 10)]
        public virtual ContentArea FeatureRoomsContentArea { get; set; }
    }
}