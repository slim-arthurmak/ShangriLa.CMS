using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace Shangri_La.EpiServer.SL.Web.Models.Blocks.HotelHomepage
{
    [ContentType(
        DisplayName = "EventsContentBlock",
        GroupName = Global.GroupNames.SLHotelHomepageSections,
        GUID = "7ee6d369-473a-46bb-962a-f90bbe45ef7f", 
        Description = "")]
    public class EventsContentBlock : HotelHomepageContentBlockData
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