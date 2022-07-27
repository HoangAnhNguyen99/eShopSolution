using LazZiya.ExpressLocalization;
using Microsoft.AspNetCore.Localization;
using sShopSolution.WebApp.LocalizationResources;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

var cultures = new[]
{
    new CultureInfo("en"),
    new CultureInfo("vi"),
};

// Add services to the container.
builder.Services.AddControllersWithViews().AddExpressLocalization<ExpressLocalizationResource, ViewLocalizationResource>(ops =>
{
    ops.UseAllCultureProviders = false;
    ops.ResourcesPath = "LocalizationResources";
    ops.RequestLocalizationOptions = o =>
    {
        o.SupportedCultures = cultures;
        o.SupportedCultures = cultures;
        o.DefaultRequestCulture = new RequestCulture("vi");
    };
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseRequestLocalization();

app.MapControllerRoute(
    name: "default",
    pattern: "{culture=en}/{controller=Home}/{action=Index}/{id?}");

app.Run();