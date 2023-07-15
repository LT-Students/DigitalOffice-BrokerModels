using LT.DigitalOffice.Models.Broker.Models.Position;
using System;
using System.Collections.Generic;

namespace DigitalOffice.Models.Broker.Responses.Position;

public interface IGetPositionsDictionaryResponse
{
  Dictionary<Guid, PositionData> PositionsDictionary { get; }

  static object CreateObj(Dictionary<Guid, PositionData> positionsDictionary)
  {
    return new
    {
      PositionsDictionary = positionsDictionary
    };
  }
}
