using System;
using System.Collections.Generic;

namespace DigitalOffice.Models.Broker.Responses.Filter
{
  public interface IFilterEntityUsersResponse
  {
    List<Guid> UserIds { get; }
    
    static object CreateObj(List<Guid> userIds)
    {
      return new
      {
        UserIds = userIds
      };
    }
  }
}
