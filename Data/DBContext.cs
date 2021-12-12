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
  public DbSet<Software_Engineering_Assingment.Models.Report> Report { get; set; }
  public DbSet<Software_Engineering_Assingment.Models.AwarenessFireExits> AwarenessFireExits { get; set; }
  public DbSet<Software_Engineering_Assingment.Models.CertificationDailyChecksheets> CertificationDailyChecksheets { get; set; }
  public DbSet<Software_Engineering_Assingment.Models.CertificationTrainingInsurance> CertificationTrainingInsurance { get; set; }
  public DbSet<Software_Engineering_Assingment.Models.ConfinedSpaceWork> ConfinedSpaceWork { get; set; }
  public DbSet<Software_Engineering_Assingment.Models.COSHH> COSHH { get; set; }
  public DbSet<Software_Engineering_Assingment.Models.ElectricalWork> ElectricalWork { get; set; }
  public DbSet<Software_Engineering_Assingment.Models.FireExits> FireExits { get; set; }
  public DbSet<Software_Engineering_Assingment.Models.HotWork> HotWork { get; set; }
  public DbSet<Software_Engineering_Assingment.Models.Isolation> Isolation { get; set; }
  public DbSet<Software_Engineering_Assingment.Models.LiftingOperations> LiftingOperations { get; set; }
  public DbSet<Software_Engineering_Assingment.Models.ManualHandling> ManualHandling { get; set; }
  public DbSet<Software_Engineering_Assingment.Models.OtherContractors> OtherContractors { get; set; }
  public DbSet<Software_Engineering_Assingment.Models.Paperwork> Paperwork { get; set; }
  public DbSet<Software_Engineering_Assingment.Models.PowerTools> PowerTools { get; set; }
  public DbSet<Software_Engineering_Assingment.Models.PPE> PPE { get; set; }
  public DbSet<Software_Engineering_Assingment.Models.ProductContamination> ProductContamination { get; set; }
  public DbSet<Software_Engineering_Assingment.Models.SiteSetUpAppearance> SiteSetUpAppearance { get; set; }
  public DbSet<Software_Engineering_Assingment.Models.ToolsUsedFitForPurpose> ToolsUsedFitForPurpose { get; set; }
  public DbSet<Software_Engineering_Assingment.Models.VehicleCondition> VehicleCondition { get; set; }
  public DbSet<Software_Engineering_Assingment.Models.VehicleLogSheetUpToDate> VehicleLogSheetUpToDate { get; set; }
  public DbSet<Software_Engineering_Assingment.Models.VehicleServiceRecords> VehicleServiceRecords { get; set; }
  public DbSet<Software_Engineering_Assingment.Models.VoltageDetectorChecked> VoltageDetectorChecked { get; set; }
  public DbSet<Software_Engineering_Assingment.Models.WasteManagement> WasteManagement { get; set; }
  public DbSet<Software_Engineering_Assingment.Models.WorkAtHeight> WorkAtHeight { get; set; }
}
