using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using Shangri_La.EpiServer.Common.Business;
using Shangri_La.EpiServer.Common.Models.Blocks.SL;

namespace Shangri_La.EpiServer.SL.Web.Models.Blocks.HotelHomepage
{
    [ContentType(DisplayName = "MapAndDirectionContentBlock",
        GroupName = GroupNames.SLHotelHomepageSections,
        GUID = "2bb14733-2b41-4f84-b77b-2b19cb25285f", Description = "")]
    public class MapAndDirectionContentBlock : HotelHomepageContentBlockData
    {
        [AllowedTypes(new[] { typeof(SLLocationInfogramBlock) })]
        [Display(
        Name = "Location Infogram Blocks",
        Description = "Location Infogram",
        GroupName = SystemTabNames.Content,
        Order = 100)]
        public virtual ContentArea LocationInfogramBlocks { get; set; }
    }
}