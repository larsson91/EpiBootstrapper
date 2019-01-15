using System.Web.Mvc;
using Ds.Core.Models.Pages;
using Ds.Core.ViewModels;
using EPiServer.Web.Mvc;

namespace Ds.Controllers
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