using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Software_Engineering_Assingment
{
  public class Startup
  {
    public Startup(IConfiguration configuration, IWebHostEnvironment env)
    {
      Environment = env;
      Configuration = configuration;

    }

    public IConfiguration Configuration { get; }
    public IWebHostEnvironment Environment { get; }


    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddControllersWithViews();
      services.AddRazorPages();
      services.AddDbContext<DBContext>(options =>
      {
        var connectionString = Configuration.GetConnectionString("DBContext");

        if (Environment.IsDevelopment())
        {
          options.UseSqlite(connectionString);
        }
        else
        {
          options.UseSqlServer(connectionString);
        }
      });
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app)
    {
      if (Environment.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
        app.UseMigrationsEndPoint();
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

      app.UseAuthentication();
      app.UseAuthorization();

      app.UseEndpoints(endpoints =>
      {
        endpoints.MapControllerRoute(
                  name: "default",
                  pattern: "{controller=Home}/{action=Index}/{id?}");
        endpoints.MapRazorPages();
      });
    }
  }
}


// System.InvalidOperationException: "Unable to find the required services. Please add all the required services by calling 'IServiceCollection.AddRazorPages' inside the call to 'ConfigureServices(...)' in the application startup code."
//   at Microsoft.AspNetCore.Builder.RazorPagesEndpointRouteBuilderExtensions.EnsureRazorPagesServices(IEndpointRouteBuilder endpoints)\n   at Microsoft.AspNetCore.Builder.RazorPagesEndpointRouteBuilderExtensions.MapRazorPages(IEndpointRouteBuilder endpoints)\n   at Software_Engineering_Assingment.Startup.<>c.<Configure>b__8_0(IEndpointRouteBuilder endpoints) in /Users/willumeh/Projects/Software_Engineering_Assingment/Software_Engineering_Assingment/Startup.cs:line 77\n   at Microsoft.AspNetCore.Builder.EndpointRoutingApplicationBuilderExtensions.UseEndpoints(IApplicationBuilder builder, Action`1 configure)\n   at Software_Engineering_Assingment.Startup.Configure(IApplicationBuilder app, IWebHostEnvironment env) in /Users/willumeh/Projects/Software_Engineering_Assingment/Software_Engineering_Assingment/Startup.cs:72
