using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System.Linq;
using System.Collections.Generic;
using Shangri_La.EpiServer.SL.Web.Models.Pages;

namespace Shangri_La.EpiServer.SL.Web.Models.Blocks.RoomPage
{
    [ContentType(
        DisplayName = "ExploreOtherRoomsContentBlock", 
        GUID = "6d991e4b-4426-470d-856a-d2d024919a54", 
        Description = "",
        GroupName = Global.GroupNames.SLPages)]
    public class ExploreOtherRoomsContentBlock : BlockData
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