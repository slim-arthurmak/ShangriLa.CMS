using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using EPiServer.ServiceLocation;
using EPiServer.Web.Routing;

using Shangri_La.EpiServer.SL.Web.Models.Pages;
using Shangri_La.EpiServer.SL.Web.Models.ViewModels;
using Shangri_La.EpiServer.SL.Web.Models.Blocks;

using Shangri_La.EpiServer.SL.Web.Business;



namespace Shangri_La.EpiServer.SL.Web.Controllers.Pages
{
    public class RoomListingPageController : PageControllerBase<RoomListingPage>
    {
        private ContentLocator contentLocator;
        private IContentLoader contentLoader;
        public RoomListingPageController(ContentLocator contentLocator, IContentLoader contentLoader) : base(contentLocator, contentLoader)
        {
            this.contentLocator = contentLocator;
            this.contentLoader = contentLoader;
        }

        public ActionResult Index(RoomListingPage currentPage)
        {
            UrlResolver urlResolver = ServiceLocator.Current.GetInstance<UrlResolver>();
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */
            //DefaultPageViewModel<RoomSuiteListingPage> model = new DefaultPageViewModel<RoomSuiteListingPage>(currentPage);
            RoomListingPageViewModel model = new RoomListingPageViewModel(currentPage);

            model.Hotel = this.Hotel;
            model.HeaderLogo = Hotel.Logo;

            return View(model);
        }

    }
}