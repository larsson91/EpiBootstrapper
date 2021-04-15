using System.Collections.Generic;
using System.Linq;
using EpiBootstrapper.Core.Models.Categories;
using EPiServer.ServiceLocation;
using Geta.EpiCategories;

namespace EpiBootstrapper.Core
{
	public interface ICategoryService
	{
		IEnumerable<BasicCategory> Get(ICategorizableContent content);
	}

	[ServiceConfiguration(ServiceType = typeof(ICategoryService))]
	public class CategoryService : ICategoryService
	{
		private readonly Injected<ICategoryContentLoader> _categoryLoader;


		public IEnumerable<BasicCategory> Get(ICategorizableContent content)
		{
			if (content.Categories == null)
				return new List<BasicCategory>();

			return content.Categories.Select(x => _categoryLoader.Service.Get<BasicCategory>(x));
		}
	}
}
