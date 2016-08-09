using EPiServer;
using EPiServer.Core;
using EPiServer.ServiceLocation;
using EPiServer.Web.Mvc;
using EPiServer.Web.Routing;

using Shangri_La.EpiServer.SL.Web.Business;
using Shangri_La.EpiServer.SL.Web.Models.Blocks;
using Shangri_La.EpiServer.SL.Web.Models.Blocks.HotelHomepage;
using Shangri_La.EpiServer.SL.Web.Models.Blocks.RoomPage;
using Shangri_La.EpiServer.SL.Web.Models.Pages;
using Shangri_La.EpiServer.SL.Web.Models.ViewModels.HotelHomepage;
using Shangri_La.EpiServer.SL.Web.Models.ViewModels.RoomPage;

using System.Web.Mvc;

namespace Shangri_La.EpiServer.SL.Web.Controllers.Blocks
{
    public class ExploreOtherRoomsListBlockController : BlockController<ExploreOtherRoomsListBlock>
    {
        private ContentLocator contentLocator;
        private IContentLoader contentLoader;
        public ExploreOtherRoomsListBlockController(ContentLocator contentLocator, IContentLoader contentLoader)
        {
            this.contentLocator = contentLocator;
            this.contentLoader = contentLoader;
        }

        public override ActionResult Index(ExploreOtherRoomsListBlock currentBlock)
        {
            ExploreOtherRoomsListViewModel model = new ExploreOtherRoomsListViewModel(currentBlock);

            PageRouteHelper pageRouteHelper = ServiceLocator.Current.GetInstance<PageRouteHelper>();
            UrlResolver urlResolver = ServiceLocator.Current.GetInstance<UrlResolver>();
            PageReference pageReference = pageRouteHelper.PageLink;
            PageData currentPage = pageRouteHelper.Page;

            EditHintCollection<ExploreOtherRoomsListViewModel, ExploreOtherRoomsListBlock> editingHints = ViewData.GetEditHints<ExploreOtherRoomsListViewModel, ExploreOtherRoomsListBlock>();

            // Adds a connection between 'Heading' in view model and 'MyText' in content data.
            //editingHints.AddConnection(m => m.Image, p => p.Image);

            editingHints.AddConnection(m => m.Heading, p => p.Heading);
            editingHints.AddConnection(m => m.IntroText, p => p.IntroText);
            editingHints.AddConnection(m => m.FeatureRoomsContentArea, p => p.FeatureRoomsContentArea);
            /*
            editingHints.AddConnection(m => m.MainText, p => p.MainText);
            editingHints.AddConnection(m => m.Highlights, p => p.Highlights);

            editingHints.AddConnection(m => m.BlockCTA, p => p.BlockCTA);
            editingHints.AddConnection(m => m.BlockButtonLink, p => p.BlockButtonLink);
            */
            /*
            if (currentPage is HotelPage)
            {
                PageListBlock PageList = new PageListBlock();

                PageList.PageTypeFilter = typeof(RoomSuiteListingPage).GetPageType();
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
                       if (page is RoomSuiteListingPage)
                       {
                           RoomSuiteListingPage listingPage = (RoomSuiteListingPage)page;
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
            */

            return PartialView(model);
        }
        /*
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
        */
    }
}
