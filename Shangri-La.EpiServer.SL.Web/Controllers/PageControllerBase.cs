using EPiServer;
using EPiServer.Core;
using EPiServer.Filters;
using EPiServer.ServiceLocation;
using EPiServer.Web.Mvc;
using EPiServer.Web.Routing;
using Shangri_La.EpiServer.SL.Web.Business;
using Shangri_La.EpiServer.SL.Web.Models.Blocks;
using Shangri_La.EpiServer.SL.Web.Models.Pages;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;

namespace Shangri_La.EpiServer.SL.Web.Controllers
{
    public abstract class PageControllerBase<T> : PageController<T> where T : SitePageData
    {
        private ContentLocator contentLocator;
        private IContentLoader contentLoader;

        private PageRouteHelper pageRouteHelper;
        private UrlResolver urlResolver;


        #region Property Block Attributes

        private PageData _currentPage;
        private PageReference _currentPageReference;
        private HotelBlock _hotel;

        public PageData CurrentPage
        {
            get { return _currentPage; }
        }

        public PageReference CurrentPageReference
        {
            get { return _currentPageReference; }
        }

        public HotelBlock Hotel
        {
            get { return _hotel; }
        }

        #endregion


        public PageControllerBase(ContentLocator contentLocator, IContentLoader contentLoader)
        {
            this.contentLocator = contentLocator;
            this.contentLoader = contentLoader;

            Initialize();

            _hotel = GetHotelBlock();
        }

        private void Initialize()
        {
            this.pageRouteHelper = ServiceLocator.Current.GetInstance<PageRouteHelper>();
            this.urlResolver = ServiceLocator.Current.GetInstance<UrlResolver>();

            this._currentPageReference = pageRouteHelper.PageLink;
            this._currentPage = this.pageRouteHelper.Page;
        }

        protected HotelBlock GetHotelBlock()
        {
            HotelBlock hotelBlock = null;
            HotelPage hotelPage = null;

            if (_currentPage is HotelPage)
            {
                hotelPage = (HotelPage) this._currentPage;
            }
            else
            {
                //PageData _currentPage = pageRouteHelper.Page;
                hotelPage = (HotelPage)FindHotelPage(_currentPage);
            }

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

        #region  Utils - Find Page

        protected IEnumerable<PageData> FindPages(PageReference root, System.Type type, bool recursive = false)
        {
            PageListBlock PageList = new PageListBlock();

            PageList.PageTypeFilter = type.GetPageType();
            PageList.Recursive = recursive;
            PageList.Root = root;

            IEnumerable<PageData> pages = FindPages(PageList);

            if (pages != null)
            {
                pages = SortPages(pages, PageList.SortOrder);

            }

            return pages;
        }

        protected IEnumerable<PageData> FindPages(PageListBlock currentBlock)
        {
            IEnumerable<PageData> pages;
            PageReference listRoot = currentBlock.Root;

            if (currentBlock.Recursive)
            {
                if (currentBlock.PageTypeFilter != null)
                {
                    pages = contentLocator.FindPagesByPageType(listRoot, true, currentBlock.PageTypeFilter.ID);
                }
                else
                {
                    pages = contentLocator.GetAll<PageData>(listRoot);
                }
            }
            else
            {
                if (currentBlock.PageTypeFilter != null)
                {
                    pages = contentLoader.GetChildren<PageData>(listRoot)
                        .Where(p => p.PageTypeID == currentBlock.PageTypeFilter.ID);
                }
                else
                {
                    pages = contentLoader.GetChildren<PageData>(listRoot);
                }
            }

            if (currentBlock.CategoryFilter != null && currentBlock.CategoryFilter.Any())
            {
                pages = pages.Where(x => x.Category.Intersect(currentBlock.CategoryFilter).Any());
            }
            return pages;
        }

        protected IEnumerable<PageData> SortPages(IEnumerable<PageData> pages, FilterSortOrder sortOrder)
        {
            var asCollection = new PageDataCollection(pages);
            var sortFilter = new FilterSort(sortOrder);
            sortFilter.Sort(asCollection);
            return asCollection;
        }

        #endregion

        // Providing a logout action for all EPiServer Page Controllers
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index");
        }

    }
}