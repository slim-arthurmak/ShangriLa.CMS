using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace ShangriLa.CMS.SL.Web.Models.Blocks.HotelHomepage
{
    [ContentType(
        DisplayName = "GalleryContentBlock",
        GroupName = Global.GroupNames.SLHotelHomepageSections, 
        GUID = "a6a2f62e-1cfc-4a87-8c49-23b1d8970fbb", 
        Description = "")]
    public class GalleryContentBlock : HotelHomepageContentBlockData
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