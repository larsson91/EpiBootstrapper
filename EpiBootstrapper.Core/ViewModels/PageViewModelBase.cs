using  EpiBootstrapper.Core.Models.Pages;
using EPiServer.ServiceLocation;
using EPiServer.Web.Routing;

namespace EpiBootstrapper.Core.ViewModels
{
	public abstract class PageViewModelBase<TModel> where TModel : class
	{
		private readonly IPageRouteHelper _pageRouteHelper;

		protected PageViewModelBase()
		{
			_pageRouteHelper = ServiceLocator.Current.GetInstance<IPageRouteHelper>();
			Layout = new LayoutViewModel();
			var currentPage = (CurrentPage as PageBase);
			Layout.PageTitle = currentPage == null ? "Epi Bootstrapper" : currentPage.Header + " - Epi Bootstrapper";
		}

		public TModel CurrentPage => _pageRouteHelper.Page as TModel;

		public LayoutViewModel Layout { get; set; }
	}
}
