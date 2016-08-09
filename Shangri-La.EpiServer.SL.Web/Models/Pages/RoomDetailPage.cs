using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using Shangri_La.EpiServer.SL.Web.Models.Blocks;
using System.ComponentModel.DataAnnotations;
using Shangri_La.EpiServer.SL.Web.Models.Blocks.RoomPage;
using Shangri_La.EpiServer.Common.Business.Attributes;
using Shangri_La.EpiServer.Common.Business;


namespace Shangri_La.EpiServer.SL.Web.Models.Pages
{
    [ContentType(DisplayName = "RoomDetailPage", GUID = "22ba9772-9e1f-47f8-9ae8-2999c7193eff", Description = "", GroupName = GroupNames.SLPages)]
    [ContentImage("RoomDetailPage.PNG")]
    public class RoomDetailPage : SitePageData
    {
        [Display(
                  Name = "Room Suite Block",
                  Description = "Room Suite Block",
                  GroupName = SystemTabNames.Content,
                  Order = 10)]
        [AllowedTypes(typeof(RoomSuiteBlock))]
        //[Required(ErrorMessage = "Room Suite Block is required")]
        [UIHint(UIHint.Block)]
        public virtual ContentReference RoomSuiteBlock { get; set; }

        [AllowedTypes(new[] { typeof(RoomHeaderBannerBlock) })]
        [Display(
                  Name = "Header Content Area",
                  Description = "Header Content Blocks",
                  GroupName = SystemTabNames.Content,
                  Order = 30)]
        public virtual ContentArea HeaderContentArea { get; set; }


        [AllowedTypes(new[] { typeof(SectionOverviewContentBlock ), typeof(MosaicBannerCarouselBlock) })]
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