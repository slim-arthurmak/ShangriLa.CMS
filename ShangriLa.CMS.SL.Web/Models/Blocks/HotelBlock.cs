using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Shell.ObjectEditing;
using ShangriLa.CMS.SL.Web.Business.SelectionFactories;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Collections.Generic;



namespace ShangriLa.CMS.SL.Web.Models.Blocks
{
    [ContentType(
        DisplayName = "HotelBlock",
        GroupName = Global.GroupNames.SLDefault,

        GUID = "4707c0e7-87b0-4f3b-b18e-b57bfdea2815",
        Description = "")]
    public class HotelBlock : SiteBlockData
    {
        [CultureSpecific]
        [Required(ErrorMessage = "[Hotel Name] is required.")]
        [Display(
            Name = "Hotel Full Name",
            Description = "* Required",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string HotelName { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Hotel Short Name",
            Description = "",
            GroupName = SystemTabNames.Content,
            Order = 2)]
        public virtual string HotelShortName { get; set; }


        [Required(ErrorMessage = "[Hotel Code] is required.")]
        [Display(
            Name = "Hotel Code",
            Description = "* Required",
            Prompt = "Enter 3 character code",
            GroupName = SystemTabNames.Content,
            Order = 3)]
        public virtual string HotelCode { get; set; }

        [Display(
            Name = "Hotel Code (External)",
            Description = "* Required",
            Prompt = "Enter 3 character code",
            GroupName = SystemTabNames.Content,
            Order = 4)]
        public virtual string HotelCodeExternal { get; set; }

        [CultureSpecific]
        [Required(ErrorMessage = "[Hotel Alias] is required.")]
        [Display(
            Name = "Hotel Alias",
            Description = "Hotel Alias (for Old SL Site Mapping)",
            GroupName = SystemTabNames.Content,
            Order = 5)]
        public virtual string HotelAlias { get; set; }

        [Display(
            Name = "City",
            Order = 10)]
        public virtual ContentReference City { get; set; }


        [Display(
            Name = "PostalCode",
            Order = 11)]
        public virtual ContentReference PostalCode { get; set; }



        [Display(
            Name = "Latitude",
            Order = 12)]
        public virtual string Latitude { get; set; }

        [Display(
            Name = "Longitude",
            Order = 13)]
        public virtual string Longitude { get; set; }

        [Display(
            Name = "Address",
            Order = 14)]
        public virtual string Address { get; set; }

        [Display(
            Name = "Telephone",
            GroupName = Global.GroupNames.Contact, 
            Description = "",
            Order = 1)]
        public virtual string Phone { get; set; }

        [Display(
            Name = "Fax",
            GroupName = Global.GroupNames.Contact, 
            Description = "",
            Order = 2)]
        public virtual string Fax { get; set; }

        [Display(
            Name = "Email",
            GroupName = Global.GroupNames.Contact,
            Description = "",
            Order = 3)]
        public virtual string Email { get; set; }


        [Display(Name = "Total Guest Rooms", Order = 21)]
        public virtual int TotalGuestRooms { get; set; }

        [Display(Name = "Check-in Time", Order = 22)]
        public virtual string CheckInTime { get; set; }

        [Display(Name = "Check-out Time", Order = 22)]
        public virtual string CheckOutTime { get; set; }

        [Display(Name = "Payment Modes", Order = 23)]
        [SelectMany(SelectionFactoryType = typeof(PaymentModeSelectionFactory))]
        public virtual string PaymentModes { get; set; }

        public virtual List<string> PaymentModeList
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(this.PaymentModes))
                {
                    return new List<string>(this.PaymentModes.Split(",".ToCharArray()));
                }
                else
                {
                    return new List<string>();
                }
            }
        }

        [Display(Name = "Is Non-Smoking Hotel", Order = 31)]
        public virtual bool IsNonSmokingHotel { get; set; }

        [Display(Name = "IsResort", Order = 32)]
        public virtual bool IsResort { get; set; }

        [Display(Name = "Bookable", Order = 33)]
        public virtual bool Bookable { get; set; }

        [Display(
            Name = "Facebook",
            GroupName = Global.GroupNames.Social,
            Description = "",
            Order = 1)]
        public virtual Url Facebook { get; set; }

        [Display(
            Name = "Twitter",
            GroupName = Global.GroupNames.Social,
            Description = "",
            Order = 2)]
        public virtual Url Twitter { get; set; }

        [Display(
            Name = "Youtube ",
            GroupName = Global.GroupNames.Social,
            Description = "",
            Order = 3)]
        public virtual Url Youtube { get; set; }

        [Display(
            Name = "GooglePlus  ",
            GroupName = Global.GroupNames.Social,
            Description = "",
            Order = 4)]
        public virtual Url GooglePlus { get; set; }

        [Display(
            Name = "Youku",
            GroupName = Global.GroupNames.Social,
            Description = "",
            Order = 5)]
        public virtual Url Youku { get; set; }

        [Display(
            Name = "Weibo",
            GroupName = Global.GroupNames.Social,
            Description = "",
            Order = 5)]
        public virtual Url Weibo { get; set; }

    }
}