using EPiServer.Core;
using EPiServer.ServiceLocation;
using EPiServer.Shell.ObjectEditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Shangri_La.EpiServer.SL.Web.Models.Blocks;

namespace Shangri_La.EpiServer.SL.Web.Business.Extensions.EditorDescriptors
{
    /// <summary>
    /// Provides a list of options corresponding to ContactPage pages on the site
    /// </summary>
    /// <seealso cref="CountryBlock"/>
    public class CountryBlockSelectionFactory : ISelectionFactory
    {
        private Injected<ContentLocator> ContentLocator { get; set; }

        public IEnumerable<ISelectItem> GetSelections(ExtendedMetadata metadata)
        {
            var countryBlocks = ContentLocator.Service.GetCountryBlocks();

            return new List<SelectItem>(countryBlocks.Select(c => new SelectItem { Value = ((IContent)c).ContentLink, Text = c.CountryName }));
        }
    }
}