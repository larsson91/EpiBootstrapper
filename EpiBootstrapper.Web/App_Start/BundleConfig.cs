using System.Web.Optimization;

namespace EpiBootstrapper
{
	public class BundleConfig
	{
		public static void RegisterBundles(BundleCollection bundles)
		{
			bundles.Add(new StyleBundle("~/Static/css").Include(
				"~/dist/main.css"
			));

			bundles.Add(new ScriptBundle("~/Static/scripts").Include(
				"~/dist/main.js"
			));

			BundleTable.EnableOptimizations = true;
		}
	}
}