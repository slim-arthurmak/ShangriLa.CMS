using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Collections.Generic;

namespace ShangriLa.CMS.SL.Web.Models.Blocks.HotelHomepage
{
    [ContentType(DisplayName = "OverviewContentBlock", GUID = "A0AC3CBA-F13F-40C5-A60A-B1787CA2D9DE", Description = "")]
    [SiteImageUrl]
    public class OverviewContentBlock : HotelHomepageContentBlockData
    {
        /*
        [CultureSpecific]
        [Display(
            Name = "Title",
            Description = "Title",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Title { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Short Description",
            Description = "Short Description",
            GroupName = SystemTabNames.Content,
            Order = 2)]
        [UIHint(UIHint.Textarea)]
        public virtual string ShortDescription { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Long Description",
            Description = "Long Description",
            GroupName = SystemTabNames.Content,
            Order = 3)]
        [UIHint(UIHint.Textarea)]
        public virtual string LongDescription { get; set; }
        */

        [Display(  Name = "Content Image",
                   Description = "3x2 ratio",
                   GroupName = SystemTabNames.Content,
                   Order = 3)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference ContentImage { get; set; }

        [AllowedTypes(new[] { typeof(HotelHighlightBlock) })]
        [Display(
         Name = "Hotel Highlights Content Area",
         Description = "Hotel Highlights",
         GroupName = SystemTabNames.Content,
         Order = 10)]
        public virtual ContentArea HotelHighlightsContentArea { get; set; }


        public IEnumerable<HotelHighlightBlock> HotelHighlights
        {
            get
            {
                if (HotelHighlightsContentArea != null)
                {
                    return HotelHighlightsContentArea.FilteredItems.Select(item => item.GetContent() as HotelHighlightBlock).ToList();
                }

                return Enumerable.Empty<HotelHighlightBlock>(); ;
            }
        }
    }
}