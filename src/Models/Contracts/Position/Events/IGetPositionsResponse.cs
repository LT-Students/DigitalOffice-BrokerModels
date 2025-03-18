using System.Collections.Generic;

namespace DigitalOffice.Models.Contracts.Position.Events
{
  public interface IGetPositionsResponse
  {
    List<PositionInfo> Positions { get; set; }

    static object CreateObj(List<PositionInfo> positions)
    {
      return new { Positions = positions };
    }
  }
}