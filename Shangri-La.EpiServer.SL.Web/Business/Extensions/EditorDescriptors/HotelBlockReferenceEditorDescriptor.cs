using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using EPiServer.Core;
using EPiServer.Shell.ObjectEditing.EditorDescriptors;

using Shangri_La.EpiServer.SL.Web.Models.Blocks;

namespace Shangri_La.EpiServer.SL.Web.Business.Extensions.EditorDescriptor
{
    [EditorDescriptorRegistration(TargetType = typeof(ContentReference), UIHint = "hotelblock")]
    public class HotelBlockReferenceEditorDescriptor : ContentReferenceEditorDescriptor<HotelBlock>
    {
        public override IEnumerable<ContentReference> Roots
        {
            get
            {
                return new ContentReference[] { new ContentReference(1015) };
            }
        }
    }
}