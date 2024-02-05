using System;
using System.Collections.Generic;

namespace DigitalOffice.Models.Broker.Requests.Filter
{
  public interface IFilterCompanyUsersRequest
  {
    List<Guid> RoleIds { get; }

    static object CreateObj(List<Guid> roleIds)
    {
      return new 
      {
        RoleIds = roleIds
      };
    }
  }
}
