using System;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Requests.Position;

public interface IFilterPositionsRequest
{
  List<Guid> PositionsIds { get; }

  static object CreateObj(List<Guid> positionsIds)
  {
    return new
    {
      PositionsIds = positionsIds
    };
  }
}
