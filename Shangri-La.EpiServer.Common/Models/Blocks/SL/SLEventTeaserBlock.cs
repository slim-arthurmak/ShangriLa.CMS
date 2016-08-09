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
        DisplayName = "Event Teaser Block",
        GroupName = GroupNames.SLDefault,
        GUID = "6a6d6285-eecc-4e1f-adc8-bde5642554fc",
        Description = "Used to provide a stylized entry point to a page on the site")]
    public class SLEventTeaserBlock : SLTeaserBlock
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