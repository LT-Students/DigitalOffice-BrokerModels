using System;
using System.Collections.Generic;

namespace DigitalOffice.Models.Broker.Requests.Filter
{
  public interface IFilterProjectUsersRequest
  {
    List<Guid> ProjectIds { get; }
    
    static object CreateObj(List<Guid> projectIds)
    {
      return new
      {
        ProjectIds = projectIds
      };
    }
  }
}
