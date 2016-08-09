
using EPiServer.Core;
using Shangri_La.EpiServer.Common.Business;
using Shangri_La.EpiServer.SL.Web.Models.Pages;



namespace Shangri_La.EpiServer.SL.Web.Models.ViewModels
{
    public class DefaultPageViewModel<T> : IPageViewModel<T> where T : SitePageData
    {
        public DefaultPageViewModel(T currentPage)
        {
            CurrentPage = currentPage;
            Section = ContentExtensions.GetSection(currentPage.ContentLink);
        }

        public T CurrentPage { get; private set; }
        public LayoutModel Layout { get; set; }
        public IContent Section { get; set; }

        public ContentReference HeaderLogo { get; set; }

    }
}