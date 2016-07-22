﻿using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace ShangriLa.CMS.SL.Web.Models.Blocks
{
    [ContentType(DisplayName = "RoomSuiteBlock",
        GroupName = Global.GroupNames.SLDefault,
         GUID = "275712a5-21d6-4ef4-884e-cdbeb2b04250", Description = "")]
    public class RoomSuiteBlock : SiteBlockData
    {
        [CultureSpecific]
        [Display(
                    Name = "Room Name",
                    Description = "Room Name",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
        public virtual string RoomName { get; set; }
        
    }
}