using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Shell.ObjectEditing;
using EPiServer.Web;
using Shangri_La.EpiServer.SL.Web.Business.SelectionFactories;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Shangri_La.EpiServer.Common.Models.Blocks;
using Shangri_La.EpiServer.Common.Business;


namespace Shangri_La.EpiServer.SL.Web.Models.Blocks
{
    [ContentType(
        DisplayName = "HotelBlock",
        GroupName = GroupNames.SLDefault,

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
            Order = 10)]
        public virtual string HotelName { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Hotel Short Name",
            Description = "",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual string HotelShortName { get; set; }


        [Required(ErrorMessage = "[Hotel Code] is required.")]
        [Display(
            Name = "Hotel Code",
            Description = "* Required",
            Prompt = "Enter 3 character code",
            GroupName = SystemTabNames.Content,
            Order = 30)]
        public virtual string HotelCode { get; set; }

        [Display(
            Name = "Hotel Code (External)",
            Description = "* Required",
            Prompt = "Enter 3 character code",
            GroupName = SystemTabNames.Content,
            Order = 40)]
        public virtual string HotelCodeExternal { get; set; }

        [Display(
         Name = "Nor1 Hotel Code",
         Description = "Code for Nor1 Room Upgrade",
         GroupName = SystemTabNames.Content,
         Order = 50)]
        public virtual string Nor1HotelCode { get; set; }

        [CultureSpecific]
        [Required(ErrorMessage = "[Hotel Alias] is required.")]
        [Display(
            Name = "Hotel Alias",
            Description = "Hotel Alias (for Old SL Site Mapping)",
            GroupName = SystemTabNames.Content,
            Order = 60)]
        public virtual string HotelAlias { get; set; }

        [Display(
                    Name = "Logo",
                    Description = "Logo",
                    GroupName = SystemTabNames.Content,
                    Order = 70)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference Logo { get; set; }

        [CultureSpecific]
        [Display(
            Name = "ShortWriteup",
            Description = "ShortWriteup",
            GroupName = SystemTabNames.Content,
            Order = 80)]
        public virtual string ShortWriteup { get; set; }



        [Display(
            Name = "City",
             Description = "",
            GroupName = SystemTabNames.Content,
            Order = 90)]
        public virtual ContentReference City { get; set; }


        [Display(
            Name = "PostalCode",
            Description = "",
            GroupName = SystemTabNames.Content,
            Order = 100)]
        public virtual ContentReference PostalCode { get; set; }



        [Display(
            Name = "Latitude",
            Description = "",
            GroupName = SystemTabNames.Content,
            Order = 110)]
        public virtual string Latitude { get; set; }

        [Display(
            Name = "Longitude",
            Description = "",
            GroupName = SystemTabNames.Content,
            Order = 120)]
        public virtual string Longitude { get; set; }

        [Display(
            Name = "Address",
            Description = "",
            GroupName = SystemTabNames.Content,
            Order = 130)]
        public virtual string Address { get; set; }

        [Display(
            Name = "Telephone",
            GroupName = Global.GroupNames.Contact,
            Description = "",
            Order = 140)]
        public virtual string Phone { get; set; }

        [Display(
            Name = "Fax",
            GroupName = Global.GroupNames.Contact,
            Description = "",
            Order = 150)]
        public virtual string Fax { get; set; }

        [Display(
            Name = "Email",
            GroupName = Global.GroupNames.Contact,
            Description = "",
            Order = 160)]
        public virtual string Email { get; set; }


        [Display(Name = "Total Guest Rooms",
            GroupName = SystemTabNames.Content,
            Description = "",
            Order = 170)]
        public virtual int TotalGuestRooms { get; set; }

        [Display(Name = "Check-in Time",
             GroupName = SystemTabNames.Content,
            Description = "",
             Order = 180)]
        public virtual string CheckInTime { get; set; }

        [Display(Name = "Check-out Time",
              GroupName = SystemTabNames.Content,
            Description = "",
             Order = 190)]
        public virtual string CheckOutTime { get; set; }

        [Display(Name = "Payment Modes",
             GroupName = SystemTabNames.Content,
            Description = "",
             Order = 200)]
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

        [Display(Name = "Is Non-Smoking Hotel",
             GroupName = SystemTabNames.Content,
            Description = "",
             Order = 210)]
        public virtual bool IsNonSmokingHotel { get; set; }

        [Display(Name = "IsResort",
             GroupName = SystemTabNames.Content,
            Description = "",
             Order = 220)]
        public virtual bool IsResort { get; set; }

        [Display(Name = "Bookable",
             GroupName = SystemTabNames.Content,
            Description = "",
             Order = 230)]
        public virtual bool Bookable { get; set; }

        [Display(
            Name = "Facebook",
            GroupName = Global.GroupNames.Social,
            Description = "",
            Order = 250)]
        public virtual Url Facebook { get; set; }

        [Display(
            Name = "Twitter",
            GroupName = Global.GroupNames.Social,
            Description = "",
            Order = 260)]
        public virtual Url Twitter { get; set; }

        [Display(
            Name = "Youtube ",
            GroupName = Global.GroupNames.Social,
            Description = "",
            Order = 270)]
        public virtual Url Youtube { get; set; }

        [Display(
            Name = "GooglePlus  ",
            GroupName = Global.GroupNames.Social,
            Description = "",
            Order = 280)]
        public virtual Url GooglePlus { get; set; }

        [Display(
            Name = "Youku",
            GroupName = Global.GroupNames.Social,
            Description = "",
            Order = 290)]
        public virtual Url Youku { get; set; }

        [Display(
            Name = "Weibo",
            GroupName = Global.GroupNames.Social,
            Description = "",
            Order = 300)]
        public virtual Url Weibo { get; set; }

    }
}