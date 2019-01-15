using Ds.Core.Models.Pages;
using EPiServer.ServiceLocation;
using EPiServer.Web.Routing;

namespace Ds.Core.ViewModels
{
	public abstract class PageViewModelBase<TModel> where TModel : class
	{
		private readonly IPageRouteHelper _pageRouteHelper;

		protected PageViewModelBase()
		{
			_pageRouteHelper = ServiceLocator.Current.GetInstance<IPageRouteHelper>();
			Layout = new LayoutViewModel();
			var currentPage = (CurrentPage as PageBase);
			Layout.PageTitle = currentPage == null ? "Danderyds sjukhus" : currentPage.Header + " - Danderyds sjukhus";
		}

		public TModel CurrentPage => _pageRouteHelper.Page as TModel;

		public LayoutViewModel Layout { get; set; }
	}
}
