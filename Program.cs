using Blazored.LocalStorage;

using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using APIEstherMM;

using APIEstherMM.Services;
var builder = WebAssemblyHostBuilder.CreateDefault(args);



builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<Apiservice>();

builder.Logging.SetMinimumLevel(LogLevel.Debug);
builder.Services.AddScoped<StockageLocal>();
builder.Services.AddBlazoredLocalStorage();

await builder.Build().RunAsync();

    


// Peut etre rajouter un builder pour le async
// builder.Services. ; 

