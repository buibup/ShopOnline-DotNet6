global using ShopOnline.Web.Services.Contracts;
global using ShopOnline.Models.Dtos;
global using System.Net.Http.Json;
global using Microsoft.AspNetCore.Components;

using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ShopOnline.Web;
using ShopOnline.Web.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7258/") });

builder.Services.AddScoped<IProductService, ProductService>();

await builder.Build().RunAsync();
