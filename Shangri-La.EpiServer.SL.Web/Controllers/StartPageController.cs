using EPiServer;
using Shangri_La.EpiServer.SL.Web.Business;
using Shangri_La.EpiServer.SL.Web.Models.Pages;
using Shangri_La.EpiServer.SL.Web.Models.ViewModels;
using System.Web.Mvc;


namespace Shangri_La.EpiServer.SL.Web.Controllers
{
    public class StartPageController : PageControllerBase<StartPage>
    {
        private ContentLocator contentLocator;
        private IContentLoader contentLoader;
        public StartPageController(ContentLocator contentLocator, IContentLoader contentLoader) : base(contentLocator, contentLoader)
        {
            this.contentLocator = contentLocator;
            this.contentLoader = contentLoader;
        }

        public ActionResult Index(StartPage currentPage)
        {
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */
            DefaultPageViewModel<StartPage> model = new DefaultPageViewModel<StartPage>(currentPage);
            return View(model);
        }
    }
}