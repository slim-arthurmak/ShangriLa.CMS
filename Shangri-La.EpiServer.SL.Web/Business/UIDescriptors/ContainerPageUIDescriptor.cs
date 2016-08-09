using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Shell;
using Shangri_La.EpiServer.SL.Web.Models.Pages;

namespace Shangri_La.EpiServer.SL.Web.Business.UIDescriptors
{
    /// <summary>
    /// Describes how the UI should appear for <see cref="ContainerPage"/> content.
    /// </summary>
    [UIDescriptorRegistration]
    public class ContainerPageUIDescriptor : UIDescriptor<ContainerPage>
    {
        public ContainerPageUIDescriptor()
            : base(ContentTypeCssClassNames.Container)
        {
            DefaultView = CmsViewNames.AllPropertiesView;
        }
    }
}