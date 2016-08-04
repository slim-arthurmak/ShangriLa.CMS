using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Shell.ObjectEditing;
using EPiServer.Web;
using Shangri_La.EpiServer.SL.Web.Business.SelectionFactories;
using Shangri_La.EpiServer.SL.Web.Models.Properties;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Shangri_La.EpiServer.Common.Models.Blocks;
using Shangri_La.EpiServer.Common.Business;



namespace Shangri_La.EpiServer.SL.Web.Models.Blocks
{
    [ContentType(DisplayName = "RoomSuiteBlock",
         GUID = "275712a5-21d6-4ef4-884e-cdbeb2b04250",
        GroupName = GroupNames.SLDefault,
        Description = "")]
    public class RoomSuiteBlock : SiteBlockData
    {
        [CultureSpecific]
        [Display(
                    Name = "Room Name",
                    Description = "Room Name",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
        public virtual string RoomName { get; set; }

        [Display(Name = "Room Type",
                Description = "Room Type",
                GroupName = SystemTabNames.Content,
                Order = 2)]
        [SelectOne(SelectionFactoryType = typeof(RoomTypeSelectionFactory))]
        public virtual string RoomType { get; set; }


        [Display(Name = "Room Type Code",
            Description = "Room Type Code",
            GroupName = SystemTabNames.Content,
            Order = 3)]
        public virtual string RoomTypeCode { get; set; }

        //[Required]

        [BackingType(typeof(PropertyStringList))]
        [Display(Name = "Room Features",
                Description = "Place items on separate lines",
                GroupName = SystemTabNames.Content,
                Order = 4)]
        [UIHint(SiteUIHints.Strings)]
        [CultureSpecific]
        public virtual string[] RoomFeatures { get; set; }

        [BackingType(typeof(PropertyStringList))]
        [Display(Name = "Room Amenities (Media & Entertainment)",
                 Description = "Room Amenities (Media & Entertainment)",
                 GroupName = SystemTabNames.Content,
                 Order = 21)]
        [UIHint(SiteUIHints.Strings)]
        [CultureSpecific]
        public virtual string[] AmenitiesMediaEntertainment { get; set; }

        [BackingType(typeof(PropertyStringList))]
        [Display(Name = "Room Amenities (Refreshments)",
                 Description = "Room Amenities (Media & Entertainment)",
                 GroupName = SystemTabNames.Content,
                 Order = 22)]
        [UIHint(SiteUIHints.Strings)]
        [CultureSpecific]
        public virtual string[] AmenitiesRefreshments { get; set; }


        [BackingType(typeof(PropertyStringList))]
        [Display(Name = "Room Amenities (Office Equipment & Stationary)",
                 Description = "Room Amenities (Office Equipment & Stationary)",
                 GroupName = SystemTabNames.Content,
                 Order = 23)]
        [UIHint(SiteUIHints.Strings)]
        [CultureSpecific]
        public virtual string[] AmenitiesOfficeEquipmentStationary { get; set; }

        [BackingType(typeof(PropertyStringList))]
        [Display(Name = "Room Amenities (Bath & Personal Care)",
                 Description = "Room Amenities (Bath & Personal Care)",
                 GroupName = SystemTabNames.Content,
                 Order = 24)]
        [UIHint(SiteUIHints.Strings)]
        [CultureSpecific]
        public virtual string[] AmenitiesBathPersonalCare { get; set; }

        [Display(Name = "Room Size",
           Description = "Room Size",
           GroupName = SystemTabNames.Content,
           Order = 25)]
        public virtual string RoomSize { get; set; }

        [Display(Name = "Room View",
           Description = "Room View",
           GroupName = SystemTabNames.Content,
           Order = 26)]
        public virtual string RoomView { get; set; }


        [Display(Name = "Bookable", Order = 31)]
        public virtual bool Bookable { get; set; }

        [Display(Name = "Is Featured", Order = 100)]
        public virtual bool IsFeatured { get; set; }

        [Display(Name = "Max Occupancy", Order = 110)]
        [Range(1, 5)]
        [DefaultValue(3)]
        public virtual int MaxOccupancy { get; set; }


        public override void SetDefaultValues(ContentType contentType)
        {
            base.SetDefaultValues(contentType);

            RoomType = "room";
            IsFeatured = false;
            MaxOccupancy = 3;
        }
    }
}