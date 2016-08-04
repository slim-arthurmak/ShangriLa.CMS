using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using Shangri_La.EpiServer.Common.Business;
using Shangri_La.EpiServer.Common.Business.Attributes;
using System.ComponentModel.DataAnnotations;


namespace Shangri_La.EpiServer.Common.Models.Blocks.SL
{
    [ContentType(
        DisplayName = "SL Teaser Block",
        GroupName = GroupNames.SLDefault,
        GUID = "91f82300-dcd5-4e86-81d9-aa5fdf8ba1ca",
        Description = "Used to provide a stylized entry point to a page on the site")]
    [ContentImage("TeaserBlock.PNG")]
    public class SLTeaserBlock : SiteBlockData
    {
        [Display(
            Name = "Header",
            Description = "",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        [CultureSpecific]
        [Required(AllowEmptyStrings = false)]
        public virtual string Heading { get; set; }

        [Display(
            Name = "Text",
            Description = "",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        [CultureSpecific]
        [Required(AllowEmptyStrings = false)]
        [UIHint(UIHint.LongString)]
        public virtual string Text { get; set; }

        [Display(
            Name = "Image",
            Description = "",
            GroupName = SystemTabNames.Content,
            Order = 30)]
        [Required]
        [UIHint(UIHint.Image)]
        public virtual ContentReference Image { get; set; }

        [Display(
            Name = "Link",
            Description = "",
            GroupName = SystemTabNames.Content,
            Order = 40)]
        [Required]
        public virtual PageReference Link { get; set; }

        [Display(Name = "Campaign", GroupName = SystemTabNames.Content)]
        public virtual string Campaign { get; set; }
    }
}