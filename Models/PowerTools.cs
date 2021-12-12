using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Software_Engineering_Assingment.Models
{
  public class PowerTools : SubItem
  {
    [Key]
    public int PowerToolsId { get; set; }
    public int Interventions { get; set; }
    public string Comment { get; set; }
    public bool Completed { get; set; }
    public string ActionTaken { get; set; }
    public int ReportId { get; set; }
    [Required]
    [ForeignKey("ReportId")]
    public Report Report { get; set; }

  }
}
