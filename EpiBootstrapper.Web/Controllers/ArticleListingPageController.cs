using System.Linq;
using System.Web.Mvc;
using EpiBootstrapper.Core.Models.Pages;
using EpiBootstrapper.ViewModels;
using EPiServer;
using EPiServer.Web.Mvc;

namespace EpiBootstrapper.Controllers
{
	public class ArticleListingPageController : PageController<ArticleListingPage>
	{
        private IContentLoader _contentLoader { get; set; }

        public ArticleListingPageController(IContentLoader contentLoader)
        {
            _contentLoader = contentLoader;
        }

		public ActionResult Index(ArticleListingPage currentPage)
		{
			var model = new ArticleListingPageViewModel()
            {
				Children = _contentLoader.GetChildren<ArticlePage>(currentPage.ContentLink).ToList()
			};
			return View(model);
		}
	}
}