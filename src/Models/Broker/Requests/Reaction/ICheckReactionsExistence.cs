using System.Collections.Generic;

namespace DigitalOffice.Models.Broker.Requests.Reaction;

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