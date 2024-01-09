using LearnProject.Business.Abstract;
using LearnProject.Business.Concrete.Managers;
using LearnProject.DataAccess.Abstract;
using LearnProject.DataAccess.Concrete.EFCore;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddMvc();
builder.Services.AddControllers();
builder.Services.AddHttpClient();
//Services inject
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IProductService, ProductService>();
//Repository inject
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();

builder.Services.AddControllersWithViews();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(o =>
{
    //o.ExpireTimeSpan = TimeSpan.FromMinutes(120);
    //o.LoginPath = "/Login/Login";
    //o.LogoutPath = "/Account/LogOut";
    //o.AccessDeniedPath = "/Account/Denied"; //Role uyğun olmadıqda yonelmeni temin edecekdir.
    //o.SlidingExpiration = true;
});

//[AllowAnonymous] Atributu verilməyən hər bir Controller-in action-larına girişə icazə verilmir
builder.Services.AddMvc(config =>
{
    var policy = new AuthorizationPolicyBuilder()
    .RequireAuthenticatedUser()
    .Build();

    // Explicitly specify the constructor with AuthorizationPolicy parameter
    var authorizeFilter = new AuthorizeFilter(policy);
    config.Filters.Add(authorizeFilter);
});

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

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "{controller}/{action}",
    pattern: "{controller=Login}/{action=Login}");

app.Run();
