using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using Shangri_La.EpiServer.Common.Business;


namespace Shangri_La.EpiServer.SL.Web.Models.Blocks
{
    [ContentType(DisplayName = "SectionHightlightBlock", 
        GUID = "fe72c3cd-7e0c-42b2-b806-27bcd1733c27", 
        GroupName = GroupNames.SLDefault, 
        Description = "")]
    public class SectionHightlightContentBlock : SectionContentBlockData
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