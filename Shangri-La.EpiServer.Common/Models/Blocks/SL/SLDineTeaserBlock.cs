using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using Shangri_La.EpiServer.Common.Business;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Shangri_La.EpiServer.Common.Models.Blocks.SL
{
    [ContentType(
        DisplayName = "Dine Teaser Block",
        GroupName = GroupNames.SLDefault,
        GUID = "acae4aed-d3b0-442c-9170-69caf43757af",
        Description = "Used to provide a stylized entry point to a page on the site")]
    public class SLDineTeaserBlock : SLTeaserBlock
    {
        [CultureSpecific]
        [Display(
              Name = "Label",
              Description = "New Opening, Member Favourite",
              GroupName = SystemTabNames.Content,
              Order = 100)]
        public virtual string Label { get; set; }

        [CultureSpecific]
        [Display(
            Name = "CuisineType",
            Description = "Cuisine Type",
            GroupName = SystemTabNames.Content,
            Order = 110)]
        public virtual string CuisineType { get; set; }


        [Display(Name = "Price Pange",
            Description = "Price Pange",
            GroupName = SystemTabNames.Content, Order = 120)]
        [Range(1, 5)]
        [DefaultValue(3)]
        public virtual int PricePange { get; set; }

        [Display(
              Name = "Phone",
              Description = "",
              GroupName = SystemTabNames.Content,
              Order = 130)]
        public virtual string Phone { get; set; }
    }
}