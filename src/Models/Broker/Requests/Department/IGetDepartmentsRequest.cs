using System;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Requests.Department
{
  public interface IGetDepartmentsRequest
  {
    List<Guid> DepartmentsIds { get; }
    List<Guid> UsersIds { get; }

    static object CreateObj(
      List<Guid> departmentsIds = null,
      List<Guid> usersIds = null)
    {
      return new
      {
        DepartmentsIds = departmentsIds,
        UsersIds = usersIds
      };
    }
  }
}
