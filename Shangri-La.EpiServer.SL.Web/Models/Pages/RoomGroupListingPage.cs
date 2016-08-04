using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using Shangri_La.EpiServer.SL.Web.Models.Blocks;
using System.ComponentModel.DataAnnotations;
using Shangri_La.EpiServer.Common.Business;

namespace Shangri_La.EpiServer.SL.Web.Models.Pages
{
    [ContentType(DisplayName = "RoomGroupListingPage",
        GUID = "5b68f70f-1823-4f16-ab8f-1acabeb03a2c",
        Description = "",
        GroupName = GroupNames.SLPages)]
    [AvailableContentTypes(Include = new[] { typeof(RoomListingPage), typeof(RoomDetailPage) })]
    public class RoomGroupListingPage : RoomListingPage
    {
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