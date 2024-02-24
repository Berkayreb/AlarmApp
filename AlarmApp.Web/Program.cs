
using AlarmApp.BLL.Abstract;
using AlarmApp.BLL.Concrete;
using AlarmApp.DAL.Abstract;
using AlarmApp.DAL.Concrete;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddScoped<IDbService, DbService>();

builder.Services.AddScoped<IAlarmRepository, AlarmRepository>();
builder.Services.AddScoped<IAuthRepository, AuthRepository>();

builder.Services.AddScoped<IAlarmService, AlarmService>();
builder.Services.AddScoped<IAuthService, AuthService>();

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(o =>
    {
        o.ExpireTimeSpan = TimeSpan.FromMinutes(20);
        o.SlidingExpiration = true;
        o.LoginPath = new PathString("/login");
        o.AccessDeniedPath = "/Forbidden/";
    });


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();


app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
