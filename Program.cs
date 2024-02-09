var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); //Aktiverar MVC



var app = builder.Build();

app.UseStaticFiles(); //statiska filer
app.UseRouting();

app.MapControllerRoute(
    name:"Default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();
