using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Software_Engineering_Assingment.Models
{
  public class ElementHeader
  {
    [Key]
    public int ElementHeaderId { get; set; }
    [Required]
    public string Name { get; set; }
    public List<ElementSection> ElementSections { get; set; }

  }
}
