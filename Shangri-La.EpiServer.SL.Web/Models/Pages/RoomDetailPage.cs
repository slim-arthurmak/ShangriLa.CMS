using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using Shangri_La.EpiServer.SL.Web.Models.Blocks;
using System.ComponentModel.DataAnnotations;
using Shangri_La.EpiServer.SL.Web.Models.Blocks.RoomPage;

namespace Shangri_La.EpiServer.SL.Web.Models.Pages
{
    [ContentType(DisplayName = "RoomDetailPage", GUID = "22ba9772-9e1f-47f8-9ae8-2999c7193eff", Description = "", GroupName = Global.GroupNames.SLPages)]
    public class RoomDetailPage : SitePageData
    {
        [Display(
                  Name = "Room Suite Block",
                  Description = "Room Suite Block",
                  GroupName = SystemTabNames.Content,
                  Order = 1)]
        [AllowedTypes(typeof(RoomSuiteBlock))]
        [Required(ErrorMessage = "Room Suite Block is required")]
        [UIHint(UIHint.Block)]
        public virtual ContentReference RoomSuiteBlock { get; set; }

        [Display(Name = "Header Banner",
                GroupName = SystemTabNames.Content,
                Order = 11)]
        //[CultureSpecific]
        //[MaxItemCount(1)]
        //[AllowedTypes(typeof(MainCarouselBlock))]
        public virtual SectionHeaderBannerBlock HeaderBanner { get; set; }


        [Display(Name = "RoomFeatures",
                GroupName = SystemTabNames.Content,
                Order = 21)]
        public virtual SectionOverviewContentBlock RoomFeatures { get; set; }

        [AllowedTypes(new[] {   typeof(SectionHightlightContentBlock),
                                typeof(RoomOffersContentBlock),
                                typeof(ExploreOtherRoomsContentBlock)})]
        [Display(
                  Name = "Section Content Area",
                  Description = "Room Content Blocks",
                  GroupName = SystemTabNames.Content,
                  Order = 110)]
        public virtual ContentArea SectionContentArea { get; set; }
    }
}