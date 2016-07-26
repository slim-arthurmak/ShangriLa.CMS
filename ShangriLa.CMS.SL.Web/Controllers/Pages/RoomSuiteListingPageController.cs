using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using EPiServer.ServiceLocation;

using ShangriLa.CMS.SL.Web.Models.Pages;
using ShangriLa.CMS.SL.Web.Models.ViewModels;
using ShangriLa.CMS.SL.Web.Models.Blocks;

using ShangriLa.CMS.SL.Web.Business;



namespace ShangriLa.CMS.SL.Web.Controllers.Pages
{
    public class RoomSuiteListingPageController : PageControllerBase<RoomSuiteListingPage>
    {
        private ContentLocator contentLocator;
        private IContentLoader contentLoader;
        public RoomSuiteListingPageController(ContentLocator contentLocator, IContentLoader contentLoader)
        {
            this.contentLocator = contentLocator;
            this.contentLoader = contentLoader;
        }

        public ActionResult Index(RoomSuiteListingPage currentPage)
        {
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */
            //DefaultPageViewModel<RoomSuiteListingPage> model = new DefaultPageViewModel<RoomSuiteListingPage>(currentPage);
            PropertyPageViewModel<RoomSuiteListingPage> model = new PropertyPageViewModel<RoomSuiteListingPage>(currentPage);
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
                .SkipWhile(x => x.ParentLink == null || x.ParentLink.ID != typeof(HotelPage).GetPageType().ID)
                .FirstOrDefault();
        }
    }
}