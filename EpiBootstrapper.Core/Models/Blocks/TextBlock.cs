using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAnnotations;

namespace EpiBootstrapper.Core.Models.Blocks
{
    [ContentType(DisplayName = "Textblock", GUID = "5B1DB6C1-1AA4-4F7D-BD0D-AA4FD81FD401")]

    public class TextBlock : BlockData
    {
        [Display(Name = "TextBox",
            Order = 1000)]
        public virtual XhtmlString Text { get; set; }
    }
}