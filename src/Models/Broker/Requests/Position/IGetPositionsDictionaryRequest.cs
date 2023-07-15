using System;
using System.Collections.Generic;

namespace DigitalOffice.Models.Broker.Requests.Position;

public interface IGetPositionsDictionaryRequest
{
  List<Guid> PositionsIds { get; }
  bool IncludeUsers { get; }

  static object CreateObj(
    List<Guid> positionsIds,
    bool includeUsers = false)
  {
    return new
    {
      PositionsIds = positionsIds,
      IncludeUsers = includeUsers
    };
  }
}
