﻿using EPiServer.DataAnnotations;

namespace  EpiBootstrapper.Core.Infrastructure
{
	public class ThumbnailImageAttribute : ImageUrlAttribute
	{
		public ThumbnailImageAttribute() :
			base(string.Concat(Constants.ContentTypes.StaticGraphicsDirectory, Constants.ContentTypes.Graphics.Notepad))
		{ }

		public ThumbnailImageAttribute(string imageFileName) :
			base(string.Concat(Constants.ContentTypes.StaticGraphicsDirectory, imageFileName))
		{ }
	}
}