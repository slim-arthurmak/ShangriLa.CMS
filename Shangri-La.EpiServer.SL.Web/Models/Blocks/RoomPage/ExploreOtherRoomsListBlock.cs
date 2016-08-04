using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System.Linq;
using System.Collections.Generic;
using Shangri_La.EpiServer.SL.Web.Models.Pages;
using Shangri_La.EpiServer.Common.Business;


namespace Shangri_La.EpiServer.SL.Web.Models.Blocks.RoomPage
{
    [ContentType(
        DisplayName = "Explore Other Rooms List Block", 
        GUID = "6d991e4b-4426-470d-856a-d2d024919a54",
        GroupName = GroupNames.SLRoomDetailPageSections,
        Description = "")]
    public class ExploreOtherRoomsListBlock : SectionContentBlockData
    {
        [AllowedTypes(new[] { typeof(RoomDetailPage) })]
        [Display(
        Name = "Feature Rooms Content Area",
        Description = "Feature Rooms",
        GroupName = SystemTabNames.Content,
        Order = 20)]
        public virtual ContentArea FeatureRoomsContentArea { get; set; }
    }
}