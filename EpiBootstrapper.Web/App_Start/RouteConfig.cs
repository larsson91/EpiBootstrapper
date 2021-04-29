﻿using System.Web.Mvc;
using System.Web.Routing;

namespace EpiBootstrapper
{
	public class RouteConfig
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.MapMvcAttributeRoutes();

			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
		}
	}
}