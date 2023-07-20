using System;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Common;

public interface ICheckDepartmentsExistence
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
