using System;
using System.Collections.Generic;

namespace LT.DigitalOffice.Models.Broker.Requests.Department
{
  public interface IGetDepartmentsUsersRequest
  {
    List<Guid> DepartmentsIds { get; }
    DateTime? ByEntryDate { get; }

    static object CreateObj(
      List<Guid> departmentsIds,
      DateTime? byEntryDate = null)
    {
      return new
      {
        DepartmentsIds = departmentsIds,
        ByEntryDate = byEntryDate
      };
    }
  }
}
