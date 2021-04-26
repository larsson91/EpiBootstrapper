using System.Collections.Generic;
using EPiServer.Cms.Shell.UI.ObjectEditing.EditorDescriptors;
using EPiServer.Shell.ObjectEditing.EditorDescriptors;

namespace EpiBootstrapper.Core.Models.Items
{
    [EditorDescriptorRegistration(
        TargetType = typeof(IList<ListItem>),
        UIHint = "ListItem"
    )]
    public class ListItemDescriptor : CollectionEditorDescriptor<ListItem>
    {

    }
}