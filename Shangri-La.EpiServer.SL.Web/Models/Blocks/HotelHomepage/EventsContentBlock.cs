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
        [AllowedTypes(new[] { typeof(SLExperienceTeaserBlock) })]
        [Display(
        Name = "Featured Experiences Content Area",
        Description = "Featured Experiences",
        GroupName = SystemTabNames.Content,
        Order = 100)]
        public virtual ContentArea FeaturedExperiencesContentArea { get; set; }
    }
}