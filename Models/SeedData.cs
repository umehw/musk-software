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
        context.SaveChanges();

        context.Site.AddRange(
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

        context.ElementHeader.AddRange(
          new ElementHeader
          {
            Name = "Working Standards"
          },
          new ElementHeader
          {
            Name = "Quality"
          },
          new ElementHeader
          {
            Name = "Site Rules"
          },
          new ElementHeader
          {
            Name = "Environmental"
          },
          new ElementHeader
          {
            Name = "Protection of Individuals"
          },
          new ElementHeader
          {
            Name = "Tools, Cables & Other Equipment"
          },
          new ElementHeader
          {
            Name = "Miscellaneous"
          }
        );
        context.SaveChanges();

        context.ElementSection.AddRange(
          /* Working Standards */
          new ElementSection
          {
            Name = "Work At Height",
            ElementHeaderId = context.ElementHeader.Single(s => s.Name == "Working Standards").ElementHeaderId
          },
          new ElementSection
          {
            Name = "Lifting Operations - Crane, Fork Lift Truck, Hoists, etc.",
            ElementHeaderId = context.ElementHeader.Single(s => s.Name == "Working Standards").ElementHeaderId
          },
          new ElementSection
          {
            Name = "Certification - Daily Checksheets for MEWP and FLT",
            ElementHeaderId = context.ElementHeader.Single(s => s.Name == "Working Standards").ElementHeaderId
          }, new ElementSection
          {
            Name = "Confined Space Work",
            ElementHeaderId = context.ElementHeader.Single(s => s.Name == "Working Standards").ElementHeaderId
          }, new ElementSection
          {
            Name = "Electrical Work",
            ElementHeaderId = context.ElementHeader.Single(s => s.Name == "Working Standards").ElementHeaderId
          },

       /* Quality */
       new ElementSection
       {
         Name = "Site Set Up & Appearance, Signage",
         ElementHeaderId = context.ElementHeader.Single(s => s.Name == "Quality").ElementHeaderId
       },
       new ElementSection
       {
         Name = "Paperwork (Permits, Risk Assessments, Method Statement)",
         ElementHeaderId = context.ElementHeader.Single(s => s.Name == "Quality").ElementHeaderId
       },
       new ElementSection
       {
         Name = "Certification - Training, Insurance Inspection, Induction Current",
         ElementHeaderId = context.ElementHeader.Single(s => s.Name == "Quality").ElementHeaderId
       },

       /* Site Rules */
       new ElementSection
       {
         Name = "Hot Work",
         ElementHeaderId = context.ElementHeader.Single(s => s.Name == "Site Rules").ElementHeaderId
       },
       new ElementSection
       {
         Name = "Isolation and Lock Offs",
         ElementHeaderId = context.ElementHeader.Single(s => s.Name == "Site Rules").ElementHeaderId
       },
       new ElementSection
       {
         Name = "Fire Exits and Escape Routes",
         ElementHeaderId = context.ElementHeader.Single(s => s.Name == "Site Rules").ElementHeaderId
       },
       new ElementSection
       {
         Name = "Awareness - Fire Exit, Assembly Point",
         ElementHeaderId = context.ElementHeader.Single(s => s.Name == "Site Rules").ElementHeaderId
       },

       /* Environmetal */
       new ElementSection
       {
         Name = "Waste Management",
         ElementHeaderId = context.ElementHeader.Single(s => s.Name == "Environmental").ElementHeaderId
       },
       new ElementSection
       {
         Name = "Product Contamination",
         ElementHeaderId = context.ElementHeader.Single(s => s.Name == "Environmental").ElementHeaderId
       },
       new ElementSection
       {
         Name = "COSHH & Asbestos",
         ElementHeaderId = context.ElementHeader.Single(s => s.Name == "Environmental").ElementHeaderId
       },

       /* Protection of Individuals */
       new ElementSection
       {
         Name = "PPE",
         ElementHeaderId = context.ElementHeader.Single(s => s.Name == "Protection of Individuals").ElementHeaderId
       },
       new ElementSection
       {
         Name = "Manual Handling",
         ElementHeaderId = context.ElementHeader.Single(s => s.Name == "Protection of Individuals").ElementHeaderId
       },
       new ElementSection
       {
         Name = "Other Contractors",
         ElementHeaderId = context.ElementHeader.Single(s => s.Name == "Protection of Individuals").ElementHeaderId
       },

       /* Tools, Cables & Other Equipment */
       new ElementSection
       {
         Name = "Power Tools, Cables & Other Equipment",
         ElementHeaderId = context.ElementHeader.Single(s => s.Name == "Tools, Cables & Other Equipment").ElementHeaderId
       },
       new ElementSection
       {
         Name = "Voltage Detector Checked",
         ElementHeaderId = context.ElementHeader.Single(s => s.Name == "Tools, Cables & Other Equipment").ElementHeaderId
       },
       new ElementSection
       {
         Name = "Tools Used Fit For Purpose",
         ElementHeaderId = context.ElementHeader.Single(s => s.Name == "Tools, Cables & Other Equipment").ElementHeaderId
       },

       /* Miscellaneous */
       new ElementSection
       {
         Name = "Vehicle Condition",
         ElementHeaderId = context.ElementHeader.Single(s => s.Name == "Miscellaneous").ElementHeaderId
       },
       new ElementSection
       {
         Name = "Vehicle Log Sheet Up to Date",
         ElementHeaderId = context.ElementHeader.Single(s => s.Name == "Miscellaneous").ElementHeaderId
       },
       new ElementSection
       {
         Name = "Vehicle Service Records",
         ElementHeaderId = context.ElementHeader.Single(s => s.Name == "Miscellaneous").ElementHeaderId
       }
       );
        context.SaveChanges();
      }
    }
  }
}

// gen command
// dotnet-aspnet-codegenerator controller -name ElementHeaderController -m ElementHeader -dc DBContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries -sqlite