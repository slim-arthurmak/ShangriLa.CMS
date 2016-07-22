using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace ShangriLa.CMS.SL.Web.Models.Blocks.HotelHomepage
{
    [ContentType(DisplayName = "MapAndDirectionContentBlock",
        GroupName = Global.GroupNames.SLHotelHomepageSections,
        GUID = "2bb14733-2b41-4f84-b77b-2b19cb25285f", Description = "")]
    public class MapAndDirectionContentBlock : HotelHomepageContentBlockData
    {
        /*
                [CultureSpecific]
                [Display(
                    Name = "Name",
                    Description = "Name field's description",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
                public virtual string Name { get; set; }
         */
    }
}