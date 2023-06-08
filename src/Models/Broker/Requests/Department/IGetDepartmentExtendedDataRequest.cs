using System;

namespace DigitalOffice.Models.Broker.Requests.Department;

public interface IGetDepartmentExtendedDataRequest
{
  Guid DepartmentId { get; }
  bool IncludeUsersRoles { get; }

  static object CretateObj(
    Guid departmentId,
    bool includeUsersRoles)
  {
    return new
    {
      DepartmentId = departmentId,
      IncludeUsersRoles = includeUsersRoles
    };
  }
}
