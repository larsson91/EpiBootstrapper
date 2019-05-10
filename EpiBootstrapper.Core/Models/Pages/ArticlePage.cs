using System.Collections.Generic;
using  EpiBootstrapper.Core.Infrastructure;
using EPiServer.Core;
using Geta.EpiCategories;
using Geta.EpiCategories.DataAnnotations;

namespace  EpiBootstrapper.Core.Models.Pages
{
	[PageContentType(
		GroupName = "För administratörer",
		GUID = "D5538523-0081-3D0C-AED7-F6818F4047C7",
		DisplayName = "Article page",
		Description = ""
	)]
	[ThumbnailImage(Constants.ContentTypes.Graphics.House)]
	public class ArticlePage : PageBase, ICategorizableContent
	{
		[Categories]
		public virtual IList<ContentReference> Categories { get; set; }
	}
}
