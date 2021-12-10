using System;
using System.ComponentModel.DataAnnotations;

namespace Software_Engineering_Assingment.Models
{
  public class User
  {
    [Key]
    public int Id { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    [DataType(DataType.Date)]
    public DateTime CreatedAt { get; set; }
    public RoleType Role { get; set; }
  }
}
