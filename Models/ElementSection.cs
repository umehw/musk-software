using System;
using System.ComponentModel.DataAnnotations;

namespace Software_Engineering_Assingment.Models
{
  public class ElementSection
  {
    [Key]
    public int ElementSectionId { get; set; }
    [Required]
    public string Name { get; set; }
    public int ElementHeaderId { get; set; }

  }
}
