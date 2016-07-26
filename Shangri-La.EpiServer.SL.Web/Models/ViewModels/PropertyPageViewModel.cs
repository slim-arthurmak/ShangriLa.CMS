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
    public class PropertyPageViewModel<T> : PageViewModel<T> where T : SitePageData
    {
        public PropertyPageViewModel() : base()
        {
            BookingPanel = new BookingPanelModel();
        }

        public PropertyPageViewModel(T currentPage) : base(currentPage)
        {
            BookingPanel = new BookingPanelModel();
        }


        public BookingPanelModel BookingPanel { get; set; }

        public HotelBlock Hotel { get; set; }
    }
}