using System;
using System.ComponentModel.DataAnnotations;

namespace Software_Engineering_Assingment.Models
{
  public class Site
  {
    [Key]
    public int SiteId { get; set; }
    [Required]
    public string Name { get; set; }
  }
}
