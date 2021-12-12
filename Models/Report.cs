using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Software_Engineering_Assingment.Models
{
  public class Report
  {
    [Key]
    public int ReportId { get; set; }


    [Required]
    [Display(Name = "Site")]
    public int SiteId { get; set; }
    [Required]
    [Display(Name = "Work Area")]
    public string WorkArea { get; set; }
    [Required]
    public string Supervisor { get; set; }
    [Required]
    [Display(Name = "Job Description")]
    public string JobDescription { get; set; }

    [Required]
    [Display(Name = "Completed By")]
    public int UserId { get; set; }

    [Required]
    public int InspectorId { get; set; }
    public DateTime Date { get; set; }
    public string Type { get; set; }
    [DataType(DataType.Date)]
    public DateTime CreatedAt { get; set; }

    [Required]
    [ForeignKey("SiteId")]
    public Site Site { get; set; }
    [Required]
    [ForeignKey("UserId")]
    public User User { get; set; }

    public AwarenessFireExits AwarenessFireExits { get; set; }
    public CertificationDailyChecksheets CertificationDailyChecksheets { get; set; }
    public CertificationTrainingInsurance CertificationTrainingInsurance { get; set; }
    public ConfinedSpaceWork ConfinedSpaceWork { get; set; }
    public COSHH COSHH { get; set; }
    public ElectricalWork ElectricalWork { get; set; }
    public FireExits FireExits { get; set; }
    public HotWork HotWork { get; set; }
    public Isolation Isolation { get; set; }
    public LiftingOperations LiftingOperations { get; set; }
    public ManualHandling ManualHandling { get; set; }
    public OtherContractors OtherContractors { get; set; }
    public Paperwork Paperwork { get; set; }
    public PowerTools PowerTools { get; set; }
    public PPE PPE { get; set; }
    public ProductContamination ProductContamination { get; set; }
    public SiteSetUpAppearance SiteSetUpAppearance { get; set; }
    public ToolsUsedFitForPurpose ToolsUsedFitForPurpose { get; set; }
    public VehicleCondition VehicleCondition { get; set; }
    public VehicleLogSheetUpToDate VehicleLogSheetUpToDate { get; set; }
    public VehicleServiceRecords VehicleServiceRecords { get; set; }
    public VoltageDetectorChecked VoltageDetectorChecked { get; set; }
    public WasteManagement WasteManagement { get; set; }
    public WorkAtHeight WorkAtHeight { get; set; }
  }
}
