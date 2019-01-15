using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace  EpiBootstrapper.Core.Models.Pages
{
	public abstract class PageBase : PageData
	{
		[Display(
			Name = "Rubrik",
			Description = "Rubrik för sidan. Om det inte sätts kommer sidans namn att användas.",
			GroupName = SystemTabNames.Content,
			Order = 10
		)]
		[Searchable(true)]
		[CultureSpecific]
		public virtual string Header
		{
			get
			{
				var header = this.GetPropertyValue(p => p.Header);
				return !string.IsNullOrWhiteSpace(header) ? header : this.PageName;
			}
			set { this.SetPropertyValue(p => p.Header, value); }
		}
	}
}
