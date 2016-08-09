using EPiServer.Shell.ObjectEditing;
using System.Collections.Generic;

namespace Shangri_La.EpiServer.Common.Business.SelectionFactories
{
    public class PaymentModeSelectionFactory : ISelectionFactory
    {
        public IEnumerable<ISelectItem> GetSelections(ExtendedMetadata metadata)
        {
            return new ISelectItem[] {
                new SelectItem() { Text = "American Express", Value = "AX" },
                new SelectItem() { Text = "Diners Club", Value = "DC" },
                new SelectItem() { Text = "JCB Card", Value = "JC" },
                new SelectItem() { Text = "MasterCard", Value = "MC" },
                new SelectItem() { Text = "Visa", Value = "VA" },
                new SelectItem() { Text = "Alipay", Value = "AP" },
                new SelectItem() { Text = "China UnionPay", Value = "UP" },
                new SelectItem() { Text = "Tenpay", Value = "TP" },
            };
        }
    }
}