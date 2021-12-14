using Microsoft.EntityFrameworkCore;
using Software_Engineering_Assingment.Models;

public class DBContext : DbContext
{
  public DBContext(DbContextOptions<DBContext> options)
      : base(options)
  {
  }

  public DbSet<User> User { get; set; }
  public DbSet<Site> Site { get; set; }
  public DbSet<Report> Report { get; set; }
  public DbSet<Element> Element { get; set; }
  public DbSet<ElementHeader> ElementHeader { get; set; }
  public DbSet<ElementSection> ElementSection { get; set; }
}
