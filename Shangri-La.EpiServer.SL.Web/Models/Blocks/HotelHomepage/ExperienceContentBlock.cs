using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using Shangri_La.EpiServer.Common.Business;
using Shangri_La.EpiServer.Common.Models.Blocks.SL;



namespace Shangri_La.EpiServer.SL.Web.Models.Blocks.HotelHomepage
{
    [ContentType(DisplayName = "ExperienceContentBlock",
        GroupName = GroupNames.SLHotelHomepageSections,
        GUID = "ff3f6dc1-06f2-44d2-9027-fe60e914064f", Description = "")]
    public class ExperienceContentBlock : HotelHomepageContentBlockData
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