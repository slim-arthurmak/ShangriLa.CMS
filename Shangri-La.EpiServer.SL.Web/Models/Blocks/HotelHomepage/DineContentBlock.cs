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
            DisplayName = "DineContentBlock",
            GroupName = GroupNames.SLHotelHomepageSections,
            GUID = "1a9dbf71-e500-43da-9935-22e4737f2ff8", 
            Description = "")]
    public class DineContentBlock : HotelHomepageContentBlockData
    {
        [AllowedTypes(new[] { typeof(SLDineTeaserBlock) })]
        [Display(
        Name = "Featured Restaurants Content Area",
        Description = "Featured Restaurants",
        GroupName = SystemTabNames.Content,
        Order = 100)]
        public virtual ContentArea FeaturedRestaurantContentArea { get; set; }
    }
}