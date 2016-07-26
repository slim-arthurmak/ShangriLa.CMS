using EPiServer;
using ShangriLa.CMS.SL.Web.Business;
using ShangriLa.CMS.SL.Web.Models.Blocks;
using ShangriLa.CMS.SL.Web.Models.Pages;
using ShangriLa.CMS.SL.Web.Models.ViewModels;
using System.Web.Mvc;

namespace ShangriLa.CMS.SL.Web.Controllers.Pages
{
    public class RoomSuitePageController : PageControllerBase<RoomSuitePage>
    {
        private ContentLocator contentLocator;
        private IContentLoader contentLoader;
        public RoomSuitePageController(ContentLocator contentLocator, IContentLoader contentLoader)
        {
            this.contentLocator = contentLocator;
            this.contentLoader = contentLoader;
        }

        public ActionResult Index(RoomSuitePage currentPage)
        {
            RoomSuitePageViewModel model = new RoomSuitePageViewModel(currentPage);
            model.RoomSuiteBlock = contentLoader.Get<RoomSuiteBlock>(currentPage.RoomSuiteBlock);

            return View(model);
        }
    }
}