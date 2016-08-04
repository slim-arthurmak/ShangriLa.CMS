using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using Shangri_La.EpiServer.Common.Business;
using Shangri_La.EpiServer.Common.Business;



namespace Shangri_La.EpiServer.SL.Web.Models.Blocks.HotelHomepage
{
    [ContentType(
        DisplayName = "GalleryContentBlock",
        GroupName = GroupNames.SLHotelHomepageSections, 
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
        [CultureSpecific]
        [Display(
                   Name = "Candid GUID",
                   Description = "Candid GUID",
                   GroupName = SystemTabNames.Content,
                   Order = 1)]
        public virtual string CandidGUID { get; set; }
    }
}