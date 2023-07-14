using System;

namespace DigitalOffice.Models.Broker.Requests.Department;

public interface IGetDepartmentExtendedDataRequest
{
  Guid DepartmentId { get; }
  bool IncludeUsersRoles { get; }
  bool? IsActiveUsers { get; }

  static object CreateObj(
    Guid departmentId,
    bool includeUsersRoles,
    bool? isActiveUsers = true)
  {
    return new
    {
      DepartmentId = departmentId,
      IncludeUsersRoles = includeUsersRoles,
      isActiveUSers = isActiveUsers
    };
  }
}
