using System.Collections.Generic;
using EpiBootstrapper.Core.Models.Pages;

namespace EpiBootstrapper.ViewModels
{
	public class ArticleListingPageViewModel : PageViewModelBase<ArticleListingPage>
	{
        public List<ArticlePage> Children { get; set; }
    }
}
