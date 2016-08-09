using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using Shangri_La.EpiServer.Common.Business;
using Shangri_La.EpiServer.Common.Models.Blocks;



namespace Shangri_La.EpiServer.SL.Web.Models.Blocks.HotelHomepage
{
    [ContentType(
        DisplayName = "HotelHomepageContentBlockData",
        GroupName = GroupNames.SLHotelHomepageSections,
        GUID = "906e138f-31d9-4649-947a-5f340e97a7b7",
        Description = "")]
    [SiteImageUrl]
    public class HotelHomepageContentBlockData : SiteBlockData
    {
        [CultureSpecific]
        [Display(
            Name = "Heading",
            Description = "Heading",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Heading { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Intro Text",
            Description = "Intro Text",
            GroupName = SystemTabNames.Content,
            Order = 2)]
        [UIHint(UIHint.Textarea)]
        public virtual string IntroText { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Main Text",
            Description = "Main Text",
            GroupName = SystemTabNames.Content,
            Order = 3)]
        [UIHint(UIHint.Textarea)]
        public virtual string MainText { get; set; }

        [Display(
            Name = "Block CTA",
            Description = "Block CTA",
            GroupName = SystemTabNames.Content,
            Order = 4)]
        public virtual ButtonBlock BlockCTA { get; set; }

    }
}