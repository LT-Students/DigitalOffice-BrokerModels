using System;
using System.Collections.Generic;

namespace DigitalOffice.Models.Broker.Requests.Filter
{
  public interface IFilterPositionUsersRequest
  {
    List<Guid> PositionIds { get; }
    
    static object CreateObj(List<Guid> positionIds)
    {
      return new
      {
        PositionIds = positionIds
      };
    }
  }
}
