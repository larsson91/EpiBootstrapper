using EPiServer.Core;

namespace EpiBootstrapper.Core.Models.Items
{
    public class ListItem 
    {
        public string Name { get; set; }

        public string Description { get; set; }
        
        public ContentReference Image { get; set; }
    }
}