using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using EPiServer.ServiceLocation;

using Shangri_La.EpiServer.SL.Web.Models.Pages;
using Shangri_La.EpiServer.SL.Web.Models.ViewModels;
using Shangri_La.EpiServer.SL.Web.Models.Blocks;


namespace Shangri_La.EpiServer.SL.Web.Controllers.Pages
{
    public class HotelPageController : PageControllerBase<HotelPage>
    {
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

            return View(model);
        }
    }
}