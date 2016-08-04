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
        DisplayName = "Offer Teaser Block",
        GroupName = GroupNames.SLDefault,
        GUID = "b3dbf6e2-4824-44f9-9fca-0c158e12720d",
        Description = "Used to provide a stylized entry point to a page on the site")]
    public class SLOfferTeaserBlock : SLTeaserBlock
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