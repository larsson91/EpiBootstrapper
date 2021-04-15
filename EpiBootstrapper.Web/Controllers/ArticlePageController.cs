using System.Web.Mvc;
using EpiBootstrapper.Core;
using EpiBootstrapper.Core.Models.Pages;
using EpiBootstrapper.Core.ViewModels;
using EPiServer.ServiceLocation;
using EPiServer.Web.Mvc;

namespace EpiBootstrapper.Controllers
{
	public class ArticlePageController : PageController<ArticlePage>
	{
		private readonly Injected<ICategoryService> _categoryLoader;
		
		public ActionResult Index(ArticlePage currentPage)
		{
			var categories = _categoryLoader.Service.Get(currentPage);

			var model = new ArticlePageViewModel {Categories = categories};
			return View(model);
		}
	}
}