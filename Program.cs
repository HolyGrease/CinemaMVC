
using cinema.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


var builder = WebApplication.CreateBuilder(args);

var folder = Environment.SpecialFolder.LocalApplicationData;
var path = Environment.GetFolderPath(folder);
string DbPath = System.IO.Path.Join(path, "movies.db");

builder.Services.AddDbContext<CinemaContext>(options =>
  options.UseSqlite($"Data Source={DbPath}"));

builder.Services.AddScoped<CinemaContext>();

// void SeedDatabase(IWebHost host)
// {
//   using (var scope = builder.Services.CreateScope())
//   {
//     var services = scope.ServiceProvider;
//     try
//     {
//       var context = services.GetRequiredService<CinemaContext>();

//       DbInitializer.Initialize(context);
//     }
//     catch (Exception ex)
//     {
//       var logger = services.GetRequiredService<ILogger<Program>>();
//       logger.LogError("An error occurred while seeding the database");
//     }
//   }
// }

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
  app.UseExceptionHandler("/Home/Error");
  // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
  app.UseHsts();
}

// app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
