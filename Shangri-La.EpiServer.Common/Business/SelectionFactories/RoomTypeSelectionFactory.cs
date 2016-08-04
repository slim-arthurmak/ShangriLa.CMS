using EPiServer.Shell.ObjectEditing;
using System.Collections.Generic;

namespace Shangri_La.EpiServer.Common.Business.SelectionFactories
{
    public class RoomTypeSelectionFactory : ISelectionFactory
    {
        public IEnumerable<ISelectItem> GetSelections(ExtendedMetadata metadata)
        {
            return new ISelectItem[] {
                new SelectItem() { Text = "Room", Value = "room" },
                new SelectItem() { Text = "Club", Value = "club" },
                new SelectItem() { Text = "Villa", Value = "villa" },
                new SelectItem() { Text = "Suite", Value = "suite" },
                new SelectItem() { Text = "Apartment", Value = "apartment" },
                new SelectItem() { Text = "Residence", Value = "residence" }
            };
        }
    }
}
