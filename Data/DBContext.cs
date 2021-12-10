using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Software_Engineering_Assingment.Models;

public class DBContext : DbContext
{
  public DBContext(DbContextOptions<DBContext> options)
      : base(options)
  {
  }

  public DbSet<Software_Engineering_Assingment.Models.User> User { get; set; }
  public DbSet<Software_Engineering_Assingment.Models.Site> Site { get; set; }
}
