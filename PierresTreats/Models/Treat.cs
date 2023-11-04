using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PierresTreats.Models
{
  public class Treat
  {
    public int TreatId { get; set; }
    [Required(ErrorMessage = "The item's description can't be empty!")]
    public string Description { get; set; }

    public List<TreatFlavor> JoinEntities { get; }
  }
}