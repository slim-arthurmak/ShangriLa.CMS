using System;
using System.Collections.Generic;
using EPiServer.Shell.ObjectEditing.EditorDescriptors;
using EPiServer.Shell.ObjectEditing;

using Shangri_La.EpiServer.SL.Web;

namespace AllShangri_La.EpiServer.SL.Web.Business.EditorDescriptors
{
    /// <summary>
    /// Register an editor for StringList properties
    /// </summary>
    [EditorDescriptorRegistration(TargetType = typeof(String[]), UIHint = Global.SiteUIHints.Strings)]
    public class StringListEditorDescriptor : EditorDescriptor
    {
        public override void ModifyMetadata(ExtendedMetadata metadata, IEnumerable<Attribute> attributes)
        {
            ClientEditingClass = "shangrila/editors/StringList";

            base.ModifyMetadata(metadata, attributes);
        }
    }
}
