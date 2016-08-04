using EPiServer.DataAnnotations;
using EPiServer.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Shangri_La.EpiServer.Common.Business
{
    [GroupDefinitions]
    public static class GroupNames
    {
        // Page Groups
        public const string SLDefault = "SL";
        public const string SLPages = "SL Pages";
        public const string SLContainerPages = "SL Container Pages";
        public const string SLHotelHomepageSections = "SL - Hotel Homepage Sections";

        public const string SLRoomListingPageSections = "SL - Room Listing Page Sections";
        public const string SLRoomDetailPageSections = "SL - Room Detail Page Sections";
    }
}
