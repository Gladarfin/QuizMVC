using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using QuizMVC.Data;
using QuizMVC.Repositories.Interfaces;
using QuizMVC.Repositories.UnitOfWork;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("QuizMVCConnection");
builder.Services.AddDbContext<QuizMvcDbContext>(options =>
    options.UseNpgsql(connectionString,
        x => x.MigrationsAssembly("QuizMVC.Migrations")));
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<QuizMvcDbContext>();
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapAreaControllerRoute(
    name:"Tables",
    areaName:"Tables",
    pattern:"{controller}/{action=Index}/{id?}");

app.MapAreaControllerRoute(
    name:"Quiz",
    areaName:"Quiz",
    pattern:"{controller}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();