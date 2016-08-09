using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using Shangri_La.EpiServer.Common.Business;


namespace Shangri_La.EpiServer.SL.Web.Models.Pages
{
    [ContentType(DisplayName = "DestinationPage", 
        GUID = "BFFFF5F7-6029-452B-8E66-87747EE8EABC", 
        Description = "Destination Page", 
        GroupName = GroupNames.SLPages)]
    public class DestinationPage : SitePageData
    {
        
    }
}