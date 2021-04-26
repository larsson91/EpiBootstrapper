using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using  EpiBootstrapper.Core.Infrastructure;
using EPiServer.Core;

namespace  EpiBootstrapper.Core.Models.Pages
{
	[PageContentType(
		GroupName = "Standardsidor",
		GUID = "D5538523-0081-3D0C-AED7-F6818F4147C7",
		DisplayName = "Article listing page",
		Description = ""
	)]
	[ThumbnailImage(Constants.ContentTypes.Graphics.ImageWithText)]
	public class ArticleListingPage : PageBase
	{

	}
}
