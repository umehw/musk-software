using System;
using System.ComponentModel.DataAnnotations;

namespace Software_Engineering_Assingment.Models
{
  public class Element
  {
    [Key]
    public int ElementId { get; set; }
    public int ElementHeaderId { get; set; }
    public int ElementSectionId { get; set; }
    public int ReportId { get; set; }
    [Required]
    public string Interventions { get; set; }
    public string Comment { get; set; }
    public string Completed { get; set; }
    public string ActionTaken { get; set; }

    public ElementHeader ElementHeader { get; set; }
    public ElementSection ElementSection { get; set; }


  }
}
