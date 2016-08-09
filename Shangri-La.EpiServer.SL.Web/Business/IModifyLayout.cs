using Shangri_La.EpiServer.SL.Web.Models.ViewModels;

namespace Shangri_La.EpiServer.SL.Web.Business
{
    /// <summary>
    /// Defines a method which may be invoked by PageContextActionFilter allowing controllers
    /// to modify common layout properties of the view model.
    /// </summary>
    interface IModifyLayout
    {
        void ModifyLayout(LayoutModel layoutModel);
    }
}
