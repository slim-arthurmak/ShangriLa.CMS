using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using ShangriLa.CMS.SL.Web.Models.Blocks;
using System.ComponentModel.DataAnnotations;

using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Collections.Generic;

using ShangriLa.CMS.SL.Web.Models.Properties;

namespace ShangriLa.CMS.SL.Web.Models.Pages
{
    [ContentType(DisplayName = "RoomSuitePage", GUID = "22ba9772-9e1f-47f8-9ae8-2999c7193eff", Description = "", GroupName = Global.GroupNames.SLPages)]
    public class RoomSuitePage : SitePageData
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

    }
}