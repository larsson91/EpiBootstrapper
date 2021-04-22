using System.Web.Mvc;
using EpiBootstrapper.Core.Models.Pages;
using EpiBootstrapper.ViewModels;
using EPiServer.Web.Mvc;

namespace EpiBootstrapper.Controllers
{
	public class ArticlePageController : PageController<ArticlePage>
	{
		public ActionResult Index(ArticlePage currentPage)
		{
			var model = new ArticlePageViewModel();
			return View(model);
		}
	}
}