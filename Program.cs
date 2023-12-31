using Microsoft.EntityFrameworkCore;
using PostoInformatica_ERP.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var connectionString = builder.Configuration.GetConnectionString("FirebirdConnection");
builder.Services.AddDbContext<Contexto>(options =>
    options.UseFirebird(connectionString));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=CLIENTES}/{action=Index}/{id?}");

app.Run();
