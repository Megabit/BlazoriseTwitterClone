using Blazorise;
using Blazorise.Icons.FluentUI;
using Blazorise.Tailwind;
using BlazoriseTwitterClone.Data;
using BlazoriseTwitterClone.UI;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder( args );

builder.Services
    .AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services
    .AddBlazorise()
    .AddTailwindProviders()
    .AddFluentUIIcons();

builder.Services.AddScoped<TwitterDataService>();

var app = builder.Build();

if ( !app.Environment.IsDevelopment() )
{
    app.UseExceptionHandler( "/Error" );
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
