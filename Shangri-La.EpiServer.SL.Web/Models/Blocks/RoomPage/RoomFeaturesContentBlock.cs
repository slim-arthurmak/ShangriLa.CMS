using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace Shangri_La.EpiServer.SL.Web.Models.Blocks.RoomPage
{
    [ContentType(DisplayName = "RoomFeaturesContentBlock", GUID = "920c41ee-49fa-46cf-9103-46d474b3ff6b",
        GroupName = Global.GroupNames.SLRoomDetailPageSections,
        Description = "")]
    public class RoomFeaturesContentBlock : SectionOverviewContentBlock
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