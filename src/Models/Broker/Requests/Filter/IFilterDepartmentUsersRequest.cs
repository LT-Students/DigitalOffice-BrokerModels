using System;
using System.Collections.Generic;

namespace DigitalOffice.Models.Broker.Requests.Filter
{
  public interface IFilterDepartmentUsersRequest
  {
    List<Guid> DepartmentIds { get; }
    
    static object CreateObj(List<Guid> departmentIds)
    {
      return new
      {
        DepartmentIds = departmentIds
      };
    }
  }
}
