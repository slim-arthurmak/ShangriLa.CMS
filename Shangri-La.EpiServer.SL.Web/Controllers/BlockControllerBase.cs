using EPiServer;
using EPiServer.Core;
using EPiServer.ServiceLocation;
using EPiServer.Web.Mvc;
using EPiServer.Web.Routing;
using Shangri_La.EpiServer.SL.Web.Business;
using Shangri_La.EpiServer.SL.Web.Models.Blocks;
using Shangri_La.EpiServer.SL.Web.Models.Pages;
using System.Linq;

namespace Shangri_La.EpiServer.SL.Web.Controllers
{
    public class BlockControllerBase<T> : BlockController<T> where T : SiteBlockData
    {
        private ContentLocator contentLocator;
        private IContentLoader contentLoader;

        private PageRouteHelper pageRouteHelper;
        private UrlResolver urlResolver;

        private PageData _currentPage;
        private HotelBlock _hotel;
        public BlockControllerBase(ContentLocator contentLocator, IContentLoader contentLoader)
        {
            this.contentLocator = contentLocator;
            this.contentLoader = contentLoader;

            this.pageRouteHelper = ServiceLocator.Current.GetInstance<PageRouteHelper>();
            this.urlResolver = ServiceLocator.Current.GetInstance<UrlResolver>();

            this._currentPage = this.pageRouteHelper.Page;

            _hotel = GetHotelBlock();

            //PageReference pageReference = pageRouteHelper.PageLink;
            //_currentPage = pageRouteHelper.Page;
            
        }

        public PageData CurrentPage
        {
            get { return _currentPage; }
        }

        public HotelBlock Hotel
        {
            get { return _hotel;  }
        }

        protected HotelBlock GetHotelBlock()
        {
            HotelBlock hotelBlock = null;

            //PageData _currentPage = pageRouteHelper.Page;
            HotelPage hotelPage = (HotelPage)FindHotelPage(_currentPage);

            if (hotelPage != null)
            {
                hotelBlock = contentLoader.Get<HotelBlock>(hotelPage.HotelBlock);
            }

            return hotelBlock;
        }

        protected IContent FindHotelPage(PageData currentPage)
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