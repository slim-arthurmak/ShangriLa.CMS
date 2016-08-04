﻿using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.ServiceLocation;
using EPiServer.Web;
using Shangri_La.EpiServer.Common.Business;
using Shangri_La.EpiServer.SL.Web.Models.Blocks;
using Shangri_La.EpiServer.SL.Web.Models.Blocks.HotelHomepage;
using System.ComponentModel.DataAnnotations;

namespace Shangri_La.EpiServer.SL.Web.Models.Pages
{
    [ContentType(DisplayName = "HotelPage", 
        GUID = "19EA638C-376D-4216-9353-9E34D4C07B05", 
        Description = "Hotel Page", 
        GroupName = GroupNames.SLPages)]
    public class HotelPage : SitePageData
    {
        /*
        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString MainBody { get; set; }


        public virtual ContentReference DestinationLink { get; set; }

        // BOOT CAMP: Custom UIHint
        [UIHint("hotel-type-select")]
        [Display(
            Name = "Hotel Type",
            GroupName = SystemTabNames.Content,
            Order = 50)]
        public virtual string HotelType { get; set; }
        */

        [Display(
                  Name = "Hotel Block",
                  Description = "Hotel Block",
                  GroupName = Global.GroupNames.HotelSettings,
                  Order = 1)]
        [AllowedTypes(typeof(HotelBlock))]
        [UIHint(UIHint.Block)]
        [Required]
        public virtual ContentReference HotelBlock { get; set; }

        [Display(Name = "Hero Banner Block",
            GroupName = SystemTabNames.Content,
            Order = 5)]
        //[CultureSpecific]
        //[MaxItemCount(1)]
        //[AllowedTypes(typeof(MainCarouselBlock))]
        public virtual HeroBannerBlock HeroBanner { get; set; }

        [AllowedTypes(new[] { typeof(OverviewContentBlock),
            typeof(RoomContentBlock),
            typeof(DineContentBlock),
            typeof(OffersContentBlock),
            typeof(ExperienceContentBlock),
            typeof(EventsContentBlock),
            typeof(GalleryContentBlock),
            typeof(MapAndDirectionContentBlock) })]
        [Display(
                  Name = "Section Content Area",
                  Description = "Hotel Content Blocks",
                  GroupName = SystemTabNames.Content,
                  Order = 110)]
        public virtual ContentArea SectionContentArea { get; set; }


        public override void SetDefaultValues(ContentType contentType)
        {
            base.SetDefaultValues(contentType);
            //Set up your defaults here  

            if (!ContentReference.IsNullOrEmpty(this.HotelBlock))
            {
                //HeroBanner.Title = this.HotelBlock. as HotelBlock();
                var contentRepository = ServiceLocator.Current.GetInstance<IContentRepository>();

                HotelBlock hotelBlock = contentRepository.Get<HotelBlock>(this.HotelBlock);
                HeroBanner.Title = hotelBlock.HotelShortName;
            }
                
        }
    }
}