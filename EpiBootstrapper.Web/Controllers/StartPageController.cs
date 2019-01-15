using System.Web.Mvc;
using EpiBootstrapper.Core.Models.Pages;
using  EpiBootstrapper.Core.ViewModels;
using EPiServer.Web.Mvc;

namespace EpiBootstrapper.Controllers
{
	public class StartPageController : PageController<StartPage>
	{
		public ActionResult Index(StartPage currentPage)
		{
			var model = new StartPageViewModel();
			return View(model);
		}
	}
}