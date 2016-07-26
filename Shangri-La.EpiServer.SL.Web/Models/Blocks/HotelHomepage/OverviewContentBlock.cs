using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Collections.Generic;

using Shangri_La.EpiServer.SL.Web.Models.Properties;

namespace Shangri_La.EpiServer.SL.Web.Models.Blocks.HotelHomepage
{
    [ContentType(
        DisplayName = "OverviewContentBlock",
        GroupName = Global.GroupNames.SLHotelHomepageSections,
        GUID = "A0AC3CBA-F13F-40C5-A60A-B1787CA2D9DE", 
        Description = "")]
    [SiteImageUrl]
    public class OverviewContentBlock : HotelHomepageContentBlockData
    {
        [Display(  Name = "Content Image",
                   Description = "3x2 ratio",
                   GroupName = SystemTabNames.Content,
                   Order = 11)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference ContentImage { get; set; }

        //[Required]
        [BackingType(typeof(PropertyStringList))]
        [Display(Name = "Hotel Highlights",
                   Description = "Place items on separate lines",
                   GroupName = SystemTabNames.Content,
                   Order = 12)]
        [UIHint(Global.SiteUIHints.Strings)]
        [CultureSpecific]
        public virtual string[] HotelHighlights { get; set; }
    }
}