using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using EPiServer.Core;

using Shangri_La.EpiServer.SL.Web.Models.Pages;
using Shangri_La.EpiServer.SL.Web.Models.Blocks;
using Shangri_La.EpiServer.SL.Web.Business;


namespace Shangri_La.EpiServer.SL.Web.Models.ViewModels
{
    public class RoomDetailPageViewModel : PropertyPageViewModel<RoomDetailPage>
    {
        public RoomDetailPageViewModel(RoomDetailPage currentPage) : base(currentPage)
        {

        }

        public RoomSuiteBlock RoomSuiteBlock { get; set; }
    }
}