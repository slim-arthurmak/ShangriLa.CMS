using EPiServer.Shell.ObjectEditing;
using System.Collections.Generic;

namespace Shangri_La.EpiServer.Common.Business.SelectionFactories
{
    public class LocationInfogramPointSelectionFactory : ISelectionFactory
    {
        public IEnumerable<ISelectItem> GetSelections(ExtendedMetadata metadata)
        {
            return new ISelectItem[] {
                new SelectItem() { Text = "Origin", Value = "origin" },
                new SelectItem() { Text = "10%", Value = "percent-10" },
                new SelectItem() { Text = "20%", Value = "percent-20" },
                new SelectItem() { Text = "30%", Value = "percent-30" },
                new SelectItem() { Text = "40%", Value = "percent-40" },
                new SelectItem() { Text = "50%", Value = "percent-50" },
                new SelectItem() { Text = "60%", Value = "percent-60" },
                new SelectItem() { Text = "70%", Value = "percent-70" },
                new SelectItem() { Text = "80%", Value = "percent-80" },
                new SelectItem() { Text = "90%", Value = "percent-90" },
                new SelectItem() { Text = "Destination", Value = "destination" }
            };
        }
    }
}
