// Diretivas using ficam no topo do arquivo
using enemlab;
using enemlab.Services; // <<-- ADICIONE O 'USING' AQUI
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// O lugar correto para registrar servi�os � aqui
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddSingleton<ProvaStateService>(); // <<-- ADICIONE O SERVI�O AQUI

// Esta linha deve ser uma das �ltimas, pois ela "constr�i" e inicia o app
await builder.Build().RunAsync();