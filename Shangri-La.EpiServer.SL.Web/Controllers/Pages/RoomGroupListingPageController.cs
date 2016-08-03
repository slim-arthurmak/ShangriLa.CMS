using EPiServer;
using EPiServer.Core;
using EPiServer.ServiceLocation;
using EPiServer.Web.Routing;
using Shangri_La.EpiServer.SL.Web.Business;
using Shangri_La.EpiServer.SL.Web.Models.Pages;
using Shangri_La.EpiServer.SL.Web.Models.Blocks;
using Shangri_La.EpiServer.SL.Web.Models.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;




namespace Shangri_La.EpiServer.SL.Web.Controllers.Pages
{
    public class RoomGroupListingPageController : PageControllerBase<RoomGroupListingPage>
    {
        private ContentLocator contentLocator;
        private IContentLoader contentLoader;
        public RoomGroupListingPageController(ContentLocator contentLocator, IContentLoader contentLoader) : base(contentLocator, contentLoader)
        {
            this.contentLocator = contentLocator;
            this.contentLoader = contentLoader;
        }

        public ActionResult Index(RoomGroupListingPage currentPage)
        {
            UrlResolver urlResolver = ServiceLocator.Current.GetInstance<UrlResolver>();
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */
            //DefaultPageViewModel<RoomSuiteListingPage> model = new DefaultPageViewModel<RoomSuiteListingPage>(currentPage);
            RoomGroupListingPageViewModel model = new RoomGroupListingPageViewModel(currentPage);

            model.OtherRoomGroupListNavigatoins = new List<RoomGroupListingPageViewModel>();

            IEnumerable<PageData> pages = FindPages(currentPage.ParentLink, typeof(RoomGroupListingPage), false);


            //RoomGroupBlock roomGroupBlock = contentLoader.Get<RoomGroupBlock>(currentPage.RoomGroupBlock);

            if (pages != null)
            {
                foreach (PageData page in pages)
                {
                    if (page is RoomGroupListingPage)
                    {
                        if (!string.Equals(page.URLSegment, currentPage.URLSegment, System.StringComparison.InvariantCultureIgnoreCase))
                        {
                            RoomGroupListingPage listingPage = (RoomGroupListingPage)page;
                            model.OtherRoomGroupListNavigatoins.Add(new RoomGroupListingPageViewModel(listingPage));
                        }
                    }
                }
            }

            model.Hotel = this.Hotel;
            model.HeaderLogo = Hotel.Logo;

            return View(model);
        }
    }
}