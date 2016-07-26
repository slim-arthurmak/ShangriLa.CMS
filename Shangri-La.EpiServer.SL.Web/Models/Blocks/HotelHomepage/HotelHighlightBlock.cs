using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace Shangri_La.EpiServer.SL.Web.Models.Blocks.HotelHomepage
{
    [ContentType(DisplayName = "HotelHighlightBlock", 
        GroupName = Global.GroupNames.SLHotelHomepageSections, 
        GUID = "57486ce2-33e8-4edd-b185-a4c060a09cd3", 
        Description = "")]
    public class HotelHighlightBlock : BlockData
    {

        [CultureSpecific]
        [Display(
            Name = "Highlight",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Highlight { get; set; }

    }
}