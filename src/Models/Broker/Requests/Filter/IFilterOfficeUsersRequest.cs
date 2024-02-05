using System;
using System.Collections.Generic;

namespace DigitalOffice.Models.Broker.Requests.Filter
{
  public interface IFilterOfficeUsersRequest
  {
    List<Guid> OfficeIds { get; }
    
    static object CreateObj(List<Guid> officeIds)
    {
      return new
      {
        OfficeIds = officeIds
      };
    }
  }
}
