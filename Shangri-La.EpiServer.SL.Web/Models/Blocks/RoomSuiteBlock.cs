using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using Shangri_La.EpiServer.SL.Web.Business.SelectionFactories;
using EPiServer.Shell.ObjectEditing;
using System.Collections.Generic;

using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using Shangri_La.EpiServer.SL.Web.Models.Blocks;
using System.ComponentModel.DataAnnotations;

using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Collections.Generic;

using Shangri_La.EpiServer.SL.Web.Models.Properties;

namespace Shangri_La.EpiServer.SL.Web.Models.Blocks
{
    [ContentType(DisplayName = "RoomSuiteBlock",
        GroupName = Global.GroupNames.SLDefault,
         GUID = "275712a5-21d6-4ef4-884e-cdbeb2b04250", Description = "")]
    public class RoomSuiteBlock : SiteBlockData
    {
        [CultureSpecific]
        [Display(
                    Name = "Room Name",
                    Description = "Room Name",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
        public virtual string RoomName { get; set; }

        [Display(Name = "Room Type", Order = 2)]
        [SelectOne(SelectionFactoryType = typeof(RoomTypeSelectionFactory))]
        public virtual string RoomType { get; set; }

        [BackingType(typeof(PropertyStringList))]
        [Display(Name = "Room Amenities (Media & Entertainment)",
                 Description = "Room Amenities (Media & Entertainment)",
                 GroupName = SystemTabNames.Content,
                 Order = 21)]
        [UIHint(Global.SiteUIHints.Strings)]
        [CultureSpecific]
        public virtual string[] AmenitiesMediaEntertainment { get; set; }

        [BackingType(typeof(PropertyStringList))]
        [Display(Name = "Room Amenities (Refreshments)",
                 Description = "Room Amenities (Media & Entertainment)",
                 GroupName = SystemTabNames.Content,
                 Order = 22)]
        [UIHint(Global.SiteUIHints.Strings)]
        [CultureSpecific]
        public virtual string[] AmenitiesRefreshments { get; set; }


        [BackingType(typeof(PropertyStringList))]
        [Display(Name = "Room Amenities (Office Equipment & Stationary)",
                 Description = "Room Amenities (Office Equipment & Stationary)",
                 GroupName = SystemTabNames.Content,
                 Order = 23)]
        [UIHint(Global.SiteUIHints.Strings)]
        [CultureSpecific]
        public virtual string[] AmenitiesOfficeEquipmentStationary { get; set; }


        [BackingType(typeof(PropertyStringList))]
        [Display(Name = "Room Amenities (Bath & Personal Care)",
                 Description = "Room Amenities (Bath & Personal Care)",
                 GroupName = SystemTabNames.Content,
                 Order = 24)]
        [UIHint(Global.SiteUIHints.Strings)]
        [CultureSpecific]
        public virtual string[] AmenitiesBathPersonalCare { get; set; }


        [Display(Name = "Bookable", Order = 31)]
        public virtual bool Bookable { get; set; }


        public override void SetDefaultValues(ContentType contentType)
        {
            base.SetDefaultValues(contentType);

            RoomType = "room";
        }
    }
}