
using Shangri_La.EpiServer.SL.Web.Models.Blocks;
using Shangri_La.EpiServer.SL.Web.Models.Pages;



namespace Shangri_La.EpiServer.SL.Web.Models.ViewModels
{
    public class PropertyPageViewModel<T> : PageViewModel<T> where T : SitePageData
    {
        public PropertyPageViewModel() : base()
        {
            BookingPanel = new BookingPanelModel();
            HotelInformationSummary = new HotelInformationSummaryViewModel();
        }

        public PropertyPageViewModel(T currentPage) : base(currentPage)
        {
            BookingPanel = new BookingPanelModel();
            HotelInformationSummary = new HotelInformationSummaryViewModel();
        }


        public BookingPanelModel BookingPanel { get; set; }

        public HotelBlock Hotel { get; set; }
        public HotelInformationSummaryViewModel HotelInformationSummary { get; set; }
    }
}