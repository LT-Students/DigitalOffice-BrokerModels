using LT.DigitalOffice.Models.Broker.Models.Position;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Responses.Position;

public interface IGetPositionsResponse
{
  List<PositionData> Positions { get; set; }

  static object CreateObj(
      List<PositionData> positions)
  {
    return new
    {
      Positions = positions
    };
  }
}