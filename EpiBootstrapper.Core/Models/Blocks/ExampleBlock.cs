using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAnnotations;

namespace EpiBootstrapper.Core.Models.Blocks
{
    [ContentType(DisplayName = "Exempelblock", GUID = "5B1DB6C1-1AA4-4F7D-BD0D-AA4FD81FD407", Description = "Ett block att se på som exempel")]
    public class ExampleBlock : BlockData
    {
        [Display(Name = "Rubrik",
            Description = "Blockets rubrik",
            Order = 1000)]
        public virtual string Heading { get; set; }
    }
}
