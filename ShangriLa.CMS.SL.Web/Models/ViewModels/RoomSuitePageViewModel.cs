using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using EPiServer.Core;

using ShangriLa.CMS.SL.Web.Models.Pages;
using ShangriLa.CMS.SL.Web.Models.Blocks;
using ShangriLa.CMS.SL.Web.Business;


namespace ShangriLa.CMS.SL.Web.Models.ViewModels
{
    public class RoomSuitePageViewModel : PropertyPageViewModel<RoomSuitePage>
    {
        public RoomSuitePageViewModel(RoomSuitePage currentPage) : base(currentPage)
        {

        }

        public RoomSuiteBlock RoomSuiteBlock { get; set; }
    }
}