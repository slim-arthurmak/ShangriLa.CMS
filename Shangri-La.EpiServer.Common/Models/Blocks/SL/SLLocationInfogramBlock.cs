using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using Shangri_La.EpiServer.Common.Business;
using Shangri_La.EpiServer.Common.Business.SelectionFactories;
using System.ComponentModel.DataAnnotations;
using EPiServer.Shell;
using EPiServer.Shell.ObjectEditing;
using EPiServer.Web;
using System.ComponentModel;



namespace Shangri_La.EpiServer.Common.Models.Blocks.SL
{
    [ContentType(
        DisplayName = "Location Infogram Block",
        GroupName = GroupNames.SLDefault,
        GUID = "11b2997b-ef14-4b91-9cf6-73b945e76183",
        Description = "Used to provide a stylized entry point to a page on the site")]
    public class SLLocationInfogramBlock : BlockData
    {
        [CultureSpecific]
        [Display(
                    Name = "Title",
                    Description = "",
                    GroupName = SystemTabNames.Content,
                    Order = 10)]
        public virtual string Title { get; set; }

        [CultureSpecific]
        [Display(
                    Name = "Direction",
                    Description = "",
                    GroupName = SystemTabNames.Content,
                    Order = 20)]
        public virtual string Direction { get; set; }

        [Display(Name = "Position",
               Description = "Room Type",
               GroupName = SystemTabNames.Content,
               Order = 10)]
        [SelectOne(SelectionFactoryType = typeof(LocationInfogramPointSelectionFactory))]
        public virtual string Position { get; set; }

    }
}