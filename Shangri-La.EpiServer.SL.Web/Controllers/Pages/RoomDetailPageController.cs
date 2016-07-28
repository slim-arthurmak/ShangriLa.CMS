using EPiServer;
using EPiServer.Core;
using Shangri_La.EpiServer.SL.Web.Business;
using Shangri_La.EpiServer.SL.Web.Models.Blocks;
using Shangri_La.EpiServer.SL.Web.Models.Pages;
using Shangri_La.EpiServer.SL.Web.Models.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace Shangri_La.EpiServer.SL.Web.Controllers.Pages
{
    public class RoomDetailPageController : PageControllerBase<RoomDetailPage>
    {
        private ContentLocator contentLocator;
        private IContentLoader contentLoader;
        public RoomDetailPageController(ContentLocator contentLocator, IContentLoader contentLoader)
        {
            this.contentLocator = contentLocator;
            this.contentLoader = contentLoader;
        }

        public ActionResult Index(RoomDetailPage currentPage)
        {
            RoomDetailPageViewModel model = new RoomDetailPageViewModel(currentPage);
            model.RoomSuiteBlock = contentLoader.Get<RoomSuiteBlock>(currentPage.RoomSuiteBlock);

            //model.CurrentPage.HeaderBanner.Title = model.RoomSuiteBlock.RoomName;

            HotelPage hotelPage = (HotelPage)FindHotelPage(currentPage);

            if (hotelPage != null)
            {
                HotelBlock hotelBlock = contentLoader.Get<HotelBlock>(hotelPage.HotelBlock);
                if (hotelBlock != null)
                {
                    model.Hotel = hotelBlock;
                    model.HotelInformationSummary = new HotelInformationSummaryViewModel(model.Hotel);
                    //model.CurrentPage.HeaderBanner.Label = hotelBlock.HotelShortName;
                }
            }

            return View(model);
        }

        private IContent FindHotelPage(PageData currentPage)
        {
            if (currentPage.ParentLink != null && currentPage.ParentLink.ID == typeof(HotelPage).GetPageType().ID)
            {
                return contentLoader.Get<IContent>(currentPage.ParentLink);
            }

            return contentLoader.GetAncestors(currentPage.ContentLink)
                .OfType<HotelPage>()
                //.SkipWhile(x => x.ParentLink == null || x.ParentLink.ID != typeof(HotelPage).GetPageType().ID)
                .FirstOrDefault();
        }
    }
}