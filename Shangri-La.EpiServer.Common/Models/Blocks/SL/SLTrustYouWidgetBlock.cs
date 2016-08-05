using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using Shangri_La.EpiServer.Common.Business;
using Shangri_La.EpiServer.Common.Business.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Shangri_La.EpiServer.Common.Models.Blocks.SL
{
    [ContentType(
        DisplayName = "TrustYou Widget Block",
        GroupName = GroupNames.SLDefault,
        GUID = "1818d8ef-15f8-422e-ad53-3b58a9c3f10f",
        Description = "Used to provide a stylized entry point to a page on the site")]
    public class SLTrustYouWidgetBlock : BlockData
    {
        //[CultureSpecific]
        [Display(
                    Name = "TrustYou ID",
                    Description = "",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
        public virtual string TrustYouID { get; set; }

        [CultureSpecific]
        [Display(
                    Name = "Review",
                    Description = "",
                    GroupName = SystemTabNames.Content,
                    Order = 20)]
        [UIHint(UIHint.Textarea)]
        public virtual string Review { get; set; }

        [CultureSpecific]
        [Display(
                    Name = "Reviewer",
                    Description = "",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
        public virtual string Reviewer { get; set; }

        /*
                [CultureSpecific]
                [Display(
                    Name = "Name",
                    Description = "Name field's description",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
                public virtual string Name { get; set; }
         */
        //Sets the default property values
        public override void SetDefaultValues(ContentType contentType)
        {
            TrustYouID = "aa951d42-1c1c-48de-aa67-a98b0a37fcde";
            base.SetDefaultValues(contentType);
            //Set up your defaults here  
        }
    }
}