using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.PlugIn;

namespace EpiBootstrapper.Core.Models.Items
{
    [EditorHint("ListItem")]
    [PropertyDefinitionTypePlugIn(GUID = "5B1DB6C1-1AA4-4F7D-BD0D-AA4FD81FD817")]
    public class ListItemProperty : PropertyList<ListItem> 
    {

    }
}