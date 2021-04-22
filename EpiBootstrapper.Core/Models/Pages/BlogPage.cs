using System.ComponentModel.DataAnnotations;
using EpiBootstrapper.Core.Infrastructure;
using EPiServer.Core;
using EPiServer.DataAbstraction;

namespace EpiBootstrapper.Core.Models.Pages
{
    [PageContentType(
        GroupName = "Standardsidor",
        GUID = "E0E651ED-7A68-4BB7-AFEA-63EF0A83C9B8",
        DisplayName = "Blog page",
        Description = "Nice description about the page"
    )]
    [ThumbnailImage(Constants.ContentTypes.Graphics.ImageWithText)]
    public class BlogPage : PageBase
    {
        [Display(
            Name = "Ingress",
            GroupName = SystemTabNames.Content,
            Order = 50
        )]
        public virtual XhtmlString XPreamble { get; set; }

        [Display(
            Name = "Bild",
            GroupName = SystemTabNames.Content,
            Order = 100
        )]
        public virtual ContentReference Image { get; set; }
    }
}
