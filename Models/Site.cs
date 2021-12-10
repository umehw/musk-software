using System;
using System.ComponentModel.DataAnnotations;

namespace Software_Engineering_Assingment.Models
{
  public class Site
  {
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
  }
}
