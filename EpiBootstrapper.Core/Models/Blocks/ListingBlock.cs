using System.Collections.Generic;
using EpiBootstrapper.Core.Models.Items;
using EPiServer.Cms.Shell.UI.ObjectEditing.EditorDescriptors;
using EPiServer.Core;
using EPiServer.DataAnnotations;
using EPiServer.Shell.ObjectEditing;

namespace EpiBootstrapper.Core.Models.Blocks
{
    [ContentType(DisplayName = "Listingblock", GUID = "5B1DB6C1-1AA4-4F7D-BD0D-AA4FD81FD411",
        Description = "Ett block att se på som exempel")]
    public class ListingBlock : BlockData
    {
        public virtual string Name { get; set; }

        [EditorDescriptor(EditorDescriptorType = typeof(CollectionEditorDescriptor<ListItem>))]
        public virtual IList<ListItem> Items { get; set; }
    }
}