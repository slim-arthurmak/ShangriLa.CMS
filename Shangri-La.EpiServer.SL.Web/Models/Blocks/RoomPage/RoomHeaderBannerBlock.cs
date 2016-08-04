using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using Shangri_La.EpiServer.Common.Business;


namespace Shangri_La.EpiServer.SL.Web.Models.Blocks.RoomPage
{
    [ContentType(DisplayName = "RoomHeaderBannerBlock", GUID = "5b8fe888-1c1d-451e-9a7f-d2a5c3b5191a",
        GroupName = GroupNames.SLRoomDetailPageSections,
        Description = "")]
    public class RoomHeaderBannerBlock : SectionHeaderBannerBlock
    {

    }
}