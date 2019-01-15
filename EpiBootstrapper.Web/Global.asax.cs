using System.Linq;
using System.Web.Mvc;

namespace EpiBootstrapper
{
    public class EPiServerApplication : EPiServer.Global
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

			//Tip: Want to call the EPiServer API on startup? Add an initialization module instead (Add -> New Item.. -> EPiServer -> Initialization Module)
			var razorEngine = ViewEngines.Engines.OfType<RazorViewEngine>().First();
	        razorEngine.ViewLocationFormats = razorEngine.ViewLocationFormats.Concat(new string[]
	        {
		        "~/Views/Pages/{1}/{0}.cshtml",
		        "~/Views/Blocks/{0}.cshtml",
		        "~/Views/Shared/{0}.cshtml"
	        }).ToArray();
		}
    }
}