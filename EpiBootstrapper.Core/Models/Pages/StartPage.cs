using  EpiBootstrapper.Core.Infrastructure;
using EPiServer.Core;

namespace  EpiBootstrapper.Core.Models.Pages
{
	[PageContentType(
		GroupName = "För administratörer",
		GUID = "D5538523-0081-4E0C-AED7-F6818F4047C7",
		DisplayName = "Start page",
		Description = "The main start page of the website."
	)]
	[ThumbnailImage(Constants.ContentTypes.Graphics.House)]
	public class StartPage : PageBase
	{
		public virtual ContentArea ContentArea { get; set; }
		
		public virtual ContentReference ImageFile { get; set; }
	}
	
	//<img src="@Url.ContentUrl(Model.CurrentPage.Image)"/>bat
}
