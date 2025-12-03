var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();

string? con=builder.Configuration.GetConnectionString("local");
Console.WriteLine(con);

var app = builder.Build();


app.UseStaticFiles();

app.MapControllerRoute(name: "ourRoute",
     pattern: "{controller=Employee}/{action=Index}/{id?}");

app.Run();
