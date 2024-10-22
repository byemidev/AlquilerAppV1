using AlquileresMVC.Data;
using AlquileresMVC.Models;
using AlquileresMVC.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);


//building DbContext
//Le paso la conexion al contexto de admin
builder.Services.AddDbContext<AdminDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString
     ("DefaultConnection")));


//buiding services for can be using DAO in controllers
builder.Services.AddTransient<IUsuarioDAO, UsuarioDAO>();
builder.Services.AddTransient<IReservaDAO, ReservaDAO>();
builder.Services.AddTransient<IIndexDAO, IndexDAO>();

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

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.Run();


