using DataLayer;
using DataLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using System.Net.NetworkInformation;

var builder = WebApplication.CreateBuilder(
new WebApplicationOptions()
{
	WebRootPath = "Public"
});

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AccountingAppDBContext>(options =>
{
	options.UseSqlServer(builder.Configuration.GetConnectionString("AccMeConnection"));
});

builder.Services.AddScoped<UnitOfWork>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles(new StaticFileOptions {
	FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "PicUsersFoldForShowingToPeople")),
	RequestPath = "/PFFSTP"
});
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();


app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
