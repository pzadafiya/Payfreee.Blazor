using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payfreee.Blazor.Utils
{
	public static class RazorExtention
	{
		public static string AddFileVersionToPath(this IRazorPage page, string path)
		{
			if (page is null)
				throw new System.ArgumentNullException(nameof(page));
			if (string.IsNullOrEmpty(path))
				throw new System.ArgumentException($"'{nameof(path)}' cannot be null or empty.", nameof(path));
			var context = page.ViewContext.HttpContext;
			var fileVersionProvider = context.RequestServices.GetRequiredService<IFileVersionProvider>();
			return fileVersionProvider.AddFileVersionToPath(context.Request.PathBase, path);
		}
	}
}
