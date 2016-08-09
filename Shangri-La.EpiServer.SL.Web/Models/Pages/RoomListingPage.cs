using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using Shangri_La.EpiServer.SL.Web.Models.Blocks;
using Shangri_La.EpiServer.SL.Web.Models.Blocks.RoomPage;
using Shangri_La.EpiServer.SL.Web.Models.Blocks.RoomListing;
using System.ComponentModel.DataAnnotations;
using Shangri_La.EpiServer.Common.Business;

namespace Shangri_La.EpiServer.SL.Web.Models.Pages
{
    [ContentType(DisplayName = "RoomListingPage", 
        GUID = "c0b9598d-4534-4d54-98ff-0a59390cceec", 
        Description = "", 
        GroupName = GroupNames.SLPages)]
    [AvailableContentTypes(Include = new[] { typeof(RoomGroupListingPage), typeof(RoomDetailPage) })]
    public class RoomListingPage : SitePageData
    {
        [AllowedTypes(new[] { typeof(RoomHeaderBannerBlock) })]
        [Display(
                   Name = "Header Content Area",
                   Description = "Header Content Blocks",
                   GroupName = SystemTabNames.Content,
                   Order = 30)]
        public virtual ContentArea HeaderContentArea { get; set; }

        [AllowedTypes(new[] { typeof(RoomCategroyListBlock), typeof(HorizonClubListBlock) , typeof(SuiteListBlock) })]
        [Display(
                  Name = "Main Content Area",
                  Description = "Main Content Area (Room Suite Properties)",
                  GroupName = SystemTabNames.Content,
                  Order = 40)]
        public virtual ContentArea MainContentArea { get; set; }

        [AllowedTypes(new[] {   typeof(SectionHightlightContentBlock),
                                typeof(RoomOffersContentBlock),
                                typeof(ExploreOtherRoomsListBlock)})]
        [Display(
                  Name = "Section Content Area",
                  Description = "Section Content Area",
                  GroupName = SystemTabNames.Content,
                  Order = 60)]
        public virtual ContentArea SectionContentArea { get; set; }
    }
}