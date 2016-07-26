using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using System.ComponentModel.DataAnnotations;

namespace ShangriLa.CMS.SL.Web.Models.Blocks
{
    [ContentType(DisplayName = "SectionHeaderBanner", GUID = "bb4b2795-5c20-449e-8872-2916dd5104d2", Description = "")]
    public class SectionHeaderBannerBlock : SiteBlockData
    {
        [Display(
                    Name = "Image (Desktop)",
                    Description = "* Required. Must be 1400px width, 700px height",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
        [UIHint(UIHint.Image)]
        //[RequiredImageSize(Width = 1400, Height = 700, ErrorMessage = "Carousel image must be of resolution 1300x500")]
        //[Required(ErrorMessage = "Hero Image (Desktop) is required")]
        public virtual ContentReference DesktopImage { get; set; }

        [Display(
                    Name = "Image (Tablet)",
                    Description = "* Required. Must be 1140px width, 335px height",
                    GroupName = SystemTabNames.Content,
                    Order = 2)]
        [UIHint(UIHint.Image)]
        //[RequiredImageSize(Width = 1300, Height = 500, ErrorMessage = "Carousel image must be of resolution 1300x500")]
        //[Required(ErrorMessage = "Hero Image (Tablet) is required")]
        public virtual ContentReference TabletImage { get; set; }

        [Display(
                    Name = "Image (Mobile)",
                    Description = "* Required. Must be 958px width, 449px height",
                    GroupName = SystemTabNames.Content,
                    Order = 3)]
        [UIHint(UIHint.Image)]
        //[RequiredImageSize(Width = 1300, Height = 500, ErrorMessage = "Carousel image must be of resolution 1300x500")]
        //[Required(ErrorMessage = "Hero Image (Mobile) is required")]
        public virtual ContentReference MobileImage { get; set; }

        [Display(Order = 4, Name = "Alternate Text", Description = "* Required")]
        public virtual string AlternateText { get; set; }

        [Display(Order = 11, Name = "Label", Description = "Label")]
        public virtual string Label { get; set; }

        [Display(Order = 12, Name = "Title", Description = "Title")]
        public virtual string Title { get; set; }

        [Display(Order = 13, Name = "Introduction", Description = "Introduction")]
        [UIHint(UIHint.Textarea)]
        public virtual string Introduction { get; set; }



        //Sets the default property values
        public override void SetDefaultValues(ContentType contentType)
        {
            base.SetDefaultValues(contentType);
            //Set up your defaults here  
        }
    }
}