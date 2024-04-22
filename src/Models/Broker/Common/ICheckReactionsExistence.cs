using System.Collections.Generic;

namespace DigitalOffice.Models.Broker.Common;

public interface ICheckReactionsExistence
{
  List<int> ReactionsIds { get; }

  static object CreateObj(List<int> reactionsIds)
  {
    return new 
    {
      ReactionsIds = reactionsIds
    };
  }
}