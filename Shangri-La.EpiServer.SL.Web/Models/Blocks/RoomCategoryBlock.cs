﻿using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using Shangri_La.EpiServer.Common.Business;


namespace Shangri_La.EpiServer.SL.Web.Models.Blocks
{
    [ContentType(DisplayName = "RoomCategoryBlock",
        GUID = "4bca9857-9ee1-4e0c-bce2-4cb5b0089ed6",
        GroupName = GroupNames.SLDefault,
        Description = "")]
    public class RoomCategoryBlock : BlockData
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