var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.MapDefaultControllerRoute();

app.Run();
