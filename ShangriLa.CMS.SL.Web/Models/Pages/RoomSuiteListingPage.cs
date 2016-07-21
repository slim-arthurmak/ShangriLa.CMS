using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.ServiceLocation;
using EPiServer.SpecializedProperties;
using EPiServer.Web;

using ShangriLa.CMS.SL.Web.Business.Extensions.EditorDescriptor;
using ShangriLa.CMS.SL.Web.Helpers;
using ShangriLa.CMS.SL.Web.Models.Blocks;
using ShangriLa.CMS.SL.Web.Models.Blocks.HotelHomepage;

using System;
using System.ComponentModel.DataAnnotations;


namespace ShangriLa.CMS.SL.Web.Models.Pages
{
    [ContentType(GroupName = "Property Pages", DisplayName = "RoomSuiteListingPage", GUID = "c0b9598d-4534-4d54-98ff-0a59390cceec", Description = "")]
    [AvailableContentTypes(Include = new[] { typeof(RoomSuitePage) })]
    public class RoomSuiteListingPage : SitePageData
    {
        /*
                [CultureSpecific]
                [Display(
                    Name = "Main body",
                    Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
                public virtual XhtmlString MainBody { get; set; }
         */

        [Display(
                 Name = "Room Group Block",
                 Description = "Room Group Block",
                 Order = 1)]
        [AllowedTypes(typeof(RoomGroupBlock))]
        [UIHint(UIHint.Block)]
        [Required]
        public virtual ContentReference RoomGroupBlock { get; set; }
    }
}