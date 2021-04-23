using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Framework.DataAnnotations;

namespace EpiBootstrapper.Core.Models.Media
{
    [ContentType(DisplayName = "ImageFile", GUID = "e1e45c02-ea10-4a8c-a726-96a79f7f9d89", Description = "")]
    [MediaDescriptor(ExtensionString = "jpg,jpeg,jpe,ico,gif,bmp,png,svg,eps")]
    public class ImageFile : ImageData
    {
        [Display(
            Name = "Alt-attribut text",
            Description = "",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        [CultureSpecific]
        [Editable(true)]
        public virtual string Description { get; set; }

        [Ignore]
        public static ImageFile Empty { get { return new ImageFile(); } }
    }
}
