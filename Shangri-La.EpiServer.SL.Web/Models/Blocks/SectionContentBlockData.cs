using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using System.ComponentModel.DataAnnotations;

using Shangri_La.EpiServer.SL.Web;


namespace Shangri_La.EpiServer.SL.Web.Models.Blocks
{
    [ContentType(DisplayName = "SectionContentBlockData", 
        GUID = "b3a417fe-3337-4687-ac99-069d46d0832a",
        GroupName = Global.GroupNames.SLDefault,
        Description = "")]
    public class SectionContentBlockData : SiteBlockData
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

        [CultureSpecific]
        [Display(
          Name = "Teaser Text",
          Description = "Teaser Text",
          GroupName = SystemTabNames.Content,
          Order = 4)]
        [UIHint(UIHint.Textarea)]
        public virtual string TeaserText { get; set; }

        [Display(
                   Name = "Image",
                   Description = "",
                   GroupName = SystemTabNames.Content,
                   Order = 10)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference Image { get; set; }


        [Display(
            Name = "Block CTA",
            Description = "Block CTA",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual ButtonBlock BlockCTA { get; set; }

        [Display(
            Name = "Block Button Link",
            Description = "Block Button Link",
            GroupName = SystemTabNames.Content,
            Order = 30)]
        public virtual ButtonBlock BlockButtonLink { get; set; }
    }
}