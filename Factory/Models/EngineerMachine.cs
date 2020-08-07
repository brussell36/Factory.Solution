using System.Collections.Generic;

namespace Factory.Models
{
  public class EnigneerMachine
  {
    public int EnigneerMachineId { get; set; }
    public int EngineerId { get; set; }
    public int MachineId { get; set; }
    public Engineer Engineer { get; set; }
    public Machine Machine { get; set; }
  }
}