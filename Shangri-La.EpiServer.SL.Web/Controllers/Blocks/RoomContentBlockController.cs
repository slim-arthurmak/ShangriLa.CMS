using EPiServer;
using EPiServer.Core;
using EPiServer.Filters;
using EPiServer.ServiceLocation;
using EPiServer.Web;
using EPiServer.Web.Mvc;
using EPiServer.Web.Routing;
using Shangri_La.EpiServer.SL.Web.Business;
using Shangri_La.EpiServer.SL.Web.Models.Blocks;
using Shangri_La.EpiServer.SL.Web.Models.Blocks.HotelHomepage;
using Shangri_La.EpiServer.SL.Web.Models.Pages;
using Shangri_La.EpiServer.SL.Web.Models.ViewModels.HotelHomepage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Shangri_La.EpiServer.SL.Web.Controllers.Blocks
{
    public class RoomContentBlockController : BlockController<RoomContentBlock>
    {
        private ContentLocator contentLocator;
        private IContentLoader contentLoader;
        //private readonly PageRouteHelper pageRouteHelper;


        public RoomContentBlockController(ContentLocator contentLocator, IContentLoader contentLoader)
        {
            this.contentLocator = contentLocator;
            this.contentLoader = contentLoader;
        }

        public override ActionResult Index(RoomContentBlock currentBlock)
        {
            RoomContentModel model = new RoomContentModel(currentBlock);

            PageRouteHelper pageRouteHelper = ServiceLocator.Current.GetInstance<PageRouteHelper>();
            UrlResolver urlResolver = ServiceLocator.Current.GetInstance<UrlResolver>();
            PageReference pageReference = pageRouteHelper.PageLink;
            PageData currentPage = pageRouteHelper.Page;

            // Get the edit hint collections
            var editingHints = ViewData.GetEditHints<RoomContentModel, RoomContentBlock>();

            // Adds a connection between 'Heading' in view model and 'MyText' in content data.
            editingHints.AddConnection(m => m.Description, p => p.ShortDescription);

            if (currentPage is HotelPage)
            {
                PageListBlock PageList = new PageListBlock();

                PageList.PageTypeFilter = typeof(RoomGroupListingPage).GetPageType();
                PageList.Recursive = true;
                PageList.Root = pageReference;

                IEnumerable<PageData> pages = FindPages(PageList);

                //pages = Sort(pages, PageList.SortOrder);

                model.RoomGroups = new List<RoomGroupBlock>();
                model.RoomGroupNavigatoins = new List<RoomGroupNavigatoinModel>();

                if (pages != null)
                {
                    foreach (PageData page in pages)
                    {
                        if (page is RoomGroupListingPage)
                        {
                            RoomGroupListingPage listingPage = (RoomGroupListingPage)page;
                            //string url = urlResolver.GetVirtualPath(page).VirtualPath;


                            if (listingPage.RoomGroupBlock != null)
                            {
                                RoomGroupBlock roomGroup = contentLoader.Get<RoomGroupBlock>(listingPage.RoomGroupBlock);
                                model.RoomGroups.Add(roomGroup);

                                model.RoomGroupNavigatoins.Add(
                                    new RoomGroupNavigatoinModel()
                                    {
                                        Title = roomGroup.RoomGroupName,
                                        Description = roomGroup.Teaser,
                                        Url = page.LinkURL
                                    });

                            }
                        }
                    }
                }
            }
            return PartialView(model);
        }

        private IEnumerable<PageData> FindPages(PageListBlock currentBlock)
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

        private IEnumerable<PageData> Sort(IEnumerable<PageData> pages, FilterSortOrder sortOrder)
        {
            var asCollection = new PageDataCollection(pages);
            var sortFilter = new FilterSort(sortOrder);
            sortFilter.Sort(asCollection);
            return asCollection;
        }

    }
}
