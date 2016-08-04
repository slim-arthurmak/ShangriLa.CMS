using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using Shangri_La.EpiServer.Common.Business;


namespace Shangri_La.EpiServer.SL.Web.Models.Blocks
{
    [ContentType(
        DisplayName = "MosaicBannerCarouselBlock", 
        GUID = "3cc56df4-4fa4-41fc-989c-3abf8f9b6ac2",
        GroupName = GroupNames.SLDefault,
        Description = "")]
    public class MosaicBannerCarouselBlock : BlockData
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