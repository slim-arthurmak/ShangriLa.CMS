using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using Shangri_La.EpiServer.SL.Web.Business.Rendering;
using Shangri_La.EpiServer.Common.Business.Attributes;

namespace Shangri_La.EpiServer.SL.Web.Models.Pages
{
    [ContentType(DisplayName = "Container",
       GUID = "556a8ecd-7def-4e2d-8be1-997b362c1f5e",
       GroupName = Global.GroupNames.Specialized,
       Description = "Container page for structuring content")]
    [ContentImage("Default.png")]
    public class ContainerPage : PageData, IContainerPage
    {
    }
}