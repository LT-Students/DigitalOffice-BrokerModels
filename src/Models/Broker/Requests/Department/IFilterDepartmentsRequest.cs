using System;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Requests.Department;

public interface IFilterDepartmentsRequest
{
  List<Guid> DepartmentsIds { get; }

  static object CreateObj(List<Guid> departmentsIds)
  {
    return new
    {
      DepartmentsIds = departmentsIds
    };
  }
}
