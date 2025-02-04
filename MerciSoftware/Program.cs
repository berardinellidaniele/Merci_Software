var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "register",
        pattern: "register",
        defaults: new { controller = "Account", action = "Register" }
    );

    endpoints.MapControllerRoute(
        name: "logincustom",
        pattern: "login",
        defaults: new { controller = "Account", action = "Login" }
    );

    endpoints.MapDefaultControllerRoute();
});

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();