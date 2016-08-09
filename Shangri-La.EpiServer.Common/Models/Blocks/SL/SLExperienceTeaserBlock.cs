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
        DisplayName = "Experience Teaser Block",
        GroupName = GroupNames.SLDefault,
        GUID = "1f213b26-3088-4526-ba6c-8bdb25916d61",
        Description = "Used to provide a stylized entry point to a page on the site")]
    public class SLExperienceTeaserBlock : SLTeaserBlock

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
               Name = "Is Image Right",
               Description = "Right Image Card",
               GroupName = SystemTabNames.Content,
               Order = 100)]
        public virtual bool IsImageRight { get; set; }
    }
}