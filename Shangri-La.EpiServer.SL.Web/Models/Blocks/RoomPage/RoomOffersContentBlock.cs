﻿using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using Shangri_La.EpiServer.Common.Business;

namespace Shangri_La.EpiServer.SL.Web.Models.Blocks.RoomPage
{
    [ContentType(DisplayName = "RoomOffersContentBlock", GUID = "603b7379-fea9-41b8-b3de-6f2d6a186978",
        GroupName = GroupNames.SLRoomDetailPageSections,
        Description = "")]
    public class RoomOffersContentBlock : SectionContentBlockData
    {
       
    }
}