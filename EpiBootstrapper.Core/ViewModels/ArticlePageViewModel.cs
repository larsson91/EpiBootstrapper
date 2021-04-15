using System.Collections.Generic;
using EpiBootstrapper.Core.Models.Categories;
using EpiBootstrapper.Core.Models.Pages;

namespace EpiBootstrapper.Core.ViewModels
{
	public class ArticlePageViewModel : PageViewModelBase<ArticlePage>
	{
		public IEnumerable<BasicCategory> Categories { get; set; }
	}
}
