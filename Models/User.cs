using System;
using System.ComponentModel.DataAnnotations;

namespace Software_Engineering_Assingment.Models
{
  public class User
  {
    [Key]
    public int UserId { get; set; }
    [Required]
    public string Email { get; set; }
    [Required]
    public string Password { get; set; }
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }

    [DataType(DataType.Date)]
    public DateTime CreatedAt { get; set; }
    [Required]
    public RoleType Role { get; set; }
  }
}
