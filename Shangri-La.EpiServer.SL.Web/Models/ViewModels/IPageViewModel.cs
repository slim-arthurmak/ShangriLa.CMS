using EPiServer.Core;
using Shangri_La.EpiServer.SL.Web.Models.Pages;

namespace Shangri_La.EpiServer.SL.Web.Models.ViewModels
{
    public interface IPageViewModel<out T> where T : SitePageData
    {
        T CurrentPage { get; }
        LayoutModel Layout { get; set; }
        IContent Section { get; set; }
    }
}