using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using Shangri_La.EpiServer.SL.Web.Models.Blocks;
using System.ComponentModel.DataAnnotations;


namespace Shangri_La.EpiServer.SL.Web.Models.Pages
{
    [ContentType(DisplayName = "RoomListingPage", 
        GUID = "c0b9598d-4534-4d54-98ff-0a59390cceec", 
        Description = "", 
        GroupName = Global.GroupNames.SLPages)]
    [AvailableContentTypes(Include = new[] { typeof(RoomGroupListingPage), typeof(RoomDetailPage) })]
    public class RoomListingPage : SitePageData
    {
       
    }
}