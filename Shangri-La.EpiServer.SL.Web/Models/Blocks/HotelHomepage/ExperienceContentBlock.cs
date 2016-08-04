﻿using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using Shangri_La.EpiServer.Common.Business;


namespace Shangri_La.EpiServer.SL.Web.Models.Blocks.HotelHomepage
{
    [ContentType(DisplayName = "ExperienceContentBlock",
        GroupName = GroupNames.SLHotelHomepageSections,
        GUID = "ff3f6dc1-06f2-44d2-9027-fe60e914064f", Description = "")]
    public class ExperienceContentBlock : HotelHomepageContentBlockData
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