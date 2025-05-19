using Microsoft.EntityFrameworkCore;
using Stradario;
using Stradario.Components;

Nominatim.Luogo nuovo = new Nominatim.Luogo();

// testo il nostro sistema di gestione delle coordinate
Nominatim.RecuperaWeb(new Stradario.Strutture.Nodo() { nome = "Arezzo" });
Nominatim.RecuperaHTTP(new Stradario.Strutture.Nodo() { nome = "Arezzo" });

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddDbContext<BancaDati>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
