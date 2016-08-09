using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Shell.ObjectEditing;
using Shangri_La.EpiServer.Common.Business.SelectionFactories;
using System.ComponentModel.DataAnnotations;
using Shangri_La.EpiServer.Common.Business;


namespace Shangri_La.EpiServer.SL.Web.Models.Blocks.RoomListing
{
    [ContentType(DisplayName = "RoomCategroyListBlock", 
        GUID = "b2d5c98f-c974-42e3-b44b-ba1b25a05401", 
        Description = "",  
        GroupName = GroupNames.SLRoomListingPageSections)]
    public class RoomCategroyListBlock : SectionContentBlockData
    {
        /*
                [CultureSpecific]
                [Display(
                    Name = "Name",
                    Description = "Name field's description",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
                public virtual string Name { get; set; }
         */

        [Display(Name = "Room Type",
                Description = "Room Type",
                GroupName = SystemTabNames.Content,
                Order = 10)]
        [SelectOne(SelectionFactoryType = typeof(RoomTypeSelectionFactory))]
        public virtual string RoomType { get; set; }


        public override void SetDefaultValues(ContentType contentType)
        {
            base.SetDefaultValues(contentType);
            //Set up your defaults here  

            RoomType = "suite";
        }
    }
}