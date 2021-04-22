using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAnnotations;

namespace EpiBootstrapper.Core.Models.Blocks
{
    [ContentType(DisplayName = "Demoblock", GUID = "5B1DB6C1-1AA4-4F7D-BD0D-AA4FD81FD409")]

    public class DemoBlock : BlockData
    {
        [Display(Name = "Text",
            Order = 1000)]
        public virtual string Text { get; set; }
    }
}
