using Microsoft.EntityFrameworkCore;
using TeldatToDoInterviewTaskJO.Models;
using TeldatToDoInterviewTaskJO.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AssigmentDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("mainConnectionString")));

builder.Services.AddScoped<IAssigmentService, AssigmentService>();

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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Assigments}/{id?}");

app.Run();
