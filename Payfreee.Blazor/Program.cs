using BlazorApp.Helpers;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Payfreee.Common.Service;
using Payfreee.Common.Service.Contracts;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Payfreee.Blazor
{
	public class Program
	{
		public static async Task Main(string[] args)
		{
			var builder = WebAssemblyHostBuilder.CreateDefault(args);
			builder.RootComponents.Add<App>("#app");
			
			builder.Services
			   .AddScoped<IAuthenticationService, AuthenticationService>()
			   .AddScoped<IUserService, UserService>()
			   .AddScoped<IHttpService, HttpService>()
			   .AddScoped<ILocalStorageService, LocalStorageService>()
			   .AddScoped<IToastService, ToastService>();

			// configure http client
			builder.Services.AddScoped(x => {
				var apiUrl = new Uri(builder.Configuration["apiUrl"]);

				// use fake backend if "fakeBackend" is "true" in appsettings.json
				if (builder.Configuration["fakeBackend"] == "true")
					return new HttpClient(new FakeBackendHandler()) { BaseAddress = apiUrl };

				return new HttpClient() { BaseAddress = apiUrl };
			});

			await builder.Build().RunAsync();
		}
	}
}
