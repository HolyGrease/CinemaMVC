using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cinema.Models;

public class Movie
{
  [Key]
  public int Id { get; set; }
  [Column(TypeName = "text")]
  [Display(Name = "Movie title")]
  public string Title { get; set; }
  public IList<Display> Displays { get; set; }
}
