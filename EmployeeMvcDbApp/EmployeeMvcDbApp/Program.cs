using EmployeeMvcDbApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();



string? connectionString=builder.Configuration.GetConnectionString("local");
Console.WriteLine(connectionString);

builder.Services.AddDbContext<EmployeeDbContext>
    (options =>
{
    options.UseSqlServer(connectionString);
});

var app = builder.Build();


app.UseStaticFiles();

app.MapControllerRoute(name: "ourRoute",
     pattern: "{controller=Employee}/{action=Index}/{id?}");

app.Run();
