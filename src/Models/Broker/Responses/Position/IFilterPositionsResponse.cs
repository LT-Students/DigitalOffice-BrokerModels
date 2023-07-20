using LT.DigitalOffice.Models.Broker.Models.Position;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Responses.Position;

public interface IFilterPositionsResponse
{
  List<PositionFilteredData> Positions { get; }

  static object CreateObj(List<PositionFilteredData> positions)
  {
    return new
    {
      Positions = positions
    };
  }
}
