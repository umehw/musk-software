using System.ComponentModel.DataAnnotations;

namespace Software_Engineering_Assingment.Models
{
  public interface SubItem
  {
    [Required]
    int Interventions { get; set; }
    string Comment { get; set; }
    [Required]
    bool Completed { get; set; }
    string ActionTaken { get; set; }
    [Required]
    int ReportId { get; set; }
    Report Report { get; set; }
  }

}