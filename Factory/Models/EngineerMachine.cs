using System.Collections.Generic;

namespace Factory.Models
{
  public class EngineeMachine
  {
    public int EngineeMachineId { get; set }
    public int MachineId { get; set; }
    public int EngineerId { get; set; }
    public Machine Machine { get; set; }
    public Engineer Engineer { get; set; }
  }
}