using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId { get; set; }
    [Required(ErrorMessage = "ERROR cannot leave this blank! Give it another go.")]
    public string Name { get; set; }
    public List<EngineerMachine> JoinEntities { get; }
  }
}
