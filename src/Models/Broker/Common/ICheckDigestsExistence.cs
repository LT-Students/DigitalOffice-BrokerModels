using System;
using System.Collections.Generic;

namespace DigitalOffice.Models.Broker.Common;

public interface ICheckDigestsExistence
{
  List<Guid> DigestsIds { get; }

  static object CreateObj(List<Guid> digestsIds)
  {
    return new 
    {
      DigestsIds = digestsIds
    };
  }
}