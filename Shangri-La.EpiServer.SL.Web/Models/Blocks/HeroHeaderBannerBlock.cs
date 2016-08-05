using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using System.ComponentModel.DataAnnotations;
using Shangri_La.EpiServer.Common.Business;
using Shangri_La.EpiServer.Common.Models.Blocks;


namespace Shangri_La.EpiServer.SL.Web.Models.Blocks
{
    [ContentType(DisplayName = "Hero Header Banner Block",
                GroupName = GroupNames.SLDefault,
                GUID = "b1beba54-eb9c-4c59-bd33-74038ece1961", 
                Description = "")]
    public class HeroHeaderBannerBlock : SiteBlockData
    {
        [Display(
                    Name = "Image (Desktop)",
                    Description = "* Required. Must be 1500px width, 750px height (2:1)",
                    GroupName = SystemTabNames.Content,
                    Order = 10)]
        [UIHint(UIHint.Image)]
        //[RequiredImageSize(Width = 1400, Height = 700, ErrorMessage = "Carousel image must be of resolution 1300x500")]
        //[Required(ErrorMessage = "Hero Image (Desktop) is required")]
        public virtual ContentReference DesktopImage { get; set; }

        [Display(
                    Name = "Image (Tablet)",
                    Description = "",
                    GroupName = SystemTabNames.Content,
                    Order = 20)]
        [UIHint(UIHint.Image)]
        //[RequiredImageSize(Width = 1300, Height = 500, ErrorMessage = "Carousel image must be of resolution 1300x500")]
        //[Required(ErrorMessage = "Hero Image (Tablet) is required")]
        public virtual ContentReference TabletImage { get; set; }

        [Display(
                    Name = "Image (Mobile)",
                    Description = "",
                    GroupName = SystemTabNames.Content,
                    Order = 30)]
        [UIHint(UIHint.Image)]
        //[RequiredImageSize(Width = 1300, Height = 500, ErrorMessage = "Carousel image must be of resolution 1300x500")]
        //[Required(ErrorMessage = "Hero Image (Mobile) is required")]
        public virtual ContentReference MobileImage { get; set; }

        [Display(
            Name = "Alternate Text",
            Description = "Alternate Text",
            GroupName = SystemTabNames.Content,
            Order = 40)]
        public virtual string AlternateText { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Label",
            Description = "Label",
            GroupName = SystemTabNames.Content,
            Order = 50)]
        public virtual string Label { get; set; }

        [CultureSpecific]
        [Display(
          Name = "Title",
          Description = "Title",
          GroupName = SystemTabNames.Content,
          Order = 60)]
        public virtual string Title { get; set; }

        [Display(
            Name = "Introduction",
            Description = "Introduction",
            GroupName = SystemTabNames.Content,
            Order = 70)]
        [UIHint(UIHint.Textarea)]
        public virtual string Introduction { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Teaser text",
            Description = "Teaser text",
            GroupName = SystemTabNames.Content,
            Order = 110)]
        [UIHint(UIHint.Textarea)]
        public virtual string TeaserText { get; set; }



        //Sets the default property values
        public override void SetDefaultValues(ContentType contentType)
        {
            base.SetDefaultValues(contentType);
            //Set up your defaults here  
        }
    }
}