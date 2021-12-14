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
    public string InspectorId { get; set; }
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
    public List<Element> Elements { get; set; }

    public string AdditionalComments { get; set; }
    public bool IsHighRiskActivity { get; set; }

  }
}
