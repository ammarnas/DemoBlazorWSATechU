using DemoBlazorWSATechU;
using DemoBlazorWSATechU.Code;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// injecting services
builder.Services.AddScoped<IDataHelper, EmployeeHelper>();

await builder.Build().RunAsync();
