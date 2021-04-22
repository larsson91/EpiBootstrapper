using System.Web.Mvc;
using EpiBootstrapper.Core.Models.Pages;
using EpiBootstrapper.ViewModels;
using EPiServer.Web.Mvc;

namespace EpiBootstrapper.Controllers
{
    public class NormalPageController : PageController<NormalPage>
    {
        public ActionResult Index(NormalPage currentPage)
        {
            var model = new NormalPageViewModel();
            return View(model);
        }
    }
}