using System.ComponentModel.DataAnnotations;
using EpiBootstrapper.Core.Infrastructure;
using EPiServer.Core;
using EPiServer.DataAnnotations;

namespace EpiBootstrapper.Core.Models.Pages
{
    [PageContentType(
        GroupName = "Standardsidor",
        GUID = "6A33639C-9765-4A39-8764-C43B52BD7F7F",
        DisplayName = "Normal page",
        Description = ""
    )]
    [ThumbnailImage(Constants.ContentTypes.Graphics.ImageWithText)]
	public class NormalPage : PageBase
    {
        [Display(Name = "Blockyta",
            Description = "Sidans blockyta. Dra in eller skapa block och ange visningsalternativ (Display setting) för att kontrollera blockets bredd.",
            Order = 1000)]
        public virtual ContentArea ContentArea { get; set; }
    }
}
