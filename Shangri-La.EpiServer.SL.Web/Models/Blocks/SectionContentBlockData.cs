using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using System.ComponentModel.DataAnnotations;

using Shangri_La.EpiServer.SL.Web;


namespace Shangri_La.EpiServer.SL.Web.Models.Blocks
{
    [ContentType(DisplayName = "SectionContentBlockData", 
        GUID = "b3a417fe-3337-4687-ac99-069d46d0832a", 
        Description = "",
        GroupName = Global.GroupNames.SLDefault)]
    public class SectionContentBlockData : BlockData
    {
        [CultureSpecific]
        [Display(
            Name = "Title",
            Description = "Title",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Title { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Short Description",
            Description = "Short Description",
            GroupName = SystemTabNames.Content,
            Order = 2)]
        [UIHint(UIHint.Textarea)]
        public virtual string ShortDescription { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Long Description",
            Description = "Long Description",
            GroupName = SystemTabNames.Content,
            Order = 3)]
        [UIHint(UIHint.Textarea)]
        public virtual string LongDescription { get; set; }

        [Display(
            Name = "Block CTA",
            Description = "Block CTA",
            GroupName = SystemTabNames.Content,
            Order = 4)]
        public virtual ButtonBlock BlockCTA { get; set; }
    }
}