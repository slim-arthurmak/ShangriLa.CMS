using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System.Linq;
using System.Collections.Generic;
using Shangri_La.EpiServer.SL.Web.Models.Pages;
using Shangri_La.EpiServer.Common.Business;


namespace Shangri_La.EpiServer.SL.Web.Models.Blocks.HotelHomepage
{
    [ContentType(DisplayName = "RoomContentBlock",
        GroupName = GroupNames.SLHotelHomepageSections,
        GUID = "7888b2ca-2732-49a7-8b6c-8c4e4085b254",
        Description = "")]
    [SiteImageUrl]
    public class RoomContentBlock : HotelHomepageContentBlockData
    {
        [AllowedTypes(new[] { typeof(RoomDetailPage) })]
        [Display(
        Name = "Feature Rooms Content Area",
        Description = "Feature Rooms",
        GroupName = SystemTabNames.Content,
        Order = 10)]
        public virtual ContentArea FeatureRoomsContentArea { get; set; }
    }
}