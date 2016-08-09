using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using Shangri_La.EpiServer.Common.Business;
using Shangri_La.EpiServer.Common.Models.Blocks.SL;


namespace Shangri_La.EpiServer.SL.Web.Models.Blocks.HotelHomepage
{
    [ContentType(
        DisplayName = "EventsContentBlock",
        GroupName = GroupNames.SLHotelHomepageSections,
        GUID = "7ee6d369-473a-46bb-962a-f90bbe45ef7f", 
        Description = "")]
    public class EventsContentBlock : HotelHomepageContentBlockData
    {
        [AllowedTypes(new[] { typeof(SLEventTeaserBlock) })]
        [Display(
        Name = "Featured Events Content Area",
        Description = "Special Events & Conferences Section",
        GroupName = SystemTabNames.Content,
        Order = 100)]
        public virtual ContentArea FeaturedEventsContentArea { get; set; }
    }
}