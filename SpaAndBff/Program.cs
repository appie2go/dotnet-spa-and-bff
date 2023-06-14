using GoCloudNative.Bff.Authentication.Auth0;
using GoCloudNative.Bff.Authentication.ModuleInitializers;

var builder = WebApplication.CreateBuilder(args);

// <snippet 1>
builder.Services.AddSecurityBff(o =>
{
    o.ConfigureAuth0(builder.Configuration.GetSection("Auth0"));
    o.LoadYarpFromConfig(builder.Configuration.GetSection("ReverseProxy"));
});
// </snippet 1>

builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

// <snippet 2>
app.UseSecurityBff();
// </snippet 2>

// And remove this:
// app.MapControllerRoute(
//     name: "default",
//     pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html");

app.Run();
