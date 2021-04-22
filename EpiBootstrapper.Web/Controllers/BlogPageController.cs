using System.Web.Mvc;
using EpiBootstrapper.Core.Models.Pages;
using EpiBootstrapper.ViewModels;
using EPiServer.Web.Mvc;

namespace EpiBootstrapper.Controllers
{
    public class BlogPageController : PageController<BlogPage>
    {
        public ActionResult Index(BlogPage currentPage)
        {
            var model = new BlogPageViewModel();
            return View(model);
        }
    }
}