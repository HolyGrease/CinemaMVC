using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace cinema.Models;

public class Salon
{
  [Key]
  public int Id { get; set; }
  [Display(Name = "Salon")]
  public string Name { get; set; }
  public int Seats { get; set; }
  public List<Display> Displays { get; set; }
}
