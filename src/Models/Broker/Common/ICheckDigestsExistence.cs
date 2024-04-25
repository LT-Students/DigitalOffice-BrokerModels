using System.Collections.Generic;

namespace DigitalOffice.Models.Broker.Common;

public interface ICheckDigestsExistence
{
  List<int> DigestsIds { get; }

  static object CreateObj(List<int> digestsIds)
  {
    return new 
    {
      DigestsIds = digestsIds
    };
  }
}