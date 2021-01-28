using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Damnazon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using Stripe;

namespace Damnazon
{
  public class Startup
  {
    public Startup(IHostingEnvironment env)
    {
      var builder = new ConfigurationBuilder()
          .SetBasePath(env.ContentRootPath)
          .AddJsonFile("appsettings.json");
      Configuration = builder.Build();
    }

    public IConfigurationRoot Configuration { get; set; }

    public void ConfigureServices(IServiceCollection services)
    {

      StripeConfiguration.ApiKey = EnvironmentVariables.ApiKey;

      services.AddSwaggerDocument();
      services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
      services.AddScoped<ICategoryRepository, CategoryRepository>();
      services.AddScoped<IProductRepository, ProductRepository>();
      services.AddScoped<IOrderRepository, OrderRepository>();
      services.AddScoped<ShoppingCart>(s => ShoppingCart.GetShoppingCart(s));
      services.AddHttpContextAccessor();
      services.AddSession();

      services.AddEntityFrameworkMySql()
        .AddDbContext<DamnazonContext>(options => options
        .UseMySql(Configuration["ConnectionStrings:DefaultConnection"]));

      services.AddIdentity<ApplicationUser, IdentityRole>()
        .AddEntityFrameworkStores<DamnazonContext>()
        .AddDefaultTokenProviders();

      services.Configure<IdentityOptions>(options =>
      {
        options.Password.RequireDigit = false;
        options.Password.RequiredLength = 0;
        options.Password.RequireLowercase = false;
        options.Password.RequireNonAlphanumeric = false;
        options.Password.RequireUppercase = false;
        options.Password.RequiredUniqueChars = 0;
      });
    }

    public void Configure(IApplicationBuilder app)
    {
      app.UseStaticFiles();
      app.UseSession();
      app.UseDeveloperExceptionPage();
      app.UseAuthentication();
      app.UseOpenApi();
      app.UseSwaggerUi3();

      app.UseMvc(routes =>
      {
        routes.MapRoute(
          name: "default",
          template: "{controller=Home}/{action=Index}/{id?}");
      });

      app.Run(async (context) =>
      {
        await context.Response.WriteAsync("Something went wrong!");
      });
    }
  }
}