using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace Shangri_La.EpiServer.Common.Models.Blocks.SL
{
    [ContentType(DisplayName = "Experience Teaser Block", GUID = "1f213b26-3088-4526-ba6c-8bdb25916d61", Description = "")]
    public class SLExperienceTeaserBlock : SLTeaserBlock

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
    }
}