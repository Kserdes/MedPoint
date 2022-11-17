using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MedPoint.Data;
using Microsoft.Extensions.Options;
using MedPoint.Models;
using MedPoint.Data.Services;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("MedPointContextConnection") ?? throw new InvalidOperationException("Connection string 'MedPointContextConnection' not found.");

builder.Services.AddDbContext<MedPoint.Data.AppDBContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<IdentityAccount>(options => options.SignIn.RequireConfirmedAccount = false) 
    .AddEntityFrameworkStores<MedPoint.Data.AppDBContext>();
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IDoctorsService, DoctorsService>();
builder.Services.AddScoped<IVisitsService, VisitsService>();
var app = builder.Build();
AppDBSeeder.Seed(app);

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
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();
app.Run();



