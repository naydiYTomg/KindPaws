using KindPaws.BLL;
using KindPaws.Core.DTOs;
using KindPaws.Core.InputModels;
using KindPaws.UI.Components;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Components.Authorization;
using MudBlazor.Services;

namespace KindPaws.UI;

public class Program
{
    public static readonly ShelterManager ShelterManager = new();
    public static readonly FundraiserManager FundraiserManager = new();
    public static readonly AnimalManager AnimalManager = new();
    public static readonly UserManager UserManager = new();

    public static UserRegisteringInputModel? CurrentUser = null;
    
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddRazorComponents()
            .AddInteractiveServerComponents();
        
        builder.Services.AddMudServices();

        
        var app = builder.Build();
        

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();

        app.UseStaticFiles();
        app.UseAntiforgery();

        app.MapRazorComponents<App>()
            .AddInteractiveServerRenderMode();

        app.Run();
    }
}