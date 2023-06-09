using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Machine
  {
    public int MachineId { get; set; }
    [Required(ErrorMessage = "ERROR cannot leave this blank! Give it another go.")]
    public string Name { get; set; }
    public List<EngineerMachine> JoinEntities { get; }
  }
}