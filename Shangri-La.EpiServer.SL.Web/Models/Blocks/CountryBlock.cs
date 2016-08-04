using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer;
using Shangri_La.EpiServer.Common.Models.Blocks;
using Shangri_La.EpiServer.Common.Business;

namespace Shangri_La.EpiServer.SL.Web.Models.Blocks
{
    [ContentType(DisplayName = "CountryBlock",
        GUID = "d98876a8-42c3-43af-86e4-418e917012d2",
        GroupName = GroupNames.SLDefault,
        Description = "")]
    public class CountryBlock : SiteBlockData
    {
        [CultureSpecific]
        [Display(
            Name = "Country Name",
            Description = "* Required",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        [Required(ErrorMessage = "Country Name is required.")]
        public virtual string CountryName { get; set; }

        [Display(
            Name = "Country Code",
            Description = "* Required",
            Prompt = "Enter 3 character code",
            GroupName = SystemTabNames.Content,
            Order = 2)]
        [Required(ErrorMessage = "Country Code is required.")]
        public virtual string CountryCode { get; set; }
    }
}