using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPiServer.DataAnnotations;

namespace  EpiBootstrapper.Core.Infrastructure
{
	public class PageContentTypeAttribute : ContentTypeAttribute
	{
		public PageContentTypeAttribute()
		{
			GroupName = Constants.ContentTypes.Groups.DefaultPage;
		}
	}
}
