using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace Shangri_La.EpiServer.SL.Web.Models.Blocks.RoomListing
{
    [ContentType(DisplayName = "HorizonClubListBlock", GUID = "b12640d0-0598-42b5-85cb-ad9dc2cc32d6",
        Description = "",
        GroupName = Global.GroupNames.SLRoomListingPageSections)]
    public class HorizonClubListBlock : RoomCategroyListBlock
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

            RoomType = "club";
        }
    }
}