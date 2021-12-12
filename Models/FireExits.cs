using System;
using System.ComponentModel.DataAnnotations;

namespace Software_Engineering_Assingment.Models
{
  public class FireExits : SubItem
  {
    [Key]
    public int FireExitsId { get; set; }
    public int Interventions { get; set; }
    public string Comment { get; set; }
    public bool Completed { get; set; }
    public string ActionTaken { get; set; }
    public int ReportId { get; set; }
    public virtual Report Report { get; set; }

  }
}
