using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Software_Engineering_Assingment.Models
{
  public static class SeedData
  {
    public static void Initialize(IServiceProvider serviceProvider)
    {
      using (var context = new DBContext(
          serviceProvider.GetRequiredService<
              DbContextOptions<DBContext>>()))
      {
        // Look for any users.
        if (context.User.Any())
        {
          return;   // DB has been seeded
        }

        context.User.AddRange(
            new User
            {
              Email = "admin@admin.com",
              Password = "admin123",
              FirstName = "John",
              LastName = "Doe",
              Role = RoleType.Admin
            },

            new User
            {
              Email = "engineer@engineer.com",
              Password = "Engineer123",
              FirstName = "Sarah",
              LastName = "Singh",
              Role = RoleType.Engineer
            }
        );

        context.Site.AddRange(
          new Site
          {
            Name = "Tate and Lyle"
          },
          new Site
          {
            Name = "Tate and Lyle"
          },
          new Site
          {
            Name = "Project Safety Audits"
          },

          new Site
          {
            Name = "Weetabix Burton AP1 / Main"
          },

          new Site
          {
            Name = "Musk Design"
          },
          new Site
          {
            Name = "AkzoNobel Stowmarket"
          },
          new Site
          {
            Name = "Koito"
          },


          new Site
          {
            Name = "Mars Melton"
          }
        );
        context.SaveChanges();
      }
    }
  }
}

// gen command
// dotnet-aspnet-codegenerator controller -name ReportController -m Report -dc DBContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries -sqlite