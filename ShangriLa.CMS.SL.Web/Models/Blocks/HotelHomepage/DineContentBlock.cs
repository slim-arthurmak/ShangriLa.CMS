using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace ShangriLa.CMS.SL.Web.Models.Blocks.HotelHomepage
{
    [ContentType(
            DisplayName = "DineContentBlock",
            GroupName = Global.GroupNames.SLHotelHomepageSections,
            GUID = "1a9dbf71-e500-43da-9935-22e4737f2ff8", 
            Description = "")]
    public class DineContentBlock : HotelHomepageContentBlockData
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