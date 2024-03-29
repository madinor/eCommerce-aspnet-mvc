using eCommerce.Controllers;
using eCommerce.Data;
using eCommerce.Data.Cart;
using eCommerce.Data.Services;
using eCommerce.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static void Main(string[] args)
    {
        WebApplicationBuilder webApplicationBuilder = WebApplication.CreateBuilder(args);
        var builder = webApplicationBuilder;
        //DbContext Configuration
        builder.Services.AddDbContext<EcomDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaulConnectionString")));

        //Services configuration
        builder.Services.AddScoped<IActorsService, ActorsService>();
        builder.Services.AddScoped<IProducersService, ProducersService>();
        builder.Services.AddScoped<ICinemasService, CinemasService>();
        builder.Services.AddScoped<IMoviesService, MoviesService>();
        builder.Services.AddScoped<IOrdersService, OrdersService>();
        builder.Services.AddScoped(sc => ShoppingCart.GetShoppingCart(sc));
        //Authentication and authorization
        builder.Services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<EcomDbContext>();
        builder.Services.AddMemoryCache();
        builder.Services.AddSession();
        builder.Services.AddAuthentication(options=>
        {
            options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;

        });

        builder.Services.AddControllersWithViews();
        builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        
        
        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        else
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();
        app.UseSession();

        //Authentication and authorization
        app.UseAuthentication();
        app.UseAuthorization();

        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Movies}/{action=Index}/{id?}");
        });
        //Seed database
        EcomDbInitializer.Seed(app);
        EcomDbInitializer.SeedUsersAndRolesAsync(app).Wait();

        app.Run();
    }
}