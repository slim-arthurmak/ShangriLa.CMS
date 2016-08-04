using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using Shangri_La.EpiServer.Common.Business;
using Shangri_La.EpiServer.Common.Models.Blocks.SL;

namespace Shangri_La.EpiServer.SL.Web.Models.Blocks.HotelHomepage
{
    [ContentType(DisplayName = "OffersContentBlock",
        GroupName = GroupNames.SLHotelHomepageSections,
        GUID = "bce93a5b-2ee5-4774-a57e-076674de277c", Description = "")]
    public class OffersContentBlock : HotelHomepageContentBlockData
    {
        [AllowedTypes(new[] { typeof(SLOfferTeaserBlock) })]
        [Display(
        Name = "Featured Offers Content Area",
        Description = "Featured Offers",
        GroupName = SystemTabNames.Content,
        Order = 100)]
        public virtual ContentArea FeaturedOffersContentArea { get; set; }
    }
}