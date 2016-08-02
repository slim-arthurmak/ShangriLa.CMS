using EPiServer;
using EPiServer.ServiceLocation;
using Shangri_La.EpiServer.SL.Web.Business;
using Shangri_La.EpiServer.SL.Web.Models.Blocks;
using Shangri_La.EpiServer.SL.Web.Models.Pages;
using Shangri_La.EpiServer.SL.Web.Models.ViewModels;
using System.Web.Mvc;



namespace Shangri_La.EpiServer.SL.Web.Controllers.Pages
{
    public class HotelPageController : PageControllerBase<HotelPage>
    {
        private ContentLocator contentLocator;
        private IContentLoader contentLoader;
        public HotelPageController(ContentLocator contentLocator, IContentLoader contentLoader) : base(contentLocator, contentLoader)
        {
            this.contentLocator = contentLocator;
            this.contentLoader = contentLoader;
        }

        public ActionResult Index(HotelPage currentPage)
        {
            var contentRepository = ServiceLocator.Current.GetInstance<IContentRepository>();

            HotelBlock hotelBlock = contentRepository.Get<HotelBlock>(currentPage.HotelBlock);

            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */
            PropertyPageViewModel<HotelPage> model = new PropertyPageViewModel<HotelPage>(currentPage);
            //PropertyPageViewModel model = new PropertyPageViewModel(currentPage);

            model.Hotel = hotelBlock;
            model.HotelInformationSummary = new HotelInformationSummaryViewModel(model.Hotel);
            model.HeaderLogo = Hotel.Logo;

            return View(model);
        }
    }
}