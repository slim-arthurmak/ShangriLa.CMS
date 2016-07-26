using EPiServer;
using Shangri_La.EpiServer.SL.Web.Business;
using Shangri_La.EpiServer.SL.Web.Models.Blocks;
using Shangri_La.EpiServer.SL.Web.Models.Pages;
using Shangri_La.EpiServer.SL.Web.Models.ViewModels;
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

            return View(model);
        }
    }
}