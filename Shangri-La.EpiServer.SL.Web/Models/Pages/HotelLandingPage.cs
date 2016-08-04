﻿using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using Shangri_La.EpiServer.Common.Business;


namespace Shangri_La.EpiServer.SL.Web.Models.Pages
{
    [ContentType(

        DisplayName = "HotelLandingPage",
        GUID = "1112A3B4-2C44-4D2E-8E65-4C3802D92C69",
        Description = "Hotel Landing Page",
        GroupName = GroupNames.SLContainerPages)]
    [AvailableContentTypes(Include = new[] { typeof(HotelPage) })]
    public class HotelLandingPage : SitePageData
    {

    }
}