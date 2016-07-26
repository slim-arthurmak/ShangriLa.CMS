using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace Shangri_La.EpiServer.SL.Web.Models.Blocks
{
    [ContentType(DisplayName = "RestaurantBlock",
        GroupName = Global.GroupNames.SLDefault,
         GUID = "1678931c-a2ca-4ee4-9c3a-54cccb610cf9", Description = "")]
    public class RestaurantBlock : BlockData
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