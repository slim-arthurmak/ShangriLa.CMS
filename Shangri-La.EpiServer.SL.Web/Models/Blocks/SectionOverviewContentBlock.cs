using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Collections.Generic;

using Shangri_La.EpiServer.SL.Web.Models.Properties;
using Shangri_La.EpiServer.Common.Business;

namespace Shangri_La.EpiServer.SL.Web.Models.Blocks
{
    [ContentType(
        DisplayName = "SectionOverviewContentBlock",
        GUID = "ba247296-abde-42a1-b415-b3d3cf482a8e",
        GroupName = GroupNames.SLDefault,
        Description = "")]
    [SiteImageUrl]
    public class SectionOverviewContentBlock : SectionContentBlockData
    {
        /*
        [Display(Name = "Content Image",
                   Description = "3x2 ratio",
                   GroupName = SystemTabNames.Content,
                   Order = 11)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference ContentImage { get; set; }
        */
        [BackingType(typeof(PropertyStringList))]
        [Display(Name = "Highlights",
                   Description = "Place items on separate lines",
                   GroupName = SystemTabNames.Content,
                   Order = 100)]
        [UIHint(SiteUIHints.Strings)]
        [CultureSpecific]
        public virtual string[] Highlights { get; set; }
    }
}