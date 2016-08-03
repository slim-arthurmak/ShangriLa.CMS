using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace Shangri_La.EpiServer.SL.Web.Models.Blocks.RoomListing
{
    [ContentType(DisplayName = "SuiteListBlock", GUID = "2c2a0b47-dda3-493b-bb82-2d56ca028ee6",
        Description = "",
        GroupName = Global.GroupNames.SLRoomListingPageSections)]
    public class SuiteListBlock : RoomCategroyListBlock
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

        public override void SetDefaultValues(ContentType contentType)
        {
            base.SetDefaultValues(contentType);
            //Set up your defaults here  

            RoomType = "room";
        }
    }
}