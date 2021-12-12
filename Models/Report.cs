using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Software_Engineering_Assingment.Models
{
  public class Report
  {
    [Key]
    public int Id { get; set; }


    [Required]
    [Display(Name = "Site")]
    public int SiteId { get; set; }
    public List<Site> Sites { get; set; }
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
    public int CompletedById { get; set; }
    public List<User> Users { get; set; }

    [Required]
    public int InspectorId { get; set; }
    public DateTime Date { get; set; }
    public string Type { get; set; }
    [DataType(DataType.Date)]
    public DateTime CreatedAt { get; set; }


    public virtual Site Site { get; set; }
    public virtual User User { get; set; }


    [Required]
    public string AwarenessFireExitsId { get; set; }
    public virtual AwarenessFireExits AwarenessFireExits { get; set; }

    [Required]
    public string CertificationDailyChecksheetsId { get; set; }
    public virtual CertificationDailyChecksheets CertificationDailyChecksheets { get; set; }

    [Required]
    public string CertificationTrainingInsuranceId { get; set; }
    public virtual CertificationTrainingInsurance CertificationTrainingInsurance { get; set; }

    [Required]
    public string ConfinedSpaceWorkId { get; set; }
    public virtual ConfinedSpaceWork ConfinedSpaceWork { get; set; }

    [Required]
    public string COSHHId { get; set; }
    public virtual COSHH COSHH { get; set; }

    [Required]
    public string ElectricalWorkId { get; set; }
    public virtual ElectricalWork ElectricalWork { get; set; }

    [Required]
    public string FireExitsId { get; set; }
    public virtual FireExits FireExits { get; set; }

    [Required]
    public string HotWorkId { get; set; }
    public virtual HotWork HotWork { get; set; }

    [Required]
    public string IsolationId { get; set; }
    public virtual Isolation Isolation { get; set; }

    [Required]
    public string LiftingOperationsId { get; set; }
    public virtual LiftingOperations LiftingOperations { get; set; }

    [Required]
    public string ManualHandlingId { get; set; }
    public virtual ManualHandling ManualHandling { get; set; }

    [Required]
    public string OtherContractorsId { get; set; }
    public virtual OtherContractors OtherContractors { get; set; }

    [Required]
    public string PaperworkId { get; set; }
    public virtual Paperwork Paperwork { get; set; }

    [Required]
    public string PowerToolsId { get; set; }
    public virtual PowerTools PowerTools { get; set; }

    [Required]
    public string PPEId { get; set; }
    public virtual PPE PPE { get; set; }

    [Required]
    public string ProductContaminationId { get; set; }
    public virtual ProductContamination ProductContamination { get; set; }

    [Required]
    public string SiteSetUpAppearanceId { get; set; }
    public virtual SiteSetUpAppearance SiteSetUpAppearance { get; set; }

    [Required]
    public string ToolsUsedFitForPurposeId { get; set; }
    public virtual ToolsUsedFitForPurpose ToolsUsedFitForPurpose { get; set; }

    [Required]
    public string VehicleConditionId { get; set; }
    public virtual VehicleCondition VehicleCondition { get; set; }

    [Required]
    public string VehicleLogSheetUpToDateId { get; set; }
    public virtual VehicleLogSheetUpToDate VehicleLogSheetUpToDate { get; set; }

    [Required]
    public string VehicleServiceRecordsId { get; set; }
    public virtual VehicleServiceRecords VehicleServiceRecords { get; set; }

    [Required]
    public string VoltageDetectorCheckedId { get; set; }
    public virtual VoltageDetectorChecked VoltageDetectorChecked { get; set; }

    [Required]
    public string WasteManagementId { get; set; }
    public virtual WasteManagement WasteManagement { get; set; }

    [Required]
    public string WorkAtHeightId { get; set; }
    public virtual WorkAtHeight WorkAtHeight { get; set; }

  }
}
