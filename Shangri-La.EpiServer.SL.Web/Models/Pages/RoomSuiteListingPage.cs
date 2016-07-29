using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using Shangri_La.EpiServer.SL.Web.Models.Blocks;
using System.ComponentModel.DataAnnotations;


namespace Shangri_La.EpiServer.SL.Web.Models.Pages
{
    [ContentType(DisplayName = "RoomSuiteListingPage", 
        GUID = "c0b9598d-4534-4d54-98ff-0a59390cceec", 
        Description = "", 
        GroupName = Global.GroupNames.SLPages)]
    [AvailableContentTypes(Include = new[] { typeof(RoomDetailPage) })]
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